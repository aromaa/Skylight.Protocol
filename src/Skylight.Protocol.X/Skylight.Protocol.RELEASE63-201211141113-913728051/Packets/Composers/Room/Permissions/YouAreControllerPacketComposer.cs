using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Permissions;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Permissions;

[PacketComposerId(1496u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class YouAreControllerPacketComposer : IOutgoingPacketComposer<YouAreControllerOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in YouAreControllerOutgoingPacket packet)
	{
		writer.WriteInt32(packet.RoomControllerLevel);
	}
}
