using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Navigator;

[PacketComposerId(1606u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FlatCreatedPacketComposer : IOutgoingPacketComposer<FlatCreatedOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FlatCreatedOutgoingPacket packet)
	{
		writer.WriteInt32(packet.RoomId);
		writer.WriteFixedUInt16String(packet.RoomName);
	}
}
