namespace Skylight.Protocol.Packets.Incoming.Sound;

public interface IDeleteSongIncomingPacket : IGameIncomingPacket
{
	public int SongId { get; }
}
