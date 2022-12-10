using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.NewNavigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.NewNavigator;

[PacketComposerId(783u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NavigatorSearchResultBlocksPacketComposer : IOutgoingPacketComposer<NavigatorSearchResultBlocksOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NavigatorSearchResultBlocksOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.SearchCode);
		writer.WriteFixedUInt16String(packet.Filtering);
		writer.WriteInt32(packet.Results.Count);
		foreach (var results in packet.Results)
		{
			writer.WriteFixedUInt16String(results.SearchCode);
			writer.WriteFixedUInt16String(results.Text);
			writer.WriteInt32(results.ActionAllowed);
			writer.WriteBool(results.ForceClosed);
			writer.WriteInt32(results.ViewMode);
			writer.WriteInt32(results.Rooms.Count);
			foreach (var rooms in results.Rooms)
			{
				writer.WriteInt32(rooms.Id);
				writer.WriteFixedUInt16String(rooms.Name);
				writer.WriteInt32(1);
				writer.WriteFixedUInt16String(rooms.OwnerName);
				writer.WriteInt32(0);
				writer.WriteInt32(rooms.UserCount);
				writer.WriteInt32(10);
				writer.WriteFixedUInt16String("Description");
				writer.WriteInt32(0);
				writer.WriteInt32(13);
				writer.WriteInt32(2);
				writer.WriteInt32(1);
				writer.WriteInt32(0);
				writer.WriteInt32(8);
			}
		}
	}
}
