using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Catalog;

public interface IGetCatalogPageIncomingPacket : IGameIncomingPacket
{
	public int PageId { get; }
	public int OfferId { get; }
	public ReadOnlySequence<byte> CatalogType { get; }
}
