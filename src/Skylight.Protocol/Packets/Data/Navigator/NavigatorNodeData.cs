using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Navigator;

public abstract class NavigatorNodeData
{
	public required int Id { get; init; }
	public required int ParentId { get; init; }

	public required string Caption { get; init; }

	public required int UserCount { get; init; }
	public required int UsersMax { get; init; }

	protected NavigatorNodeData()
	{
	}

	[SetsRequiredMembers]
	protected NavigatorNodeData(int id, int parentId, string caption, int userCount, int usersMax)
	{
		this.Id = id;
		this.ParentId = parentId;
		this.Caption = caption;
		this.UserCount = userCount;
		this.UsersMax = usersMax;
	}
}
