using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Catalog;

[PacketParserId(3038u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetCatalogIndexPacketParser : IIncomingPacketParser<GetCatalogIndexPacketParser.GetCatalogIndexIncomingPacket>
{
	public GetCatalogIndexIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetCatalogIndexIncomingPacket();
	}

	internal readonly struct GetCatalogIndexIncomingPacket : IGetCatalogIndexIncomingPacket
	{
		public ReadOnlySequence<byte> CatalogType => default;
	}
}
