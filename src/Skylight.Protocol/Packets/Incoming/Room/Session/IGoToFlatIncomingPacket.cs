namespace Skylight.Protocol.Packets.Incoming.Room.Session;

public interface IGoToFlatIncomingPacket : IGameIncomingPacket
{
	public int RoomId { get; }
}
