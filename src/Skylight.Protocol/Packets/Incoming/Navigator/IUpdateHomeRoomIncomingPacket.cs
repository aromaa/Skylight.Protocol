namespace Skylight.Protocol.Packets.Incoming.Navigator;

public interface IUpdateHomeRoomIncomingPacket : IGameIncomingPacket
{
	public int RoomId { get; }
}
