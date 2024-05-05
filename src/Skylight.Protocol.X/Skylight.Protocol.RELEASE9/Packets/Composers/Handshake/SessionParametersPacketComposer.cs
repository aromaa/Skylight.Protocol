using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE9.Packets.Composers.Handshake;

[PacketComposerId(257u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SessionParametersPacketComposer : IOutgoingPacketComposer<SessionParametersOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in SessionParametersOutgoingPacket packet)
	{
		writer.WriteVL64Int32(0);
	}
}
