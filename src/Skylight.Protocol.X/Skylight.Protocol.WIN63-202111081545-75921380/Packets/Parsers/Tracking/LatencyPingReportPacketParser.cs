using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Tracking;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Tracking;

[PacketParserId(3878u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class LatencyPingReportPacketParser : IIncomingPacketParser<LatencyPingReportPacketParser.LatencyPingReportIncomingPacket>
{
	public LatencyPingReportIncomingPacket Parse(ref PacketReader reader)
	{
		return new LatencyPingReportIncomingPacket
		{
			AverageLatency = reader.ReadInt32(),
			AverageLowLatency = reader.ReadInt32(),
			DataPoints = reader.ReadInt32()
		};
	}

	internal readonly struct LatencyPingReportIncomingPacket : ILatencyPingReportIncomingPacket
	{
		public int AverageLatency { get; init; }
		public int AverageLowLatency { get; init; }
		public int DataPoints { get; init; }
	}
}
