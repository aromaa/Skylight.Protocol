using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE6.Packets.Composers.Handshake;

[PacketComposerId(3u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class AuthenticationOKPacketComposer : IOutgoingPacketComposer<AuthenticationOKOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in AuthenticationOKOutgoingPacket packet)
	{
	}
}
