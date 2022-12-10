using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Advertisement;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Advertisement;

[PacketComposerId(258u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class InterstitialPacketComposer : IOutgoingPacketComposer<InterstitialOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in InterstitialOutgoingPacket packet)
	{
		writer.WriteDelimiter2BrokenString("");
	}
}
