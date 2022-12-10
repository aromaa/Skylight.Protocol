namespace Skylight.Protocol.Packets.Incoming.Room.Engine;

public interface IUseFurnitureIncomingPacket : IGameIncomingPacket
{
	public int Id { get; }
	public int State { get; }
}
