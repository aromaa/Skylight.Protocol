using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Parsers.Navigator;

[PacketParserId(2570u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetUserFlatCatsPacketParser : IIncomingPacketParser<GetUserFlatCatsPacketParser.GetUserFlatCatsIncomingPacket>
{
	public GetUserFlatCatsIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetUserFlatCatsIncomingPacket();
	}

	internal readonly struct GetUserFlatCatsIncomingPacket : IGetUserFlatCatsIncomingPacket
	{
	}
}
