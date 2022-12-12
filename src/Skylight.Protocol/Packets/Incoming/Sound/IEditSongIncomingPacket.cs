namespace Skylight.Protocol.Packets.Incoming.Sound;

public interface IEditSongIncomingPacket : IGameIncomingPacket
{
	public int SongId { get; }
}
