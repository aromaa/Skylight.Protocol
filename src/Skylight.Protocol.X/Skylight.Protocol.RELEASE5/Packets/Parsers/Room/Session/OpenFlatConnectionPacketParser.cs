using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Session;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE5.Packets.Parsers.Room.Session;

[PacketParserId("TRYFLAT")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class OpenFlatConnectionPacketParser : IIncomingPacketParser<OpenFlatConnectionPacketParser.OpenFlatConnectionIncomingPacket>
{
	public OpenFlatConnectionIncomingPacket Parse(ref PacketReader reader)
	{
		return new OpenFlatConnectionIncomingPacket
		{
			RoomId = Utf8Parser.TryParse(reader.GetReaderRef().IsNext((byte)'/', advancePast: true) && reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> _roomid, (byte)'/') ? _roomid.ToArray() : reader.ReadBytes(reader.Remaining).ToArray(), out int roomid, out _) ? roomid : default,
			Password = reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> password, (byte)' ') ? password : reader.ReadBytes(reader.Remaining)
		};
	}

	internal readonly struct OpenFlatConnectionIncomingPacket : IOpenFlatConnectionIncomingPacket
	{
		public int RoomId { get; init; }
		public ReadOnlySequence<byte> Password { get; init; }
		public int Unused => default;
	}
}
