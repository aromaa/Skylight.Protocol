using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Sound;

[PacketParserId(242u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SaveSongEditPacketParser : IIncomingPacketParser<SaveSongEditPacketParser.SaveSongEditIncomingPacket>
{
	public SaveSongEditIncomingPacket Parse(ref PacketReader reader)
	{
		return new SaveSongEditIncomingPacket
		{
			SongId = (int)reader.ReadVL64UInt32(),
			Name = reader.ReadBytes(reader.ReadBase64UInt32(2)),
			SongData = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct SaveSongEditIncomingPacket : ISaveSongEditIncomingPacket
	{
		public int SongId { get; init; }
		public ReadOnlySequence<byte> Name { get; init; }
		public ReadOnlySequence<byte> SongData { get; init; }
	}
}
