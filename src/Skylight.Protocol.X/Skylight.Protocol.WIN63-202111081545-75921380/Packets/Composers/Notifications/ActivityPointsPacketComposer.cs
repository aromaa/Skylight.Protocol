using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Notifications;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Notifications;

[PacketComposerId(3222u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ActivityPointsPacketComposer : IOutgoingPacketComposer<ActivityPointsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ActivityPointsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.ActivityPoints.Count);
		foreach (var activityPoints in packet.ActivityPoints)
		{
			writer.WriteInt32(activityPoints.Type);
			writer.WriteInt32(activityPoints.Balance);
		}
	}
}
