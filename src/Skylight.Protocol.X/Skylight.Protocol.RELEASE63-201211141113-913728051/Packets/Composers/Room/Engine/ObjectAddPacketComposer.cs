using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(1243u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ObjectAddPacketComposer<TRoomItemId, TRoomItemIdConverter> : IOutgoingPacketComposer<ObjectAddOutgoingPacket<TRoomItemId>>
	where TRoomItemIdConverter : Skylight.Protocol.Packets.Convertors.Room.Engine.IRoomItemIdConverter<TRoomItemId>
{
	public void Compose(ref PacketWriter writer, in ObjectAddOutgoingPacket<TRoomItemId> packet)
	{
		writer.WriteInt32(TRoomItemIdConverter.Convert(packet.Object.Id));
		writer.WriteInt32(packet.Object.FurnitureId);
		writer.WriteInt32(packet.Object.X);
		writer.WriteInt32(packet.Object.Y);
		writer.WriteInt32(packet.Object.Direction);
		writer.WriteFixedUInt16String(packet.Object.Z.ToString(CultureInfo.InvariantCulture));
		writer.WriteInt32(packet.Object.Extra);
		if (packet.Object.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
		{
			writer.WriteInt32(4);
		}
		else if (packet.Object.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.LegacyItemData legacyItemData)
		{
			writer.WriteInt32(0);
			writer.WriteFixedUInt16String(legacyItemData.Data);
		}
		else if (packet.Object.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItInventoryData postItInventoryData)
		{
			writer.WriteInt32(0);
			writer.WriteFixedUInt16String(postItInventoryData.Count.ToString());
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
