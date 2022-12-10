using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Outgoing.NewNavigator;

[IntroducedIn("WIN63-202111081545-75921380")]
public sealed class NavigatorCollapsedCategoriesOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<string> CollapsedCategories { get; init; }

	public NavigatorCollapsedCategoriesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NavigatorCollapsedCategoriesOutgoingPacket(ICollection<string> collapsedCategories)
	{
		this.CollapsedCategories = collapsedCategories;
	}
}
