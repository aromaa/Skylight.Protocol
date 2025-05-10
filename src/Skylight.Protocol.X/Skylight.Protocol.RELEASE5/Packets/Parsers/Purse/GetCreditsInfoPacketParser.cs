using System.Buffers;
using System.Buffers.Text;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Purse;
using Net.Buffers;
using Net.Buffers.Extensions;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE5.Packets.Parsers.Purse;

[PacketParserId("GETCREDITS")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetCreditsInfoPacketParser : IIncomingPacketParser<GetCreditsInfoPacketParser.GetCreditsInfoIncomingPacket>
{
	public GetCreditsInfoIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetCreditsInfoIncomingPacket();
	}

	internal readonly struct GetCreditsInfoIncomingPacket : IGetCreditsInfoIncomingPacket
	{
	}
}
