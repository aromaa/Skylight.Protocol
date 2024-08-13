using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.RoomSettings;

public sealed class RoomModerationSettingsData
{
	public required int WhoCanMute { get; init; }
	public required int WhoCanKick { get; init; }
	public required int WhoCanBan { get; init; }

	public RoomModerationSettingsData()
	{
	}

	[SetsRequiredMembers]
	public RoomModerationSettingsData(int whoCanMute, int whoCanKick, int whoCanBan)
	{
		this.WhoCanMute = whoCanMute;
		this.WhoCanKick = whoCanKick;
		this.WhoCanBan = whoCanBan;
	}
}
