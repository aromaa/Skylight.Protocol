using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Session;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Session;

[PacketComposerId(999u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RoomReadyPacketComposer : IOutgoingPacketComposer<RoomReadyOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RoomReadyOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.LayoutId);
		writer.WriteInt32(packet.RoomId);
	}
}
