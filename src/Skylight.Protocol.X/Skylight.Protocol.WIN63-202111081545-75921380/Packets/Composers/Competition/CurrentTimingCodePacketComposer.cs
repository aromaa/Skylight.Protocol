using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Competition;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Competition;

[PacketComposerId(2441u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CurrentTimingCodePacketComposer : IOutgoingPacketComposer<CurrentTimingCodeOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CurrentTimingCodeOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.SchedulingCode);
		writer.WriteFixedUInt16String(packet.Code);
	}
}
