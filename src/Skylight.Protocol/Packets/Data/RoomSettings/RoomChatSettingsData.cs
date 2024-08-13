using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.RoomSettings;

public sealed class RoomChatSettingsData
{
	public required int Mode { get; init; }
	public required int BubbleWidth { get; init; }
	public required int ScrollSpeed { get; init; }
	public required int HearRange { get; init; }
	public required int FloodSensitivity { get; init; }

	public RoomChatSettingsData()
	{
	}

	[SetsRequiredMembers]
	public RoomChatSettingsData(int mode, int bubbleWidth, int scrollSpeed, int hearRange, int floodSensitivity)
	{
		this.Mode = mode;
		this.BubbleWidth = bubbleWidth;
		this.ScrollSpeed = scrollSpeed;
		this.HearRange = hearRange;
		this.FloodSensitivity = floodSensitivity;
	}
}
