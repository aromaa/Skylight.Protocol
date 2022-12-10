using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Handshake;

[PacketParserId(2002u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CompleteDiffieHandshakePacketParser : IIncomingPacketParser<CompleteDiffieHandshakePacketParser.CompleteDiffieHandshakeIncomingPacket>
{
	public CompleteDiffieHandshakeIncomingPacket Parse(ref PacketReader reader)
	{
		return new CompleteDiffieHandshakeIncomingPacket
		{
			PublicKey = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct CompleteDiffieHandshakeIncomingPacket : ICompleteDiffieHandshakeIncomingPacket
	{
		public ReadOnlySequence<byte> PublicKey { get; init; }
	}
}
