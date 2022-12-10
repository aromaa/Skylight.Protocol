using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Handshake;

[PacketParserId(4000u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ClientHelloPacketParser : IIncomingPacketParser<ClientHelloPacketParser.ClientHelloIncomingPacket>
{
	public ClientHelloIncomingPacket Parse(ref PacketReader reader)
	{
		return new ClientHelloIncomingPacket
		{
			ClientVersion = reader.ReadBytes(reader.ReadInt16())
		};
	}

	internal readonly struct ClientHelloIncomingPacket : IClientHelloIncomingPacket
	{
		public ReadOnlySequence<byte> ClientVersion { get; init; }
		public ReadOnlySequence<byte> ClientName => default;
		public int ClientType => default;
		public int Unknown => default;
	}
}
