using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.FriendList;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.FriendList;

[PacketParserId(1237u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MessengerInitPacketParser : IIncomingPacketParser<MessengerInitPacketParser.MessengerInitIncomingPacket>
{
	public MessengerInitIncomingPacket Parse(ref PacketReader reader)
	{
		return new MessengerInitIncomingPacket();
	}

	internal readonly struct MessengerInitIncomingPacket : IMessengerInitIncomingPacket
	{
	}
}
