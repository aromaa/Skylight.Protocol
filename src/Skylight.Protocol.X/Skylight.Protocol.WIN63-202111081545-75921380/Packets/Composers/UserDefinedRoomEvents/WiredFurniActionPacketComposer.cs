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
		writer.WriteBool(false);
		writer.WriteInt32(packet.MaxSelectedItems);
		writer.WriteInt32(packet.SelectedItems.Count);
		foreach (var selectedItems in packet.SelectedItems)
		{
			writer.WriteInt32(selectedItems);
		}
		writer.WriteInt32(packet.FurnitureId);
		writer.WriteInt32(packet.ItemId);
		writer.WriteFixedUInt16String(packet.StringParameter);
		writer.WriteInt32(packet.IntegerParameters.Count);
		foreach (var integerParameters in packet.IntegerParameters)
		{
			writer.WriteInt32(integerParameters);
		}
		writer.WriteInt32(0);
		writer.WriteInt32((int)packet.Type);
		writer.WriteInt32(packet.Delay);
		writer.WriteInt32(0);
	}
}
