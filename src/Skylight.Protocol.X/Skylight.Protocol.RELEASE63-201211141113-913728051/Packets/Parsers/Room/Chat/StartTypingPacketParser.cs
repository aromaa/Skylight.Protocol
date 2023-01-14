using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Room.Chat;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Room.Chat;

[PacketParserId(1123u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class StartTypingPacketParser : IIncomingPacketParser<StartTypingPacketParser.StartTypingIncomingPacket>
{
	public StartTypingIncomingPacket Parse(ref PacketReader reader)
	{
		return new StartTypingIncomingPacket();
	}

	internal readonly struct StartTypingIncomingPacket : IStartTypingIncomingPacket
	{
	}
}
