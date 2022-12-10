using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Recycler;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Recycler;

[PacketParserId(886u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetRecyclerStatusPacketParser : IIncomingPacketParser<GetRecyclerStatusPacketParser.GetRecyclerStatusIncomingPacket>
{
	public GetRecyclerStatusIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetRecyclerStatusIncomingPacket();
	}

	internal readonly struct GetRecyclerStatusIncomingPacket : IGetRecyclerStatusIncomingPacket
	{
	}
}
