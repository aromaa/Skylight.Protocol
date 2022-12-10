using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Notifications;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Notifications;

[PacketComposerId(595u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UnseenItemsPacketComposer : IOutgoingPacketComposer<UnseenItemsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UnseenItemsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Items.Count);
		foreach (var items in packet.Items)
		{
			writer.WriteInt32(items.Category);
			writer.WriteInt32(items.Ids.Count);
			foreach (var ids in items.Ids)
			{
				writer.WriteInt32(ids);
			}
		}
	}
}
