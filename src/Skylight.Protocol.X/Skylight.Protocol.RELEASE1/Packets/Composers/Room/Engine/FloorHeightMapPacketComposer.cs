using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE1.Packets.Composers.Room.Engine;

[PacketComposerId("HEIGHTMAP")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FloorHeightMapPacketComposer : IOutgoingPacketComposer<FloorHeightMapOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FloorHeightMapOutgoingPacket packet)
	{
		writer.WriteText(packet.HeightMap.ToString());
	}
}
