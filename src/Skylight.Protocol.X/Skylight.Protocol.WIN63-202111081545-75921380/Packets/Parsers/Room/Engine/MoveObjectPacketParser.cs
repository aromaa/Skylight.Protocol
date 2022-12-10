using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Engine;

[PacketParserId(2378u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MoveObjectPacketParser : IIncomingPacketParser<MoveObjectPacketParser.MoveObjectIncomingPacket>
{
	public MoveObjectIncomingPacket Parse(ref PacketReader reader)
	{
		return new MoveObjectIncomingPacket
		{
			Id = reader.ReadInt32(),
			X = reader.ReadInt32(),
			Y = reader.ReadInt32(),
			Direction = reader.ReadInt32()
		};
	}

	internal readonly struct MoveObjectIncomingPacket : IMoveObjectIncomingPacket
	{
		public int Id { get; init; }
		public int X { get; init; }
		public int Y { get; init; }
		public int Direction { get; init; }
	}
}
