using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Catalog;

[PacketParserId(3047u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetCatalogPagePacketParser : IIncomingPacketParser<GetCatalogPagePacketParser.GetCatalogPageIncomingPacket>
{
	public GetCatalogPageIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetCatalogPageIncomingPacket
		{
			PageId = reader.ReadInt32(),
			OfferId = reader.ReadInt32(),
			CatalogType = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct GetCatalogPageIncomingPacket : IGetCatalogPageIncomingPacket
	{
		public int PageId { get; init; }
		public int OfferId { get; init; }
		public ReadOnlySequence<byte> CatalogType { get; init; }
	}
}
