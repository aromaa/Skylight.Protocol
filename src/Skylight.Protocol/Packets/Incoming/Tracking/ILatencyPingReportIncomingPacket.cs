namespace Skylight.Protocol.Packets.Incoming.Tracking;

public interface ILatencyPingReportIncomingPacket : IGameIncomingPacket
{
	public int AverageLatency { get; }
	public int AverageLowLatency { get; }
	public int DataPoints { get; }
}
