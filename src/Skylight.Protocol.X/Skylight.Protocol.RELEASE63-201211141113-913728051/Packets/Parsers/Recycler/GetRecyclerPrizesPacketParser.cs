using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Recycler;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Recycler;

[PacketParserId(3549u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetRecyclerPrizesPacketParser : IIncomingPacketParser<GetRecyclerPrizesPacketParser.GetRecyclerPrizesIncomingPacket>
{
	public GetRecyclerPrizesIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetRecyclerPrizesIncomingPacket();
	}

	internal readonly struct GetRecyclerPrizesIncomingPacket : IGetRecyclerPrizesIncomingPacket
	{
	}
}
