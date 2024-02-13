using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Handshake;

[PacketComposerId(277u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InitDiffieHandshakePacketComposer : IOutgoingPacketComposer<InitDiffieHandshakeOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in InitDiffieHandshakeOutgoingPacket packet)
	{
		writer.WriteDelimiter2BrokenString(packet.EncryptedPrime);
		writer.WriteVL64Int32(packet.ServerClientEncryption ? 1 : 0);
	}
}
