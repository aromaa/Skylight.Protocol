﻿using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(3580u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ObjectsPacketComposer<TRoomItemId, TRoomItemIdConverter> : IOutgoingPacketComposer<ObjectsOutgoingPacket<TRoomItemId>>
	where TRoomItemIdConverter : Skylight.Protocol.Packets.Convertors.Room.Engine.IRoomItemIdConverter<TRoomItemId>
{
	public void Compose(ref PacketWriter writer, in ObjectsOutgoingPacket<TRoomItemId> packet)
	{
		writer.WriteInt32(packet.OwnerNames.Count);
		foreach (var ownerNames in packet.OwnerNames)
		{
			writer.WriteInt32(ownerNames.UserId);
			writer.WriteFixedUInt16String(ownerNames.Username);
		}
		writer.WriteInt32(packet.Objects.Count);
		foreach (var objects in packet.Objects)
		{
			writer.WriteInt32(TRoomItemIdConverter.Convert(objects.Id));
			writer.WriteInt32(objects.FurnitureId);
			writer.WriteInt32(objects.X);
			writer.WriteInt32(objects.Y);
			writer.WriteInt32(objects.Direction);
			writer.WriteFixedUInt16String(objects.Z.ToString(CultureInfo.InvariantCulture));
			writer.WriteInt32(objects.Extra);
			if (objects.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
			{
				writer.WriteInt32(4);
			}
			else if (objects.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.LegacyItemData legacyItemData)
			{
				writer.WriteInt32(0);
				writer.WriteFixedUInt16String(legacyItemData.Data);
			}
			else if (objects.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItInventoryData postItInventoryData)
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
		}
	}
}
