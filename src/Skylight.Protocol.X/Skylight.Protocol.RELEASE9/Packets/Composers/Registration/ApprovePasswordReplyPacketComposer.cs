﻿using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE9.Packets.Composers.Registration;

[PacketComposerId(282u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ApprovePasswordReplyPacketComposer : IOutgoingPacketComposer<ApprovePasswordReplyOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ApprovePasswordReplyOutgoingPacket packet)
	{
		writer.WriteVL64Int32((int)packet.Result);
	}
}
