using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Layout;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Layout;

[PacketComposerId(3546u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RoomEntryTilePacketComposer : IOutgoingPacketComposer<RoomEntryTileOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RoomEntryTileOutgoingPacket packet)
	{
		writer.WriteInt32(packet.X);
		writer.WriteInt32(packet.Y);
		writer.WriteInt32(packet.Direction);
	}
}
