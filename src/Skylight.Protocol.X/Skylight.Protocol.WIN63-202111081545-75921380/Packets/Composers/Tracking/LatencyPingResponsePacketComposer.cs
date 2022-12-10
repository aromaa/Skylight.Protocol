using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Tracking;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Tracking;

[PacketComposerId(1909u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class LatencyPingResponsePacketComposer : IOutgoingPacketComposer<LatencyPingResponseOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in LatencyPingResponseOutgoingPacket packet)
	{
		writer.WriteInt32(packet.RequestId);
	}
}
