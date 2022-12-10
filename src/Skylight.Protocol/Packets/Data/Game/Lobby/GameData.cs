using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Game.Lobby;

public sealed class GameData
{
	public required int Id { get; init; }

	public required string Name { get; init; }
	public required string BackgroundColor { get; init; }
	public required string TextColor { get; init; }
	public required string Icon { get; init; }

	public GameData()
	{
	}

	[SetsRequiredMembers]
	public GameData(int id, string name, string backgroundColor, string textColor, string icon)
	{
		this.Id = id;

		this.Name = name;
		this.BackgroundColor = backgroundColor;
		this.TextColor = textColor;
		this.Icon = icon;
	}
}
