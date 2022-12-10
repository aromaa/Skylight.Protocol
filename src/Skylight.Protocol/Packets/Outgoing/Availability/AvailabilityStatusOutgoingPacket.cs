using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Availability;

public sealed class AvailabilityStatusOutgoingPacket : IGameOutgoingPacket
{
	public required bool IsOpen { get; init; }
	public required bool IsClosing { get; init; }
	public required bool IsAuthentic { get; init; }

	public AvailabilityStatusOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public AvailabilityStatusOutgoingPacket(bool isOpen, bool isClosing, bool isAuthentic)
	{
		this.IsOpen = isOpen;
		this.IsClosing = isClosing;
		this.IsAuthentic = isAuthentic;
	}
}
