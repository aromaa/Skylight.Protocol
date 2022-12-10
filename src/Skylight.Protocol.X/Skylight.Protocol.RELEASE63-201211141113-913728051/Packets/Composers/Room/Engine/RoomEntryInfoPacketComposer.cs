using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(1084u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RoomEntryInfoPacketComposer : IOutgoingPacketComposer<RoomEntryInfoOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RoomEntryInfoOutgoingPacket packet)
	{
		writer.WriteBool(true);
		writer.WriteInt32(packet.RoomId);
		writer.WriteBool(packet.Owner);
	}
}
