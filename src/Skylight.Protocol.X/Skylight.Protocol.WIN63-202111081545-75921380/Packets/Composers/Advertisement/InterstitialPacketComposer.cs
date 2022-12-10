using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Advertisement;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Advertisement;

[PacketComposerId(1996u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InterstitialPacketComposer : IOutgoingPacketComposer<InterstitialOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in InterstitialOutgoingPacket packet)
	{
		writer.WriteBool(packet.CanShowInterstitial);
	}
}
