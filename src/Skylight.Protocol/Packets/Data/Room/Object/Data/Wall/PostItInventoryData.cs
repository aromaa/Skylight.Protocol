using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Object.Data.Wall;

public sealed class PostItInventoryData : IItemData
{
	public required int Count { get; init; }

	public PostItInventoryData()
	{
	}

	[SetsRequiredMembers]
	public PostItInventoryData(int count)
	{
		this.Count = count;
	}
}
