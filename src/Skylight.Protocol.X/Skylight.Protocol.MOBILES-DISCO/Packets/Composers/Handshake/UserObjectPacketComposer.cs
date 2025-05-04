using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Composers.Handshake;

[PacketComposerId("USEROBJECT")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserObjectPacketComposer : IOutgoingPacketComposer<UserObjectOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserObjectOutgoingPacket packet)
	{
		writer.WriteDelimiter2BrokenString($"{packet.Username}{" "}{"-"}{" "}{"email@example.com"}{" "}{packet.Figure}{" "}{"fixed"}{" "}{"?"}{" "}{packet.Gender}{" "}{packet.DirectMail}{" "}{"69"}{" "}{packet.CustomData}".ToString());
	}
}
