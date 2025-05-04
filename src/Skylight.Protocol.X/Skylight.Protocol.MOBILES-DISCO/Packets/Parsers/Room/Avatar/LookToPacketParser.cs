using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Avatar;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Parsers.Room.Avatar;

[PacketParserId("LOOKTO")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class LookToPacketParser : IIncomingPacketParser<LookToPacketParser.LookToIncomingPacket>
{
	public LookToIncomingPacket Parse(ref PacketReader reader)
	{
		return new LookToIncomingPacket
		{
			X = Utf8Parser.TryParse(reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> _x, (byte)' ') ? _x.ToArray() : reader.ReadBytes(reader.Remaining).ToArray(), out int x, out _) ? x : default,
			Y = Utf8Parser.TryParse(reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> _y, (byte)' ') ? _y.ToArray() : reader.ReadBytes(reader.Remaining).ToArray(), out int y, out _) ? y : default
		};
	}

	internal readonly struct LookToIncomingPacket : ILookToIncomingPacket
	{
		public int X { get; init; }
		public int Y { get; init; }
	}
}
