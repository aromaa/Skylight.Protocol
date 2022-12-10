using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Purse;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Purse;

[PacketParserId(1958u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetCreditsInfoPacketParser : IIncomingPacketParser<GetCreditsInfoPacketParser.GetCreditsInfoIncomingPacket>
{
	public GetCreditsInfoIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetCreditsInfoIncomingPacket();
	}

	internal readonly struct GetCreditsInfoIncomingPacket : IGetCreditsInfoIncomingPacket
	{
	}
}
