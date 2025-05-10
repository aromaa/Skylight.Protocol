using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Composers.Room.Chat;

[PacketComposerId("SHOUT")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ShoutPacketComposer : IOutgoingPacketComposer<ShoutOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ShoutOutgoingPacket packet)
	{
		writer.WriteDelimiterBrokenString($"{packet.Username}{" "}{packet.Text}".ToString(), (byte)'\r');
	}
}
