using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Handshake;

[PacketComposerId(1492u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NoobnessLevelPacketComposer : IOutgoingPacketComposer<NoobnessLevelOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NoobnessLevelOutgoingPacket packet)
	{
		writer.WriteInt32(packet.NoobnessLevel);
	}
}
