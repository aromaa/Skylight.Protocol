using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Data.NewNavigator;

namespace Skylight.Protocol.Packets.Outgoing.NewNavigator;

[IntroducedIn("WIN63-202111081545-75921380")]
public sealed class NavigatorMetaDataOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<TopLevelContext> TopLevelContexts { get; init; }

	public NavigatorMetaDataOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NavigatorMetaDataOutgoingPacket(ICollection<TopLevelContext> topLevelContexts)
	{
		this.TopLevelContexts = topLevelContexts;
	}
}
