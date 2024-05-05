using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Handshake;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE9.Packets.Parsers.Handshake;

[PacketParserId(181u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetSessionParametersPacketParser : IIncomingPacketParser<GetSessionParametersPacketParser.GetSessionParametersIncomingPacket>
{
	public GetSessionParametersIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetSessionParametersIncomingPacket();
	}

	internal readonly struct GetSessionParametersIncomingPacket : IGetSessionParametersIncomingPacket
	{
	}
}
