using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Room.Engine;

public sealed class FurnitureAliasesOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<(string Name, string Alias)> Aliases { get; init; }

	public FurnitureAliasesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public FurnitureAliasesOutgoingPacket(ICollection<(string Name, string Alias)> aliases)
	{
		this.Aliases = aliases;
	}
}
