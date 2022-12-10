using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Handshake;

[PacketComposerId(5u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserObjectPacketComposer : IOutgoingPacketComposer<UserObjectOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserObjectOutgoingPacket packet)
	{
		writer.WriteDelimiter2BrokenString(packet.UserId.ToString());
		writer.WriteDelimiter2BrokenString(packet.Username);
		writer.WriteDelimiter2BrokenString(packet.Figure);
		writer.WriteDelimiter2BrokenString(packet.Gender);
		writer.WriteDelimiter2BrokenString(packet.CustomData);
		writer.WriteVL64Int32(packet.Tickets);
		writer.WriteDelimiter2BrokenString(packet.SwimSuit);
		writer.WriteVL64Int32(packet.Film);
		writer.WriteVL64Int32(packet.DirectMail ? 1 : 0);
		writer.WriteVL64Int32(packet.RespectTotal);
		writer.WriteVL64Int32(packet.RespectLeft);
	}
}
