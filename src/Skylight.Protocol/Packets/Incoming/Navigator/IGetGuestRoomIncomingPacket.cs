namespace Skylight.Protocol.Packets.Incoming.Navigator;

public interface IGetGuestRoomIncomingPacket : IGameIncomingPacket
{
	public int RoomId { get; }
	public bool EnterRoom { get; }
	public bool RoomForward { get; }
}
