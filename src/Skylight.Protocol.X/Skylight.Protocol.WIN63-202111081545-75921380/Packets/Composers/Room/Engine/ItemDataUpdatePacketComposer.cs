using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(93u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ItemDataUpdatePacketComposer : IOutgoingPacketComposer<ItemDataUpdateOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ItemDataUpdateOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.ItemId.ToString());
		if (packet.ItemData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
		{
			writer.WriteInt32(4);
		}
		else if (packet.ItemData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItInventoryData postItInventoryData)
		{
			writer.WriteInt32(0);
			writer.WriteFixedUInt16String(postItInventoryData.Count.ToString());
		}
		else if (packet.ItemData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItRoomData postItRoomData)
		{
			writer.WriteFixedUInt16String($"{postItRoomData.Color.ToArgb():X6}{" "}{postItRoomData.Text}".ToString());
		}
		else
		{
			throw new NotSupportedException();
		}
	}
}
