using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Navigator;

public sealed class EventCategoryData
{
	public required int Id { get; init; }

	public required string Name { get; init; }

	public required bool Visible { get; init; }

	public EventCategoryData()
	{
	}

	[SetsRequiredMembers]
	public EventCategoryData(int id, string name, bool visible)
	{
		this.Id = id;

		this.Name = name;

		this.Visible = visible;
	}
}
