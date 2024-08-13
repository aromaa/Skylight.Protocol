using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Navigator;

[PacketComposerId(1724u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RoomInfoUpdatedPacketComposer : IOutgoingPacketComposer<RoomInfoUpdatedOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RoomInfoUpdatedOutgoingPacket packet)
	{
		writer.WriteInt32(packet.RoomId);
	}
}
