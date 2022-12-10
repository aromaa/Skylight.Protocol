using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.NewNavigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.NewNavigator;

[PacketComposerId(3301u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NavigatorSavedSearchesPacketComposer : IOutgoingPacketComposer<NavigatorSavedSearchesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NavigatorSavedSearchesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.SavedSearches.Count);
		foreach (var savedSearches in packet.SavedSearches)
		{
			writer.WriteInt32(savedSearches.Id);
			writer.WriteFixedUInt16String(savedSearches.SearchCode);
			writer.WriteFixedUInt16String(savedSearches.Filter);
			writer.WriteFixedUInt16String(savedSearches.Localization);
		}
	}
}
