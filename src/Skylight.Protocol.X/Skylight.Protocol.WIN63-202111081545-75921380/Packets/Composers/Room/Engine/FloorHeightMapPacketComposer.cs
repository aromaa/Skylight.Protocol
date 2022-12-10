using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(1945u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FloorHeightMapPacketComposer : IOutgoingPacketComposer<FloorHeightMapOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FloorHeightMapOutgoingPacket packet)
	{
		writer.WriteBool(packet.Scale);
		writer.WriteInt32(packet.FixedWallsHeight);
		writer.WriteFixedUInt16String(packet.HeightMap);
	}
}
