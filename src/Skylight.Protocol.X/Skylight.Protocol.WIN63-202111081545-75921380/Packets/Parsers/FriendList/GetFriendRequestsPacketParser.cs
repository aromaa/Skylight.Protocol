using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.FriendList;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.FriendList;

[PacketParserId(2682u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetFriendRequestsPacketParser : IIncomingPacketParser<GetFriendRequestsPacketParser.GetFriendRequestsIncomingPacket>
{
	public GetFriendRequestsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetFriendRequestsIncomingPacket();
	}

	internal readonly struct GetFriendRequestsIncomingPacket : IGetFriendRequestsIncomingPacket
	{
	}
}
