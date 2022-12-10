using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Handshake;

[PacketParserId(840u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CompleteDiffieHandshakePacketParser : IIncomingPacketParser<CompleteDiffieHandshakePacketParser.CompleteDiffieHandshakeIncomingPacket>
{
	public CompleteDiffieHandshakeIncomingPacket Parse(ref PacketReader reader)
	{
		return new CompleteDiffieHandshakeIncomingPacket
		{
			PublicKey = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct CompleteDiffieHandshakeIncomingPacket : ICompleteDiffieHandshakeIncomingPacket
	{
		public ReadOnlySequence<byte> PublicKey { get; init; }
	}
}
