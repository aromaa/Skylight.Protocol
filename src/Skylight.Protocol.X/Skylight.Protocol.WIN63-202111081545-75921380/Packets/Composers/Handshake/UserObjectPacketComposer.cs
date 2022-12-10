using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Handshake;

[PacketComposerId(2853u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserObjectPacketComposer : IOutgoingPacketComposer<UserObjectOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserObjectOutgoingPacket packet)
	{
		writer.WriteInt32(packet.UserId);
		writer.WriteFixedUInt16String(packet.Username);
		writer.WriteFixedUInt16String(packet.Figure);
		writer.WriteFixedUInt16String(packet.Gender);
		writer.WriteFixedUInt16String(packet.CustomData);
		writer.WriteFixedUInt16String(packet.RealName);
		writer.WriteBool(packet.DirectMail);
		writer.WriteInt32(packet.RespectTotal);
		writer.WriteInt32(packet.RespectLeft);
		writer.WriteInt32(packet.PerRespectLeft);
		writer.WriteBool(packet.StreamPublishingAllowed);
		writer.WriteFixedUInt16String(packet.LastAccessDate.ToString());
		writer.WriteBool(packet.NameChangeAllowed);
		writer.WriteBool(packet.AccountSafetyLocked);
	}
}
