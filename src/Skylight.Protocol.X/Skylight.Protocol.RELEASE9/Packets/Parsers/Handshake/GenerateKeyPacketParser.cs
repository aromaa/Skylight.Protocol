using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Handshake;

[PacketParserId(202u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GenerateKeyPacketParser : IIncomingPacketParser<GenerateKeyPacketParser.GenerateKeyIncomingPacket>
{
	public GenerateKeyIncomingPacket Parse(ref PacketReader reader)
	{
		return new GenerateKeyIncomingPacket();
	}

	internal readonly struct GenerateKeyIncomingPacket : IGenerateKeyIncomingPacket
	{
	}
}
