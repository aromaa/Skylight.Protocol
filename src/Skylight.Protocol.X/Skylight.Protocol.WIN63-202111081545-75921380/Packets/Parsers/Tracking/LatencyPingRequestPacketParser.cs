using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Tracking;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Tracking;

[PacketParserId(579u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class LatencyPingRequestPacketParser : IIncomingPacketParser<LatencyPingRequestPacketParser.LatencyPingRequestIncomingPacket>
{
	public LatencyPingRequestIncomingPacket Parse(ref PacketReader reader)
	{
		return new LatencyPingRequestIncomingPacket
		{
			RequestId = reader.ReadInt32()
		};
	}

	internal readonly struct LatencyPingRequestIncomingPacket : ILatencyPingRequestIncomingPacket
	{
		public int RequestId { get; init; }
	}
}
