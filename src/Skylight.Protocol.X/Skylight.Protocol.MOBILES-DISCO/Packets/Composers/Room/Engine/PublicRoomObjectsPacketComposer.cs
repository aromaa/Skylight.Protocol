using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Composers.Room.Engine;

[PacketComposerId("OBJECTS")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PublicRoomObjectsPacketComposer : IOutgoingPacketComposer<PublicRoomObjectsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in PublicRoomObjectsOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Objects.Count);
		foreach (var objects in packet.Objects)
		{
			writer.WriteDelimiter2BrokenString($"{objects.Id}{" "}{objects.SpriteId}{" "}{objects.X}{" "}{objects.Y}{" "}{objects.Z}{" "}{objects.Direction}".ToString());
		}
	}
}
