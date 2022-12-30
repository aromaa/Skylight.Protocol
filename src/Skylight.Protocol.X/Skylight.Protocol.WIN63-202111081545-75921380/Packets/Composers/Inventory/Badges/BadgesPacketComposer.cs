using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Badges;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Inventory.Badges;

[PacketComposerId(3563u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class BadgesPacketComposer : IOutgoingPacketComposer<BadgesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in BadgesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.TotalFragments);
		writer.WriteInt32(packet.FragmentId);
		writer.WriteInt32(packet.Fragment.Count);
		foreach (var fragment in packet.Fragment)
		{
			writer.WriteInt32(fragment.BadgeId);
			writer.WriteFixedUInt16String(fragment.BadgeCode);
		}
	}
}
