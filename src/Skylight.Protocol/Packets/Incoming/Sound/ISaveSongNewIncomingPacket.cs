using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Sound;

public interface ISaveSongNewIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Name { get; }
	public ReadOnlySequence<byte> SongData { get; }
}
