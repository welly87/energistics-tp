using Energistics.Etp.v12.Datatypes.ChannelData;
using Energistics.Etp.v12.Protocol.ChannelSubscribe;
using Microsoft.Hadoop.Avro;
using System;
using System.Collections.Generic;
using System.IO;
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

        [Fact]
        public void Should_serialize_deserialize_object()
        {
            var settings = new AvroSerializerSettings
            {
                GenerateDeserializer = true,
                GenerateSerializer = true,
                Resolver = new AvroPublicMemberContractResolver(false),
                MaxItemsInSchemaTree = 40,
                UseCache = true
            };


            //var avroSerializer2 = AvroSerializer.Create<ChannelRangeInfo>(settings);
            var avroSerializer = AvroSerializer.Create<GetRange>(settings);

            var message = new GetRange
            {
                ChannelRanges = new List<ChannelRangeInfo>
                {
                    new ChannelRangeInfo { ChannelId = new List<long> { 1, 2, 3 }, Interval = new Etp.v12.Datatypes.Object.IndexInterval{ DepthDatum = "datum", EndIndex = new Etp.v12.Datatypes.IndexValue { Item = 0.0 }, StartIndex = new Etp.v12.Datatypes.IndexValue { Item=0.0 }, Uom = "Uom"} }
                },
                RequestUuid = new Etp.v12.Datatypes.Uuid
                {
                    Value = new byte[16]
                }
            };

            using (var buffer = new MemoryStream())
            {
                avroSerializer.Serialize(buffer, message);

                buffer.Seek(0, SeekOrigin.Begin);

                var result = avroSerializer.Deserialize(buffer);

                Console.WriteLine(result);
            }
        }

    }
}
