using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Handshake;

public sealed class IsFirstLoginOfDayOutgoingPacket : IGameOutgoingPacket
{
	public required bool IsFirstLoginOfDay { get; init; }

	public IsFirstLoginOfDayOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public IsFirstLoginOfDayOutgoingPacket(bool isFirstLoginOfDay)
	{
		this.IsFirstLoginOfDay = isFirstLoginOfDay;
	}
}
