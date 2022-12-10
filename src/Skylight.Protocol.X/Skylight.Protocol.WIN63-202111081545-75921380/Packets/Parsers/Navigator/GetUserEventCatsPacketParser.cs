using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Navigator;

[PacketParserId(118u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetUserEventCatsPacketParser : IIncomingPacketParser<GetUserEventCatsPacketParser.GetUserEventCatsIncomingPacket>
{
	public GetUserEventCatsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetUserEventCatsIncomingPacket();
	}

	internal readonly struct GetUserEventCatsIncomingPacket : IGetUserEventCatsIncomingPacket
	{
	}
}
