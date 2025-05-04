using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Handshake;

[PacketParserId(3183u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InfoRetrievePacketParser : IIncomingPacketParser<InfoRetrievePacketParser.InfoRetrieveIncomingPacket>
{
	public InfoRetrieveIncomingPacket Parse(ref PacketReader reader)
	{
		return new InfoRetrieveIncomingPacket();
	}

	internal readonly struct InfoRetrieveIncomingPacket : IInfoRetrieveIncomingPacket
	{
		public ReadOnlySequence<byte> Username => default;
		public ReadOnlySequence<byte> Password => default;
	}
}
