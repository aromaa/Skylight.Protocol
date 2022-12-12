using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Sound;

[PacketParserId(241u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class EditSongPacketParser : IIncomingPacketParser<EditSongPacketParser.EditSongIncomingPacket>
{
	public EditSongIncomingPacket Parse(ref PacketReader reader)
	{
		return new EditSongIncomingPacket
		{
			SongId = (int)reader.ReadVL64UInt32()
		};
	}

	internal readonly struct EditSongIncomingPacket : IEditSongIncomingPacket
	{
		public int SongId { get; init; }
	}
}
