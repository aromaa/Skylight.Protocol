using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Composers.Room.Chat;

[PacketComposerId("CHAT")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ChatPacketComposer : IOutgoingPacketComposer<ChatOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ChatOutgoingPacket packet)
	{
		writer.WriteDelimiter2BrokenString($"{packet.Username}{" "}{packet.Text}".ToString());
	}
}
