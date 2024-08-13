namespace Skylight.Protocol.Packets.Incoming.RoomSettings;

public interface IGetRoomSettingsIncomingPacket : IGameIncomingPacket
{
	public int RoomId { get; }
}
