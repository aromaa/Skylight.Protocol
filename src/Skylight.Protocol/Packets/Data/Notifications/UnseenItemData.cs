using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Notifications;

public sealed class UnseenItemData
{
	public required int Category { get; init; }

	public required ICollection<int> Ids { get; init; }

	public UnseenItemData()
	{
	}

	[SetsRequiredMembers]
	public UnseenItemData(int category, ICollection<int> ids)
	{
		this.Category = category;

		this.Ids = ids;
	}
}
