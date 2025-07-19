using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Notifications;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Notifications;

[PacketComposerId(3414u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ActivityPointNotificationPacketComposer : IOutgoingPacketComposer<ActivityPointNotificationOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ActivityPointNotificationOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Balance);
		writer.WriteInt32(packet.Change);
		writer.WriteInt32(packet.Type);
	}
}
