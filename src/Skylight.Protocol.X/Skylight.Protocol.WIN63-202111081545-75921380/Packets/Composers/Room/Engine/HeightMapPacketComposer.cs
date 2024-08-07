using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(3778u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class HeightMapPacketComposer : IOutgoingPacketComposer<HeightMapOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in HeightMapOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Width);
		writer.WriteInt32(packet.HeightMap.Count);
		foreach (var heightMap in packet.HeightMap)
		{
			writer.WriteInt16((short)heightMap.ModernFormat);
		}
	}
}
