using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Navigator;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class PrivateUnitsOutgoingPacket : IGameOutgoingPacket
{
	public required IReadOnlyList<PrivateUnitData> Units { get; init; }

	public PrivateUnitsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PrivateUnitsOutgoingPacket(IReadOnlyList<PrivateUnitData> units)
	{
		this.Units = units;
	}
}
