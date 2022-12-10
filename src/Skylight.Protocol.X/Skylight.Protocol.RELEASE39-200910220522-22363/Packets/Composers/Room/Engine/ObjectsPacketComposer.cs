using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Engine;

[PacketComposerId(32u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ObjectsPacketComposer : IOutgoingPacketComposer<ObjectsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ObjectsOutgoingPacket packet)
	{
		writer.WriteVL64Int32(0);
	}
}
