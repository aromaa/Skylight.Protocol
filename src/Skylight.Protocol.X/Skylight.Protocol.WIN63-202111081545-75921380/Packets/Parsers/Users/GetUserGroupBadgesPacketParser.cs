using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Users;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Users;

[PacketParserId(1482u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetUserGroupBadgesPacketParser : IIncomingPacketParser<GetUserGroupBadgesPacketParser.GetUserGroupBadgesIncomingPacket>
{
	public GetUserGroupBadgesIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetUserGroupBadgesIncomingPacket();
	}

	internal readonly struct GetUserGroupBadgesIncomingPacket : IGetUserGroupBadgesIncomingPacket
	{
	}
}
