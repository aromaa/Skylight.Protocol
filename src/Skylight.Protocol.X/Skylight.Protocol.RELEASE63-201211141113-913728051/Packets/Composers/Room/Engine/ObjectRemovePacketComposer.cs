﻿using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(2113u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ObjectRemovePacketComposer : IOutgoingPacketComposer<ObjectRemoveOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ObjectRemoveOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.ItemId.ToString());
		writer.WriteInt32(packet.Expired ? 1 : 0);
		writer.WriteInt32(packet.PickerId);
	}
}
