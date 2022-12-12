using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Sound;

[PacketParserId(240u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SaveSongNewPacketParser : IIncomingPacketParser<SaveSongNewPacketParser.SaveSongNewIncomingPacket>
{
	public SaveSongNewIncomingPacket Parse(ref PacketReader reader)
	{
		return new SaveSongNewIncomingPacket
		{
			Name = reader.ReadBytes(reader.ReadBase64UInt32(2)),
			SongData = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct SaveSongNewIncomingPacket : ISaveSongNewIncomingPacket
	{
		public ReadOnlySequence<byte> Name { get; init; }
		public ReadOnlySequence<byte> SongData { get; init; }
	}
}
