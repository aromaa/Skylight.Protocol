namespace Skylight.Protocol.Packets.Incoming.Room.Session;

public interface IOpenConnectionIncomingPacket : IGameIncomingPacket
{
	public int InstanceType { get; }
	public int InstanceId { get; }
	public int WorldId { get; }
}
