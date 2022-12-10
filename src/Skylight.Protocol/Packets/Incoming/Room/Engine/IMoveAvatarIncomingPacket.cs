namespace Skylight.Protocol.Packets.Incoming.Room.Engine;

public interface IMoveAvatarIncomingPacket : IGameIncomingPacket
{
	public int X { get; }
	public int Y { get; }
}
