using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Marketplace;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Marketplace;

[PacketParserId(116u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetMarketplaceConfigurationPacketParser : IIncomingPacketParser<GetMarketplaceConfigurationPacketParser.GetMarketplaceConfigurationIncomingPacket>
{
	public GetMarketplaceConfigurationIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetMarketplaceConfigurationIncomingPacket();
	}

	internal readonly struct GetMarketplaceConfigurationIncomingPacket : IGetMarketplaceConfigurationIncomingPacket
	{
	}
}
