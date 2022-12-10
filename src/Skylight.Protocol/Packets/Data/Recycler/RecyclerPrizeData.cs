using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Recycler;

public sealed class RecyclerPrizeData
{
	public required string Name { get; init; }

	public required ICollection<RecyclerItemData> Items { get; init; }

	public RecyclerPrizeData()
	{
	}

	[SetsRequiredMembers]
	public RecyclerPrizeData(string name, ICollection<RecyclerItemData> items)
	{
		this.Name = name;

		this.Items = items;
	}
}
