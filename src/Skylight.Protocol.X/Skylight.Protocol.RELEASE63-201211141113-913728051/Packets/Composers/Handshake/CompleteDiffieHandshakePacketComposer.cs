using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Handshake;

[PacketComposerId(659u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CompleteDiffieHandshakePacketComposer : IOutgoingPacketComposer<CompleteDiffieHandshakeOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CompleteDiffieHandshakeOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.EncryptedPublicKey);
	}
}
