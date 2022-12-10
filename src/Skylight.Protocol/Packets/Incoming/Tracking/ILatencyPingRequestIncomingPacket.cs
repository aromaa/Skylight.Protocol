namespace Skylight.Protocol.Packets.Incoming.Tracking;

public interface ILatencyPingRequestIncomingPacket : IGameIncomingPacket
{
	public int RequestId { get; }
}
