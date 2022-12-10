using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Catalog;

namespace Skylight.Protocol.Packets.Outgoing.Catalog;

public sealed class PurchaseNotAllowedOutgoingPacket : IGameOutgoingPacket
{
	public required PurchaseNotAllowedReason Reason { get; init; }

	public PurchaseNotAllowedOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PurchaseNotAllowedOutgoingPacket(PurchaseNotAllowedReason reason)
	{
		this.Reason = reason;
	}
}
