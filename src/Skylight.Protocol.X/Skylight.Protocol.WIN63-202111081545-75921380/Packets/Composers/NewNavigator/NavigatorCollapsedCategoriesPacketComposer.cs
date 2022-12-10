using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.NewNavigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.NewNavigator;

[PacketComposerId(3516u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NavigatorCollapsedCategoriesPacketComposer : IOutgoingPacketComposer<NavigatorCollapsedCategoriesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NavigatorCollapsedCategoriesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.CollapsedCategories.Count);
		foreach (var collapsedCategories in packet.CollapsedCategories)
		{
			writer.WriteFixedUInt16String(collapsedCategories);
		}
	}
}
