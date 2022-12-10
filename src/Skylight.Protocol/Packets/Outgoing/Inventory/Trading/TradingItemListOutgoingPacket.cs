using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Inventory.Trading;

namespace Skylight.Protocol.Packets.Outgoing.Inventory.Trading;

public sealed class TradingItemListOutgoingPacket : IGameOutgoingPacket
{
	public required int FirstUserId { get; init; }
	public required int FirstUserNumItems { get; init; }
	public required int FirstUserNumCredits { get; init; }
	public required ICollection<TradingItemData> FirstUserItems { get; init; }

	public required int SecondUserId { get; init; }
	public required int SecondUserNumItems { get; init; }
	public required int SecondUserNumCredits { get; init; }
	public required ICollection<TradingItemData> SecondUserItems { get; init; }

	public TradingItemListOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public TradingItemListOutgoingPacket(int firstUserId, int firstUserNumItems, int firstUserNumCredits, ICollection<TradingItemData> firstUserItems, int secondUserId, int secondUserNumItems, int secondUserNumCredits, ICollection<TradingItemData> secondUserItems)
	{
		this.FirstUserId = firstUserId;
		this.FirstUserNumItems = firstUserNumItems;
		this.FirstUserNumCredits = firstUserNumCredits;
		this.FirstUserItems = firstUserItems;

		this.SecondUserId = secondUserId;
		this.SecondUserNumItems = secondUserNumItems;
		this.SecondUserNumCredits = secondUserNumCredits;
		this.SecondUserItems = secondUserItems;
	}
}
