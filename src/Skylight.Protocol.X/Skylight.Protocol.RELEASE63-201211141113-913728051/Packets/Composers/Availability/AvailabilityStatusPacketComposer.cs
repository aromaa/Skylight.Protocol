using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Availability;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Availability;

[PacketComposerId(1060u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class AvailabilityStatusPacketComposer : IOutgoingPacketComposer<AvailabilityStatusOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in AvailabilityStatusOutgoingPacket packet)
	{
		writer.WriteBool(packet.IsOpen);
		writer.WriteBool(packet.IsClosing);
	}
}
