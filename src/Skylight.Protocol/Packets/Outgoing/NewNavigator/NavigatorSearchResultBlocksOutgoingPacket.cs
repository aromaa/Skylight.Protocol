using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Data.NewNavigator;

namespace Skylight.Protocol.Packets.Outgoing.NewNavigator;

[IntroducedIn("WIN63-202111081545-75921380")]
public sealed class NavigatorSearchResultBlocksOutgoingPacket : IGameOutgoingPacket
{
	public required string SearchCode { get; init; }
	public required string Filtering { get; init; }

	public required ICollection<SearchResultData> Results { get; init; }

	public NavigatorSearchResultBlocksOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NavigatorSearchResultBlocksOutgoingPacket(string searchCode, string filtering, ICollection<SearchResultData> results)
	{
		this.SearchCode = searchCode;
		this.Filtering = filtering;

		this.Results = results;
	}
}
