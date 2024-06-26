using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Avatar;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Avatar;

[PacketParserId(1098u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetWardrobePacketParser : IIncomingPacketParser<GetWardrobePacketParser.GetWardrobeIncomingPacket>
{
	public GetWardrobeIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetWardrobeIncomingPacket();
	}

	internal readonly struct GetWardrobeIncomingPacket : IGetWardrobeIncomingPacket
	{
	}
}
