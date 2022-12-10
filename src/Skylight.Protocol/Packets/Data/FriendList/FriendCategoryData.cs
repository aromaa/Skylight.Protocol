using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.FriendList;

public sealed class FriendCategoryData
{
	public required int Id { get; init; }

	public required string Name { get; init; }

	public FriendCategoryData()
	{
	}

	[SetsRequiredMembers]
	public FriendCategoryData(int id, string name)
	{
		this.Id = id;

		this.Name = name;
	}
}
