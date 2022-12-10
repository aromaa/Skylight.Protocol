using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Furni;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Inventory.Furni;

[PacketComposerId(140u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FurniListPacketComposer : IOutgoingPacketComposer<FurniListOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FurniListOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Fragment.Count);
		foreach (var fragment in packet.Fragment)
		{
			writer.WriteVL64Int32(fragment.StripId);
			writer.WriteVL64Int32(fragment.StripId);
			writer.WriteDelimiter2BrokenString(fragment.Type.ToString());
			writer.WriteVL64Int32(fragment.ItemId);
			writer.WriteVL64Int32(fragment.FurnitureId);
			writer.WriteVL64Int32(fragment.Category);
			if (fragment.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
			{
				writer.WriteDelimiter2BrokenString("");
			}
			else if (fragment.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItInventoryData postItInventoryData)
			{
				writer.WriteDelimiter2BrokenString(postItInventoryData.Count.ToString());
			}
			else if (fragment.ExtraData is Skylight.Protocol.Packets.Data.Room.Object.Data.Wall.PostItRoomData postItRoomData)
			{
				writer.WriteDelimiter2BrokenString($"{postItRoomData.Color.ToArgb():X6}{" "}{postItRoomData.Text}".ToString());
			}
			else
			{
				throw new NotSupportedException();
			}
			writer.WriteVL64Int32(1);
			writer.WriteVL64Int32(1);
			writer.WriteVL64Int32(1);
			writer.WriteVL64Int32(-1);
			if (fragment.Type == Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
			{
				writer.WriteDelimiter2BrokenString("");
			}
			if (fragment.Type == Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
			{
				writer.WriteVL64Int32(-1);
			}
		}
		writer.WriteVL64Int32(packet.TotalFragments);
	}
}
