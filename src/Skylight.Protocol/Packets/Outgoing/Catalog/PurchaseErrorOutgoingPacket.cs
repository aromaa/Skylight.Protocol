using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Catalog;

namespace Skylight.Protocol.Packets.Outgoing.Catalog;

public sealed class PurchaseErrorOutgoingPacket : IGameOutgoingPacket
{
	public required PurchaseErrorReason Reason { get; init; }

	public PurchaseErrorOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public PurchaseErrorOutgoingPacket(PurchaseErrorReason reason)
	{
		this.Reason = reason;
	}
}
