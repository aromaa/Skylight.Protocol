using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(2866u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ItemAddPacketComposer<TRoomItemId, TRoomItemIdConverter> : IOutgoingPacketComposer<ItemAddOutgoingPacket<TRoomItemId>>
	where TRoomItemIdConverter : Skylight.Protocol.Packets.Convertors.Room.Engine.IRoomItemIdConverter<TRoomItemId>
{
	public void Compose(ref PacketWriter writer, in ItemAddOutgoingPacket<TRoomItemId> packet)
	{
		writer.WriteFixedUInt16String(TRoomItemIdConverter.Convert(packet.Item.Id).ToString());
		writer.WriteInt32(packet.Item.FurnitureId);
		writer.WriteFixedUInt16String($"{":w="}{packet.Item.Position.LocationX}{","}{packet.Item.Position.LocationY}{" l="}{packet.Item.Position.PositionX}{","}{packet.Item.Position.PositionY}{" l"}".ToString());
		if (packet.Item.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyWallItemData)
		{
			writer.WriteFixedUInt16String("");
		}
		else if (packet.Item.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.LegacyItemData legacyWallItemData)
		{
			writer.WriteFixedUInt16String(legacyWallItemData.Data);
		}
		else if (packet.Item.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItRoomData postItRoomData)
		{
			writer.WriteFixedUInt16String($"{postItRoomData.Color.ToArgb():X6}{" "}{postItRoomData.Text}".ToString());
		}
		else
		{
			throw new NotSupportedException();
		}
		writer.WriteInt32(-1);
		writer.WriteInt32(1);
		writer.WriteInt32(1);
		writer.WriteFixedUInt16String(packet.OwnerName);
	}
}
