using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.RoomSettings;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.RoomSettings;

[PacketComposerId(586u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RoomSettingsDataPacketComposer : IOutgoingPacketComposer<RoomSettingsDataOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RoomSettingsDataOutgoingPacket packet)
	{
		writer.WriteInt32(packet.RoomId);
		writer.WriteFixedUInt16String(packet.Name);
		writer.WriteFixedUInt16String(packet.Description);
		writer.WriteInt32((int)packet.EntryMode);
		writer.WriteInt32(packet.CategoryId);
		writer.WriteInt32(packet.UsersMax);
		writer.WriteInt32(packet.UsersMaxLimit);
		writer.WriteInt32(packet.Tags.Count);
		foreach (var tags in packet.Tags)
		{
			writer.WriteFixedUInt16String(tags);
		}
		writer.WriteInt32((int)packet.TradeMode);
		writer.WriteInt32(packet.AllowPets ? 1 : 0);
		writer.WriteInt32(packet.AllowPetsToEat ? 1 : 0);
		writer.WriteInt32(packet.WalkThrough ? 1 : 0);
		writer.WriteInt32(packet.HideWalls ? 1 : 0);
		writer.WriteInt32(packet.WallThickness);
		writer.WriteInt32(packet.FloorThickness);
		writer.WriteInt32(packet.RoomChatSettings.Mode);
		writer.WriteInt32(packet.RoomChatSettings.BubbleWidth);
		writer.WriteInt32(packet.RoomChatSettings.ScrollSpeed);
		writer.WriteInt32(packet.RoomChatSettings.HearRange);
		writer.WriteInt32(packet.RoomChatSettings.FloodSensitivity);
		writer.WriteBool(packet.AllowNavigatorListing);
		writer.WriteInt32(packet.RoomModerationSettings.WhoCanMute);
		writer.WriteInt32(packet.RoomModerationSettings.WhoCanKick);
		writer.WriteInt32(packet.RoomModerationSettings.WhoCanBan);
	}
}
