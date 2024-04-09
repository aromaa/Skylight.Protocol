using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.UserDefinedRoomEvents;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.UserDefinedRoomEvents;

[PacketComposerId(1688u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class WiredFurniActionPacketComposer : IOutgoingPacketComposer<WiredFurniActionOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in WiredFurniActionOutgoingPacket packet)
	{
		writer.WriteBool(true);
		writer.WriteInt32(0);
		writer.WriteInt32(0);
		writer.WriteInt32(0);
		writer.WriteInt32(packet.ItemId);
		writer.WriteFixedUInt16String(packet.ExtraData);
		writer.WriteInt32(0);
		writer.WriteInt32(0);
		writer.WriteInt32(7);
		writer.WriteInt32(0);
		writer.WriteInt32(0);
	}
}
