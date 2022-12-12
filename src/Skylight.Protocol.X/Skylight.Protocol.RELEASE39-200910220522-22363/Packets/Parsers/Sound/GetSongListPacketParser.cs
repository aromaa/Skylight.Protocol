using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Sound;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Sound;

[PacketParserId(244u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetSongListPacketParser : IIncomingPacketParser<GetSongListPacketParser.GetSongListIncomingPacket>
{
	public GetSongListIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetSongListIncomingPacket();
	}

	internal readonly struct GetSongListIncomingPacket : IGetSongListIncomingPacket
	{
	}
}
