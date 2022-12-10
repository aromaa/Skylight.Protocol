using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Trading;

public sealed class TradingOpenOutgoingPacket : IGameOutgoingPacket
{
	public required int FirstUserId { get; init; }
	public required bool FirstUserCanTrade { get; init; }

	public required int SecondUserId { get; init; }
	public required bool SecondUserCanTrade { get; init; }

	public TradingOpenOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public TradingOpenOutgoingPacket(int firstUserId, bool firstUserCanTrade, int secondUserId, bool secondUserCanTrade)
	{
		this.FirstUserId = firstUserId;
		this.FirstUserCanTrade = firstUserCanTrade;

		this.SecondUserId = secondUserId;
		this.SecondUserCanTrade = secondUserCanTrade;
	}
}
