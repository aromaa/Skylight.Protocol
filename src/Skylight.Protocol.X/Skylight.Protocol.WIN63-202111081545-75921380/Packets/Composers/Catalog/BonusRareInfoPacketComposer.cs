using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Catalog;

[PacketComposerId(2851u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class BonusRareInfoPacketComposer : IOutgoingPacketComposer<BonusRareInfoOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in BonusRareInfoOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.ProductType);
		writer.WriteInt32(packet.ProductClassId);
		writer.WriteInt32(packet.TotalCoinsForBonus);
		writer.WriteInt32(packet.CoinsStillRequiredToBuy);
	}
}
