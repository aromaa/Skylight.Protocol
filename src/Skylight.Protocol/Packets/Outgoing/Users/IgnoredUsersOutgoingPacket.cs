using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Users;

public sealed class IgnoredUsersOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<string> IgnoredUsers { get; init; }

	public IgnoredUsersOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public IgnoredUsersOutgoingPacket(ICollection<string> ignoredUsers)
	{
		this.IgnoredUsers = ignoredUsers;
	}
}
