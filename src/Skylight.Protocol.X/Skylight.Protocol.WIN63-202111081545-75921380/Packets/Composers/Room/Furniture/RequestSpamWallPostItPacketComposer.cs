using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Furniture;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Furniture;

[PacketComposerId(1309u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RequestSpamWallPostItPacketComposer : IOutgoingPacketComposer<RequestSpamWallPostItOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RequestSpamWallPostItOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Id);
		writer.WriteFixedUInt16String($"{":w="}{packet.Location.LocationX}{","}{packet.Location.LocationY}{" l="}{packet.Location.PositionX}{","}{packet.Location.PositionY}{" l"}".ToString());
	}
}
