using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Handshake;

[PacketParserId(4u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class TryLoginPacketParser : IIncomingPacketParser<TryLoginPacketParser.TryLoginIncomingPacket>
{
	public TryLoginIncomingPacket Parse(ref PacketReader reader)
	{
		return new TryLoginIncomingPacket
		{
			Username = reader.ReadBytes(reader.ReadBase64UInt32(2)),
			Password = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct TryLoginIncomingPacket : ITryLoginIncomingPacket
	{
		public ReadOnlySequence<byte> Username { get; init; }
		public ReadOnlySequence<byte> Password { get; init; }
	}
}
