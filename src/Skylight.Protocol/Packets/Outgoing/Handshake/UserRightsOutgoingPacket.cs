using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Handshake;

public sealed class UserRightsOutgoingPacket : IGameOutgoingPacket
{
	public required int ClubLevel { get; init; }
	public required int SecurityLevel { get; init; }
	public required bool Ambassador { get; init; }

	public UserRightsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserRightsOutgoingPacket(int clubLevel, int securityLevel, bool ambassador)
	{
		this.ClubLevel = clubLevel;
		this.SecurityLevel = securityLevel;
		this.Ambassador = ambassador;
	}
}
