using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Advertisement;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Parsers.Advertisement;

[PacketParserId(182u)]
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
