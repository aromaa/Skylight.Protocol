using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE9.Packets.Composers.Registration;

[PacketComposerId(36u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ApproveNameReplyPacketComposer : IOutgoingPacketComposer<ApproveNameReplyOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ApproveNameReplyOutgoingPacket packet)
	{
		writer.WriteVL64Int32((int)packet.Result);
	}
}
