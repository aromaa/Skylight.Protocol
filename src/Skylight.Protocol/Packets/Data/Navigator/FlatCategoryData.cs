using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Navigator;

public sealed class FlatCategoryData
{
	public required int Id { get; init; }

	public required string Name { get; init; }

	public required bool Visible { get; init; }
	public required bool Automatic { get; init; }

	public required string AutomaticCategory { get; init; }
	public required string GlobalCategory { get; init; }

	public required bool StaffOnly { get; init; }

	public FlatCategoryData()
	{
	}

	[SetsRequiredMembers]
	public FlatCategoryData(int id, string name, bool visible, bool automatic, string automaticCategory, string globalCategory, bool staffOnly)
	{
		this.Id = id;

		this.Name = name;

		this.Visible = visible;
		this.Automatic = automatic;

		this.AutomaticCategory = automaticCategory;
		this.GlobalCategory = globalCategory;

		this.StaffOnly = staffOnly;
	}
}
