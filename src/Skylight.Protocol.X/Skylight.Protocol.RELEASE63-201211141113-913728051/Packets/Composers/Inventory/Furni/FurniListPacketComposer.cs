using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Furni;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Inventory.Furni;

[PacketComposerId(177u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FurniListPacketComposer : IOutgoingPacketComposer<FurniListOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FurniListOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String("S");
		writer.WriteInt32(packet.TotalFragments);
		writer.WriteInt32(packet.FragmentId);
		writer.WriteInt32(packet.Fragment.Count);
		foreach (var fragment in packet.Fragment)
		{
			writer.WriteInt32(fragment.StripId);
			if (fragment.Type is Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
			{
				writer.WriteFixedUInt16String("S");
			}
			else if (fragment.Type is Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Wall)
			{
				writer.WriteFixedUInt16String("I");
			}
			else
			{
				throw new NotSupportedException();
			}
			writer.WriteInt32(fragment.ItemId);
			writer.WriteInt32(fragment.FurnitureId);
			writer.WriteInt32(fragment.Category);
			if (fragment.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
			{
				writer.WriteInt32(4);
			}
			else if (fragment.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItInventoryData postItInventoryData)
			{
				writer.WriteInt32(0);
				writer.WriteFixedUInt16String(postItInventoryData.Count.ToString());
			}
			else if (fragment.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItRoomData postItRoomData)
			{
				writer.WriteFixedUInt16String($"{postItRoomData.Color.ToArgb():X6}{" "}{postItRoomData.Text}".ToString());
			}
			else
			{
				throw new NotSupportedException();
			}
			writer.WriteBool(true);
			writer.WriteBool(true);
			writer.WriteBool(true);
			writer.WriteBool(true);
			writer.WriteInt32(-1);
			if (fragment.Type == Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
			{
				writer.WriteFixedUInt16String("");
			}
			if (fragment.Type == Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
			{
				writer.WriteInt32(0);
			}
		}
	}
}
