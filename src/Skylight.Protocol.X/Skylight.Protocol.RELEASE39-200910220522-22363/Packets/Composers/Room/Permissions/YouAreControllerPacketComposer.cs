using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Permissions;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Permissions;

[PacketComposerId(42u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class YouAreControllerPacketComposer : IOutgoingPacketComposer<YouAreControllerOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in YouAreControllerOutgoingPacket packet)
	{
	}
}
