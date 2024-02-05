using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Object.Data;

public sealed class LegacyItemData : IItemData
{
	public required string Data { get; init; }

	public LegacyItemData()
	{
	}

	[SetsRequiredMembers]
	public LegacyItemData(string data)
	{
		this.Data = data;
	}
}
