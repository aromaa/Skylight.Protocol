using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Engine;

[PacketComposerId(32u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ObjectsPacketComposer<TRoomItemId, TRoomItemIdConverter> : IOutgoingPacketComposer<ObjectsOutgoingPacket<TRoomItemId>>
	where TRoomItemIdConverter : Skylight.Protocol.Packets.Convertors.Room.Engine.IRoomItemIdConverter<TRoomItemId>
{
	public void Compose(ref PacketWriter writer, in ObjectsOutgoingPacket<TRoomItemId> packet)
	{
		writer.WriteVL64Int32(packet.Objects.Count);
		foreach (var objects in packet.Objects)
		{
			writer.WriteVL64Int32(TRoomItemIdConverter.Convert(objects.Id));
			writer.WriteVL64Int32(objects.FurnitureId);
			writer.WriteVL64Int32(objects.X);
			writer.WriteVL64Int32(objects.Y);
			writer.WriteVL64Int32(objects.Direction);
			writer.WriteDelimiter2BrokenString(objects.Z.ToString(CultureInfo.InvariantCulture));
			writer.WriteVL64Int32(objects.Extra);
			writer.WriteDelimiter2BrokenString("");
			writer.WriteVL64Int32(-1);
		}
	}
}
