using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Catalog;

[PacketParserId(2245u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PurchaseFromCatalogPacketParser : IIncomingPacketParser<PurchaseFromCatalogPacketParser.PurchaseFromCatalogIncomingPacket>
{
	public PurchaseFromCatalogIncomingPacket Parse(ref PacketReader reader)
	{
		return new PurchaseFromCatalogIncomingPacket
		{
			PageId = reader.ReadInt32(),
			OfferId = reader.ReadInt32(),
			ExtraData = reader.ReadBytes(reader.ReadInt16()),
			Amount = reader.ReadInt32()
		};
	}

	internal readonly struct PurchaseFromCatalogIncomingPacket : IPurchaseFromCatalogIncomingPacket
	{
		public int PageId { get; init; }
		public int OfferId { get; init; }
		public ReadOnlySequence<byte> ExtraData { get; init; }
		public int Amount { get; init; }
	}
}
