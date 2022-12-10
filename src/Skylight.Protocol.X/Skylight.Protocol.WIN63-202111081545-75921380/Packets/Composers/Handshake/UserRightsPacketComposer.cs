using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Handshake;

[PacketComposerId(554u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserRightsPacketComposer : IOutgoingPacketComposer<UserRightsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserRightsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.ClubLevel);
		writer.WriteInt32(packet.SecurityLevel);
		writer.WriteBool(packet.Ambassador);
	}
}
