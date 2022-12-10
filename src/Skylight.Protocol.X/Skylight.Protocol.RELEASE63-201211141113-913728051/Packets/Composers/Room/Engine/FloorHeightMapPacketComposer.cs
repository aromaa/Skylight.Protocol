using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(2483u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FloorHeightMapPacketComposer : IOutgoingPacketComposer<FloorHeightMapOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FloorHeightMapOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.HeightMap);
	}
}
