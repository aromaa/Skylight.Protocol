using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Chat;

[PacketComposerId(24u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ChatPacketComposer : IOutgoingPacketComposer<ChatOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ChatOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.UserId);
		writer.WriteDelimiter2BrokenString(packet.Text);
		writer.WriteVL64Int32(packet.Gesture);
	}
}
