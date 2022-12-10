using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Catalog;

public sealed class CatalogNodeData
{
	public required int Id { get; init; }

	public required string Name { get; init; }
	public required string Localization { get; init; }

	public required bool Visible { get; init; }

	public required int Color { get; init; }
	public required int Icon { get; init; }

	public required ICollection<int> OfferIds { get; init; }

	public required ICollection<CatalogNodeData> Children { get; init; }

	public CatalogNodeData()
	{
	}

	[SetsRequiredMembers]
	public CatalogNodeData(int id, string name, string localization, bool visible, int color, int icon, ICollection<int> offerIds, ICollection<CatalogNodeData> children)
	{
		this.Id = id;

		this.Name = name;
		this.Localization = localization;

		this.Visible = visible;

		this.Color = color;
		this.Icon = icon;

		this.OfferIds = offerIds;

		this.Children = children;
	}
}
