using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(3096u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ItemsPacketComposer<TRoomItemId, TRoomItemIdConverter> : IOutgoingPacketComposer<ItemsOutgoingPacket<TRoomItemId>>
	where TRoomItemIdConverter : Skylight.Protocol.Packets.Convertors.Room.Engine.IRoomItemIdConverter<TRoomItemId>
{
	public void Compose(ref PacketWriter writer, in ItemsOutgoingPacket<TRoomItemId> packet)
	{
		writer.WriteInt32(packet.OwnerNames.Count);
		foreach (var ownerNames in packet.OwnerNames)
		{
			writer.WriteInt32(ownerNames.UserId);
			writer.WriteFixedUInt16String(ownerNames.Username);
		}
		writer.WriteInt32(packet.Items.Count);
		foreach (var items in packet.Items)
		{
			writer.WriteFixedUInt16String(TRoomItemIdConverter.Convert(items.Id).ToString());
			writer.WriteInt32(items.FurnitureId);
			writer.WriteFixedUInt16String($"{":w="}{items.Position.LocationX}{","}{items.Position.LocationY}{" l="}{items.Position.PositionX}{","}{items.Position.PositionY}{" l"}".ToString());
			if (items.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
			{
				writer.WriteInt32(4);
			}
			else if (items.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.LegacyItemData legacyItemData)
			{
				writer.WriteInt32(0);
				writer.WriteFixedUInt16String(legacyItemData.Data);
			}
			else if (items.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItInventoryData postItInventoryData)
			{
				writer.WriteInt32(0);
				writer.WriteFixedUInt16String(postItInventoryData.Count.ToString());
			}
			else
			{
				throw new NotSupportedException();
			}
			writer.WriteInt32(1);
			writer.WriteInt32(1);
		}
	}
}
