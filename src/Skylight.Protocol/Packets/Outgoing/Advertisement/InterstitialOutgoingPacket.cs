using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Advertisement;

public sealed class InterstitialOutgoingPacket : IGameOutgoingPacket
{
	public required bool CanShowInterstitial { get; init; }

	public InterstitialOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public InterstitialOutgoingPacket(bool canShowInterstitial)
	{
		this.CanShowInterstitial = canShowInterstitial;
	}
}
