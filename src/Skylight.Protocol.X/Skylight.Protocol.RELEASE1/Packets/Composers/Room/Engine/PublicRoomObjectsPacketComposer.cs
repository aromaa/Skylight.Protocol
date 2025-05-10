using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE1.Packets.Composers.Room.Engine;

[PacketComposerId(" OBJECTS ")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PublicRoomObjectsPacketComposer : Skylight.Protocol.Packets.Outgoing.IGameOutgoingPacketComposer<PublicRoomObjectsOutgoingPacket>
{
	public void AppendHeader(ref PacketWriter writer, in PublicRoomObjectsOutgoingPacket packet)
	{
		writer.WriteBytes(System.Text.Encoding.ASCII.GetBytes(packet.LayoutId.ToString()));
	}
	
	public void Compose(ref PacketWriter writer, in PublicRoomObjectsOutgoingPacket packet)
	{
		foreach (var objects in packet.Objects)
		{
			writer.WriteDelimiterBrokenString($"{objects.Id}{" "}{objects.SpriteId}{" "}{objects.X}{" "}{objects.Y}{" "}{objects.Z}{" "}{objects.Direction}".ToString(), (byte)'\r');
		}
	}
}
