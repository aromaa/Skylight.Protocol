using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Badges;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Inventory.Badges;

[PacketComposerId(9u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class BadgePointLimitsPacketComposer : IOutgoingPacketComposer<BadgePointLimitsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in BadgePointLimitsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.BadgePointLimits.Count);
		foreach (var badgePointLimits in packet.BadgePointLimits)
		{
			writer.WriteFixedUInt16String(badgePointLimits.BadgeCode);
			writer.WriteInt32(badgePointLimits.Limits.Count);
			foreach (var limits in badgePointLimits.Limits)
			{
				writer.WriteInt32(limits.Level);
				writer.WriteInt32(limits.Limit);
			}
		}
	}
}
