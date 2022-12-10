using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Data.NewNavigator;

namespace Skylight.Protocol.Packets.Outgoing.NewNavigator;

[IntroducedIn("WIN63-202111081545-75921380")]
public sealed class NavigatorSavedSearchesOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<SavedSearchData> SavedSearches { get; init; }

	public NavigatorSavedSearchesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NavigatorSavedSearchesOutgoingPacket(ICollection<SavedSearchData> savedSearches)
	{
		this.SavedSearches = savedSearches;
	}
}
