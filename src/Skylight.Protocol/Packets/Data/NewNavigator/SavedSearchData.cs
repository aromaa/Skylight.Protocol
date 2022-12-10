using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.NewNavigator;

public sealed class SavedSearchData
{
	public required int Id { get; init; }

	public required string SearchCode { get; init; }
	public required string Filter { get; init; }
	public required string Localization { get; init; }

	public SavedSearchData()
	{
	}

	[SetsRequiredMembers]
	public SavedSearchData(int id, string searchCode, string filter, string localization)
	{
		this.Id = id;

		this.SearchCode = searchCode;
		this.Filter = filter;
		this.Localization = localization;
	}
}
