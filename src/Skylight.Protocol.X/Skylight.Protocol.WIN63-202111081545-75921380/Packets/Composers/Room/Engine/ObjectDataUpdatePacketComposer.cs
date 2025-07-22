using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(3458u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ObjectDataUpdatePacketComposer<TRoomItemId, TRoomItemIdConverter> : IOutgoingPacketComposer<ObjectDataUpdateOutgoingPacket<TRoomItemId>>
	where TRoomItemIdConverter : Skylight.Protocol.Packets.Convertors.Room.Engine.IRoomItemIdConverter<TRoomItemId>
{
	public void Compose(ref PacketWriter writer, in ObjectDataUpdateOutgoingPacket<TRoomItemId> packet)
	{
		writer.WriteFixedUInt16String(TRoomItemIdConverter.Convert(packet.ItemId).ToString());
		if (packet.Data is Skylight.Protocol.Packets.Data.Room.Object.Data.EmptyItemData emptyItemData)
		{
			writer.WriteInt32(4);
		}
		else if (packet.Data is Skylight.Protocol.Packets.Data.Room.Object.Data.LegacyItemData legacyItemData)
		{
			writer.WriteInt32(0);
			writer.WriteFixedUInt16String(legacyItemData.Data);
		}
		else
		{
			throw new NotSupportedException();
		}
	}
}
