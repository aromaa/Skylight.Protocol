using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Room.Avatar;

[PacketParserId(3605u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class LookToPacketParser : IIncomingPacketParser<LookToPacketParser.LookToIncomingPacket>
{
	public LookToIncomingPacket Parse(ref PacketReader reader)
	{
		return new LookToIncomingPacket
		{
			X = reader.ReadInt32(),
			Y = reader.ReadInt32()
		};
	}

	internal readonly struct LookToIncomingPacket : ILookToIncomingPacket
	{
		public int X { get; init; }
		public int Y { get; init; }
	}
}
