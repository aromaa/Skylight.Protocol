using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Sound;

[PacketParserId(239u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NewSongPacketParser : IIncomingPacketParser<NewSongPacketParser.NewSongIncomingPacket>
{
	public NewSongIncomingPacket Parse(ref PacketReader reader)
	{
		return new NewSongIncomingPacket();
	}

	internal readonly struct NewSongIncomingPacket : INewSongIncomingPacket
	{
	}
}
