using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(9u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class HeightMapPacketComposer : IOutgoingPacketComposer<HeightMapOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in HeightMapOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.HeightMap.ToString());
	}
}
