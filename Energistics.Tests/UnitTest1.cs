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

            await client.ConnectAsync(new Uri("ws://localhost:5000/etp"), CancellationToken.None);

            
        }
    }
}
