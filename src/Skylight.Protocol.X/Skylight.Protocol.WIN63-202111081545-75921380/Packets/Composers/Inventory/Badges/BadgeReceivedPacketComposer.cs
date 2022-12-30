using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Badges;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Inventory.Badges;

[PacketComposerId(2628u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class BadgeReceivedPacketComposer : IOutgoingPacketComposer<BadgeReceivedOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in BadgeReceivedOutgoingPacket packet)
	{
		writer.WriteInt32(packet.BadgeId);
		writer.WriteFixedUInt16String(packet.BadgeCode);
	}
}
