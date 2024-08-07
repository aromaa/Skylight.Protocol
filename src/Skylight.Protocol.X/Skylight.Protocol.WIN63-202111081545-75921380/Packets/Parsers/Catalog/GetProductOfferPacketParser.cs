using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Catalog;

[PacketParserId(268u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetProductOfferPacketParser : IIncomingPacketParser<GetProductOfferPacketParser.GetProductOfferIncomingPacket>
{
	public GetProductOfferIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetProductOfferIncomingPacket
		{
			OfferId = reader.ReadInt32()
		};
	}

	internal readonly struct GetProductOfferIncomingPacket : IGetProductOfferIncomingPacket
	{
		public int OfferId { get; init; }
	}
}
