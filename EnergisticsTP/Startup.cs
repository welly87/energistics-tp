using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Hadoop.Avro;
using System;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnergisticsTP
{
    public class Startup
    {
        private const int BufferSize = 4096;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvc();

            app.UseWebSockets();

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/etp")
                {
                    if (context.WebSockets.IsWebSocketRequest)
                    {
                        var webSocket = await context.WebSockets.AcceptWebSocketAsync();
                        
                        await HandleConnections(webSocket);
                    }
                    else
                    {
                        context.Response.StatusCode = 400;
                    }
                }
                else
                {
                    await next();
                }

            });
        }

        private async Task HandleConnections(WebSocket webSocket)
        {
            // TODO we need to receive the complete package here. Please relook at the System.IO.Pipeline
            var token = new CancellationToken();

            while (webSocket.State == WebSocketState.Open)
            {
                var buffer = new ArraySegment<byte>(new byte[BufferSize]);

                var result = await webSocket.ReceiveAsync(buffer, token);
                
                if (!result.EndOfMessage || result.CloseStatus.HasValue)
                    continue;
                
                var bytes = buffer.Slice(0, result.Count).ToArray();

                if (result.MessageType == WebSocketMessageType.Binary)
                {
                    OnDataReceived(bytes);
                }
                else // json encoding
                {
                    var message = Encoding.UTF8.GetString(bytes, 0, bytes.Length);

                    OnMessageReceived(message);
                }
            }

        }

        private void OnMessageReceived(string message)
        {
            Console.WriteLine(message);
        }

        private void OnDataReceived(byte[] bytes)
        {
            //AvroSerializer.Create<MessageHeader>
            Console.WriteLine(bytes.Length);
        }
    }
}
