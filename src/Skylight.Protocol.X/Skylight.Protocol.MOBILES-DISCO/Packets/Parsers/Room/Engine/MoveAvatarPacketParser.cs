using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Engine;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Parsers.Room.Engine;

[PacketParserId("Move")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MoveAvatarPacketParser : IIncomingPacketParser<MoveAvatarPacketParser.MoveAvatarIncomingPacket>
{
	public MoveAvatarIncomingPacket Parse(ref PacketReader reader)
	{
		return new MoveAvatarIncomingPacket
		{
			X = Utf8Parser.TryParse(reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> _x, (byte)' ') ? _x.ToArray() : reader.ReadBytes(reader.Remaining).ToArray(), out int x, out _) ? x : default,
			Y = Utf8Parser.TryParse(reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> _y, (byte)' ') ? _y.ToArray() : reader.ReadBytes(reader.Remaining).ToArray(), out int y, out _) ? y : default
		};
	}

	internal readonly struct MoveAvatarIncomingPacket : IMoveAvatarIncomingPacket
	{
		public int X { get; init; }
		public int Y { get; init; }
	}
}
