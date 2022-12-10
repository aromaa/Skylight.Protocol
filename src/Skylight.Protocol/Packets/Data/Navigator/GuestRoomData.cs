using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Navigator;

public sealed class GuestRoomData
{
	public required int Id { get; init; }

	public required string Name { get; init; }
	public required string OwnerName { get; init; }

	public required string LayoutId { get; init; }

	public required int UserCount { get; init; }

	public GuestRoomData()
	{
	}

	[SetsRequiredMembers]
	public GuestRoomData(int id, string name, string ownerName, string layoutId, int userCount)
	{
		this.Id = id;

		this.Name = name;
		this.OwnerName = ownerName;

		this.LayoutId = layoutId;

		this.UserCount = userCount;
	}
}
