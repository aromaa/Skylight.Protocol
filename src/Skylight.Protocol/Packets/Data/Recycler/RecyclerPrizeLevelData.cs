using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Recycler;

public sealed class RecyclerPrizeLevelData
{
	public required int Level { get; init; }
	public required int Odds { get; init; }

	public required ICollection<RecyclerPrizeData> Prizes { get; init; }

	public RecyclerPrizeLevelData()
	{
	}

	[SetsRequiredMembers]
	public RecyclerPrizeLevelData(int level, int odds, ICollection<RecyclerPrizeData> prizes)
	{
		this.Level = level;
		this.Odds = odds;

		this.Prizes = prizes;
	}
}
