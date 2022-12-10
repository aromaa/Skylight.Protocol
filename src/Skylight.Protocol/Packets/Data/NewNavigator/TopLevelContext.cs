using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.NewNavigator;

public sealed class TopLevelContext
{
	public required string SearchCode { get; init; }

	public required ICollection<SavedSearchData> QuickLinks { get; init; }

	public TopLevelContext()
	{
	}

	[SetsRequiredMembers]
	public TopLevelContext(string searchCode, ICollection<SavedSearchData> quickLinks)
	{
		this.SearchCode = searchCode;

		this.QuickLinks = quickLinks;
	}
}
