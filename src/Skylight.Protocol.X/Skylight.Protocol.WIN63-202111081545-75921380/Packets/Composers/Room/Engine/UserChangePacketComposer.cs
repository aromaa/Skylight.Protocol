using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Room.Engine;

[PacketComposerId(2711u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserChangePacketComposer : IOutgoingPacketComposer<UserChangeOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserChangeOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Id);
		writer.WriteFixedUInt16String(packet.Figure);
		writer.WriteFixedUInt16String(packet.Sex);
		writer.WriteFixedUInt16String(packet.CustomInfo);
		writer.WriteInt32(packet.AchievementScore);
	}
}
