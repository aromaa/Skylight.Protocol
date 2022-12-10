namespace Skylight.Protocol.Packets.Incoming.Room.Engine;

public interface IMoveObjectIncomingPacket : IGameIncomingPacket
{
	public int Id { get; }
	public int X { get; }
	public int Y { get; }
	public int Direction { get; }
}
