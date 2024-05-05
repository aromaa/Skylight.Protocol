using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Registration;

public sealed class AvailableSetsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<int> Sets { get; init; }

	public AvailableSetsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public AvailableSetsOutgoingPacket(ICollection<int> sets)
	{
		this.Sets = sets;
	}
}
