using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.UserDefinedRoomEvents;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.UserDefinedRoomEvents;

[PacketComposerId(2442u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class WiredSaveSuccessPacketComposer : IOutgoingPacketComposer<WiredSaveSuccessOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in WiredSaveSuccessOutgoingPacket packet)
	{
	}
}
