using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Handshake;

[PacketParserId(7u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InfoRetrievePacketParser : IIncomingPacketParser<InfoRetrievePacketParser.InfoRetrieveIncomingPacket>
{
	public InfoRetrieveIncomingPacket Parse(ref PacketReader reader)
	{
		return new InfoRetrieveIncomingPacket();
	}

	internal readonly struct InfoRetrieveIncomingPacket : IInfoRetrieveIncomingPacket
	{
	}
}
