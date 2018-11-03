using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Energistics.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1Async()
        {
            var client = new ClientWebSocket();

            await client.ConnectAsync(new Uri("ws://localhost:62078/etp"), CancellationToken.None);

            var buffer = new ArraySegment<byte>(new byte[10]);

            await client.SendAsync(buffer, WebSocketMessageType.Binary, true, CancellationToken.None);

            buffer = new ArraySegment<byte>(new byte[20]);

            await client.SendAsync(buffer, WebSocketMessageType.Binary, true, CancellationToken.None);

            buffer = new ArraySegment<byte>(new byte[30]);

            await client.SendAsync(buffer, WebSocketMessageType.Binary, true, CancellationToken.None);
        }
    }
}
