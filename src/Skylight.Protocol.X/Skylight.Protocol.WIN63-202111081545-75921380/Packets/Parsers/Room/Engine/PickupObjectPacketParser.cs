using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Engine;

[PacketParserId(3238u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class PickupObjectPacketParser : IIncomingPacketParser<PickupObjectPacketParser.PickupObjectIncomingPacket>
{
	public PickupObjectIncomingPacket Parse(ref PacketReader reader)
	{
		return new PickupObjectIncomingPacket
		{
			ItemType = reader.ReadInt32(),
			ItemId = reader.ReadInt32()
		};
	}

	internal readonly struct PickupObjectIncomingPacket : IPickupObjectIncomingPacket
	{
		public int ItemType { get; init; }
		public int ItemId { get; init; }
	}
}
