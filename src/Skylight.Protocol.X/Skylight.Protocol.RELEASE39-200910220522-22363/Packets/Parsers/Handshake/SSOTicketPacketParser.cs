using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Handshake;

[PacketParserId(204u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SSOTicketPacketParser : IIncomingPacketParser<SSOTicketPacketParser.SSOTicketIncomingPacket>
{
	public SSOTicketIncomingPacket Parse(ref PacketReader reader)
	{
		return new SSOTicketIncomingPacket
		{
			SSOTicket = reader.ReadBytes(reader.ReadBase64UInt32(2))
		};
	}

	internal readonly struct SSOTicketIncomingPacket : ISSOTicketIncomingPacket
	{
		public ReadOnlySequence<byte> SSOTicket { get; init; }
		public int Time => default;
	}
}
