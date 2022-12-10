using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Advertisement;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Advertisement;

[PacketParserId(349u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GetInterstitialPacketParser : IIncomingPacketParser<GetInterstitialPacketParser.GetInterstitialIncomingPacket>
{
	public GetInterstitialIncomingPacket Parse(ref PacketReader reader)
	{
		return new GetInterstitialIncomingPacket();
	}

	internal readonly struct GetInterstitialIncomingPacket : IGetInterstitialIncomingPacket
	{
	}
}
