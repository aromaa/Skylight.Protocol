using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.FriendList;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.FriendList;

[PacketParserId(1504u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FriendListUpdatePacketParser : IIncomingPacketParser<FriendListUpdatePacketParser.FriendListUpdateIncomingPacket>
{
	public FriendListUpdateIncomingPacket Parse(ref PacketReader reader)
	{
		return new FriendListUpdateIncomingPacket();
	}

	internal readonly struct FriendListUpdateIncomingPacket : IFriendListUpdateIncomingPacket
	{
	}
}
