using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Preferences;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Preferences;

[PacketComposerId(1488u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class AccountPreferencesPacketComposer : IOutgoingPacketComposer<AccountPreferencesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in AccountPreferencesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.UIVolume);
		writer.WriteInt32(packet.FurniVolume);
		writer.WriteInt32(packet.TraxVolume);
		writer.WriteBool(packet.FreeFlowChatDisabled);
		writer.WriteBool(packet.RoomInvitesIgnored);
		writer.WriteBool(packet.RoomCameraFollowDisabled);
		writer.WriteInt32(packet.UIFlags);
		writer.WriteInt32(packet.PreferredChatStyle);
	}
}
