using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Furniture;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Furniture;

[PacketComposerId(1208u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PresentOpenedPacketComposer : IOutgoingPacketComposer<PresentOpenedOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in PresentOpenedOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.ItemType.ToString());
		writer.WriteInt32(packet.FurnitureId);
		writer.WriteFixedUInt16String(packet.ProductCode);
		writer.WriteInt32(packet.PlacedItemId);
		writer.WriteFixedUInt16String(packet.PlacedItemType.ToString());
		writer.WriteBool(packet.PlacedInRoom);
		writer.WriteFixedUInt16String(packet.PetFigure);
	}
}
