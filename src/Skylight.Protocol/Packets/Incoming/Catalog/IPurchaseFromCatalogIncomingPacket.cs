using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Catalog;

public interface IPurchaseFromCatalogIncomingPacket : IGameIncomingPacket
{
	public int PageId { get; }
	public int OfferId { get; }
	public ReadOnlySequence<byte> ExtraData { get; }
	public int Amount { get; }
}
