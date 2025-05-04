using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.MOBILES_DISCO.Packets.Parsers.Handshake;

[PacketParserId("LOGIN")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class TryLoginPacketParser : IIncomingPacketParser<TryLoginPacketParser.TryLoginIncomingPacket>
{
	public TryLoginIncomingPacket Parse(ref PacketReader reader)
	{
		return new TryLoginIncomingPacket
		{
			Username = reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> username, (byte)' ') ? username : reader.ReadBytes(reader.Remaining),
			Password = reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> password, (byte)' ') ? password : reader.ReadBytes(reader.Remaining)
		};
	}

	internal readonly struct TryLoginIncomingPacket : ITryLoginIncomingPacket
	{
		public ReadOnlySequence<byte> Username { get; init; }
		public ReadOnlySequence<byte> Password { get; init; }
	}
}
