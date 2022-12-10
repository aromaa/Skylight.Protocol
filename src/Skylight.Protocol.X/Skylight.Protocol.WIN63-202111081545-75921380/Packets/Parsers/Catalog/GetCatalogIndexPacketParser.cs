using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Catalog;

[PacketParserId(838u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetCatalogIndexPacketParser : IIncomingPacketParser<GetCatalogIndexPacketParser.GetCatalogIndexIncomingPacket>
{
	public GetCatalogIndexIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetCatalogIndexIncomingPacket
		{
			CatalogType = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct GetCatalogIndexIncomingPacket : IGetCatalogIndexIncomingPacket
	{
		public ReadOnlySequence<byte> CatalogType { get; init; }
	}
}
