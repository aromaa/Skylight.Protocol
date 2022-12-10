using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(2181u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ObjectRemovePacketComposer : IOutgoingPacketComposer<ObjectRemoveOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in ObjectRemoveOutgoingPacket packet)
	{
		writer.WriteFixedUInt16String(packet.ItemId.ToString());
		writer.WriteBool(packet.Expired);
		writer.WriteInt32(packet.PickerId);
		writer.WriteInt32(packet.Delay);
	}
}
