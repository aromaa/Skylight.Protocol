using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Navigator;

namespace Skylight.Protocol.Packets.Data.NewNavigator;

public sealed class SearchResultData
{
	public required string SearchCode { get; init; }
	public required string Text { get; init; }

	public required int ActionAllowed { get; init; }
	public required bool ForceClosed { get; init; }
	public required int ViewMode { get; init; }

	public required ICollection<GuestRoomData> Rooms { get; init; }

	public SearchResultData()
	{
	}

	[SetsRequiredMembers]
	public SearchResultData(string searchCode, string text, int actionAllowed, bool forceClosed, int viewMode, ICollection<GuestRoomData> rooms)
	{
		this.SearchCode = searchCode;
		this.Text = text;

		this.ActionAllowed = actionAllowed;
		this.ForceClosed = forceClosed;
		this.ViewMode = viewMode;

		this.Rooms = rooms;
	}
}
