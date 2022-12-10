using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.NewNavigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.NewNavigator;

[PacketComposerId(3567u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NavigatorMetaDataPacketComposer : IOutgoingPacketComposer<NavigatorMetaDataOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NavigatorMetaDataOutgoingPacket packet)
	{
		writer.WriteInt32(packet.TopLevelContexts.Count);
		foreach (var topLevelContexts in packet.TopLevelContexts)
		{
			writer.WriteFixedUInt16String(topLevelContexts.SearchCode);
			writer.WriteInt32(topLevelContexts.QuickLinks.Count);
			foreach (var quickLinks in topLevelContexts.QuickLinks)
			{
				writer.WriteInt32(quickLinks.Id);
				writer.WriteFixedUInt16String(quickLinks.SearchCode);
				writer.WriteFixedUInt16String(quickLinks.Filter);
				writer.WriteFixedUInt16String(quickLinks.Localization);
			}
		}
	}
}
