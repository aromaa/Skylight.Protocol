using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Chat;

[PacketComposerId(640u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserTypingPacketComposer : IOutgoingPacketComposer<UserTypingOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserTypingOutgoingPacket packet)
	{
		writer.WriteInt32(packet.UserId);
		writer.WriteInt32(packet.Typing);
	}
}
