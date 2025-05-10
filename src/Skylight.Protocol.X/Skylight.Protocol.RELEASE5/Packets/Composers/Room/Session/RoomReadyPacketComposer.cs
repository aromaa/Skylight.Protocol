using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Session;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE5.Packets.Composers.Room.Session;

[PacketComposerId("FLAT_LETIN")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RoomReadyPacketComposer : IOutgoingPacketComposer<RoomReadyOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RoomReadyOutgoingPacket packet)
	{
	}
}
