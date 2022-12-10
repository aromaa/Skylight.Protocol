using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Engine;

[PacketComposerId(30u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PublicRoomObjectsPacketComposer : IOutgoingPacketComposer<PublicRoomObjectsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in PublicRoomObjectsOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Objects.Count);
		foreach (var objects in packet.Objects)
		{
			writer.WriteVL64Int32(0);
			writer.WriteDelimiter2BrokenString(objects.Id);
			writer.WriteDelimiter2BrokenString(objects.SpriteId);
			writer.WriteVL64Int32(objects.X);
			writer.WriteVL64Int32(objects.Y);
			writer.WriteVL64Int32(objects.Z);
			writer.WriteVL64Int32(objects.Direction);
		}
	}
}
