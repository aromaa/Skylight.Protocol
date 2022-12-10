using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Data.Perk;

namespace Skylight.Protocol.Packets.Outgoing.Perk;

[IntroducedIn("RELEASE63-201211141113-913728051")]
public sealed class PerkAllowancesOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<PerkAllowanceData> Perks { get; init; }

	public PerkAllowancesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PerkAllowancesOutgoingPacket(ICollection<PerkAllowanceData> perks)
	{
		this.Perks = perks;
	}
}
