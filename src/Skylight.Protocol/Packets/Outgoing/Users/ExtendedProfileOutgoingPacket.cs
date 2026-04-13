using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Users;

namespace Skylight.Protocol.Packets.Outgoing.Users;

public sealed class ExtendedProfileOutgoingPacket<TFigureData> : IGameOutgoingPacket
{
	public required ExtendedProfileData<TFigureData> Profile { get; init; }

	public ExtendedProfileOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ExtendedProfileOutgoingPacket(ExtendedProfileData<TFigureData> profile)
	{
		this.Profile = profile;
	}
}
