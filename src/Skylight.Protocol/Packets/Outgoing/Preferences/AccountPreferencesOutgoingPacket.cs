using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Preferences;

public sealed class AccountPreferencesOutgoingPacket : IGameOutgoingPacket
{
	public required int UIVolume { get; init; }
	public required int FurniVolume { get; init; }
	public required int TraxVolume { get; init; }

	public required bool FreeFlowChatDisabled { get; init; }
	public required bool RoomInvitesIgnored { get; init; }
	public required bool RoomCameraFollowDisabled { get; init; }

	public required int UIFlags { get; init; }
	public required int PreferredChatStyle { get; init; }

	public AccountPreferencesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public AccountPreferencesOutgoingPacket(int uIVolume, int furniVolume, int traxVolume, bool freeFlowChatDisabled, bool roomInvitesIgnored, bool roomCameraFollowDisabled, int uiFlags, int preferredChatStyle)
	{
		this.UIVolume = uIVolume;
		this.FurniVolume = furniVolume;
		this.TraxVolume = traxVolume;

		this.FreeFlowChatDisabled = freeFlowChatDisabled;
		this.RoomInvitesIgnored = roomInvitesIgnored;
		this.RoomCameraFollowDisabled = roomCameraFollowDisabled;

		this.UIFlags = uiFlags;
		this.PreferredChatStyle = preferredChatStyle;
	}
}
