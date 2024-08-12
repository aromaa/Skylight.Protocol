using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Trading;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Inventory.Trading;

[PacketComposerId(193u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class TradingItemListPacketComposer : IOutgoingPacketComposer<TradingItemListOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in TradingItemListOutgoingPacket packet)
	{
		writer.WriteInt32(packet.FirstUserId);
		writer.WriteInt32(packet.FirstUserItems.Count);
		foreach (var firstUserItems in packet.FirstUserItems)
		{
			writer.WriteInt32(firstUserItems.FurnitureId);
			writer.WriteFixedUInt16String(firstUserItems.Type.ToString());
			writer.WriteInt32(firstUserItems.ItemId);
			writer.WriteInt32(firstUserItems.FurnitureId);
			writer.WriteInt32(firstUserItems.Category);
			writer.WriteBool(true);
			writer.WriteInt32(0);
			if (firstUserItems.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
			{
				writer.WriteInt32(4);
			}
			else if (firstUserItems.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.LegacyItemData legacyItemData)
			{
				writer.WriteInt32(0);
				writer.WriteFixedUInt16String(legacyItemData.Data);
			}
			else if (firstUserItems.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItInventoryData postItInventoryData)
			{
				writer.WriteInt32(0);
				writer.WriteFixedUInt16String(postItInventoryData.Count.ToString());
			}
			else
			{
				throw new NotSupportedException();
			}
			writer.WriteInt32(0);
			writer.WriteInt32(0);
			writer.WriteInt32(0);
			if (firstUserItems.Type == Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
			{
				writer.WriteInt32(0);
			}
		}
		writer.WriteInt32(packet.FirstUserNumItems);
		writer.WriteInt32(packet.FirstUserNumCredits);
		writer.WriteInt32(packet.SecondUserId);
		writer.WriteInt32(packet.SecondUserItems.Count);
		foreach (var secondUserItems in packet.SecondUserItems)
		{
			writer.WriteInt32(secondUserItems.FurnitureId);
			writer.WriteFixedUInt16String(secondUserItems.Type.ToString());
			writer.WriteInt32(secondUserItems.ItemId);
			writer.WriteInt32(secondUserItems.FurnitureId);
			writer.WriteInt32(secondUserItems.Category);
			writer.WriteBool(true);
			writer.WriteInt32(0);
			if (secondUserItems.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
			{
				writer.WriteInt32(4);
			}
			else if (secondUserItems.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.LegacyItemData legacyItemData)
			{
				writer.WriteInt32(0);
				writer.WriteFixedUInt16String(legacyItemData.Data);
			}
			else if (secondUserItems.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItInventoryData postItInventoryData)
			{
				writer.WriteInt32(0);
				writer.WriteFixedUInt16String(postItInventoryData.Count.ToString());
			}
			else
			{
				throw new NotSupportedException();
			}
			writer.WriteInt32(0);
			writer.WriteInt32(0);
			writer.WriteInt32(0);
			if (secondUserItems.Type == Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
			{
				writer.WriteInt32(0);
			}
		}
		writer.WriteInt32(packet.SecondUserNumItems);
		writer.WriteInt32(packet.SecondUserNumCredits);
	}
}
