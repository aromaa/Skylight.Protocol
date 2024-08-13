using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Navigator;
using Skylight.Protocol.Packets.Data.RoomSettings;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class GetGuestRoomResultOutgoingPacket : IGameOutgoingPacket
{
	public required bool EnterRoom { get; init; }
	public required bool RoomForward { get; init; }

	public required GuestRoomData Room { get; init; }

	public required bool StaffPick { get; init; }
	public required bool GroupMember { get; init; }
	public required bool CanMute { get; init; }
	public required bool AllInRoomMuted { get; init; }

	public required RoomModerationSettingsData RoomModerationSettings { get; init; }
	public required RoomChatSettingsData RoomChatSettings { get; init; }

	public GetGuestRoomResultOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public GetGuestRoomResultOutgoingPacket(bool enterRoom, bool roomForward, GuestRoomData room, bool staffPick, bool groupMember, bool canMute, bool allInRoomMuted, RoomModerationSettingsData roomModerationSettings, RoomChatSettingsData roomChatSettings)
	{
		this.EnterRoom = enterRoom;
		this.RoomForward = roomForward;

		this.Room = room;

		this.StaffPick = staffPick;
		this.GroupMember = groupMember;
		this.CanMute = canMute;
		this.AllInRoomMuted = allInRoomMuted;

		this.RoomModerationSettings = roomModerationSettings;
		this.RoomChatSettings = roomChatSettings;
	}
}
