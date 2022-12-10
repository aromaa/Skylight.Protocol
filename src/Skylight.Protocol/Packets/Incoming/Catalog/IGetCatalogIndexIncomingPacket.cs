using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Catalog;

public interface IGetCatalogIndexIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> CatalogType { get; }
}
