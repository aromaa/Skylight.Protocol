using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Notifications;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Notifications;

[PacketComposerId(278u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MOTDNotificationPacketComposer : IOutgoingPacketComposer<MOTDNotificationOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in MOTDNotificationOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Messages.Count);
		foreach (var messages in packet.Messages)
		{
			writer.WriteFixedUInt16String(messages);
		}
	}
}
