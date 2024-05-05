using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Registration;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Registration;

[PacketParserId(49u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetServerDatePacketParser : IIncomingPacketParser<GetServerDatePacketParser.GetServerDateIncomingPacket>
{
	public GetServerDateIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetServerDateIncomingPacket();
	}

	internal readonly struct GetServerDateIncomingPacket : IGetServerDateIncomingPacket
	{
	}
}
