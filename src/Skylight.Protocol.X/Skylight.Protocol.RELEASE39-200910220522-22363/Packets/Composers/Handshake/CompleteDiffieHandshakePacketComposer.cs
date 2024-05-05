using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Handshake;

[PacketComposerId(1u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CompleteDiffieHandshakePacketComposer : IOutgoingPacketComposer<CompleteDiffieHandshakeOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CompleteDiffieHandshakeOutgoingPacket packet)
	{
		writer.WriteText(packet.EncryptedPublicKey.ToString());
	}
}
