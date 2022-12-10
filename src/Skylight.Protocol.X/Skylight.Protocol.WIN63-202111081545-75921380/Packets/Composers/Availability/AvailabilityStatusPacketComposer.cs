using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Availability;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Availability;

[PacketComposerId(3684u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class AvailabilityStatusPacketComposer : IOutgoingPacketComposer<AvailabilityStatusOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in AvailabilityStatusOutgoingPacket packet)
	{
		writer.WriteBool(packet.IsOpen);
		writer.WriteBool(packet.IsClosing);
		writer.WriteBool(packet.IsAuthentic);
	}
}
