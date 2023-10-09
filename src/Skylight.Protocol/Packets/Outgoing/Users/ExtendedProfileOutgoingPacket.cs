using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Users;

namespace Skylight.Protocol.Packets.Outgoing.Users;

public sealed class ExtendedProfileOutgoingPacket : IGameOutgoingPacket
{
	public required ExtendedProfileData Profile { get; init; }

	public ExtendedProfileOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ExtendedProfileOutgoingPacket(ExtendedProfileData profile)
	{
		this.Profile = profile;
	}
}
