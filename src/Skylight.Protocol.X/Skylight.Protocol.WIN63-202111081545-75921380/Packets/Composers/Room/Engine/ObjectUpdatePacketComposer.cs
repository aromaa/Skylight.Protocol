﻿using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(1217u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ObjectUpdatePacketComposer : IOutgoingPacketComposer<ObjectUpdateOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ObjectUpdateOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Object.Id);
		writer.WriteInt32(packet.Object.FurnitureId);
		writer.WriteInt32(packet.Object.X);
		writer.WriteInt32(packet.Object.Y);
		writer.WriteInt32(packet.Object.Direction);
		writer.WriteFixedUInt16String(packet.Object.Z.ToString(CultureInfo.InvariantCulture));
		writer.WriteFixedUInt16String(packet.Object.SizeZ.ToString(CultureInfo.InvariantCulture));
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
		else
		{
			throw new NotSupportedException();
		}
		writer.WriteInt32(0);
		writer.WriteInt32(0);
		writer.WriteInt32(0);
	}
}
