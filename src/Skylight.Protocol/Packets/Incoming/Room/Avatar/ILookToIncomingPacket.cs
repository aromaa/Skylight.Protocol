namespace Skylight.Protocol.Packets.Incoming.Room.Avatar;

public interface ILookToIncomingPacket : IGameIncomingPacket
{
	public int X { get; }
	public int Y { get; }
}
