using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Handshake;

[PacketParserId(4000u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class ClientHelloPacketParser : IIncomingPacketParser<ClientHelloPacketParser.ClientHelloIncomingPacket>
{
	public ClientHelloIncomingPacket Parse(ref PacketReader reader)
	{
		return new ClientHelloIncomingPacket
		{
			ClientVersion = reader.ReadBytes(reader.ReadInt16()),
			ClientName = reader.ReadBytes(reader.ReadInt16()),
			ClientType = reader.ReadInt32(),
			Unknown = reader.ReadInt32()
		};
	}

	internal readonly struct ClientHelloIncomingPacket : IClientHelloIncomingPacket
	{
		public ReadOnlySequence<byte> ClientVersion { get; init; }
		public ReadOnlySequence<byte> ClientName { get; init; }
		public int ClientType { get; init; }
		public int Unknown { get; init; }
	}
}
