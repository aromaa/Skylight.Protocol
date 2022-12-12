using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Sound;

public interface ISaveSongEditIncomingPacket : IGameIncomingPacket
{
	public int SongId { get; }

	public ReadOnlySequence<byte> Name { get; }
	public ReadOnlySequence<byte> SongData { get; }
}
