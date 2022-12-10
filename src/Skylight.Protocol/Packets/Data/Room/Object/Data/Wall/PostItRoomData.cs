using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Skylight.Protocol.Packets.Data.Room.Object.Data.Wall;

public sealed class PostItRoomData : IItemData
{
	public required Color Color { get; init; }
	public required string Text { get; init; }

	public PostItRoomData()
	{
	}

	[SetsRequiredMembers]
	public PostItRoomData(Color color, string text)
	{
		this.Color = color;
		this.Text = text;
	}
}
