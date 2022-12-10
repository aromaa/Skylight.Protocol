using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Game.Lobby;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Game.Lobby;

[PacketParserId(2498u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetGameListPacketParser : IIncomingPacketParser<GetGameListPacketParser.GetGameListIncomingPacket>
{
	public GetGameListIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetGameListIncomingPacket();
	}

	internal readonly struct GetGameListIncomingPacket : IGetGameListIncomingPacket
	{
	}
}
