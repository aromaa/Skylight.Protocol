using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.LandingView;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.LandingView;

[PacketParserId(275u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetPromoArticlesPacketParser : IIncomingPacketParser<GetPromoArticlesPacketParser.GetPromoArticlesIncomingPacket>
{
	public GetPromoArticlesIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetPromoArticlesIncomingPacket();
	}

	internal readonly struct GetPromoArticlesIncomingPacket : IGetPromoArticlesIncomingPacket
	{
	}
}
