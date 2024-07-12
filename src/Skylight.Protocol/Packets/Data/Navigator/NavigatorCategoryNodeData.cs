using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Navigator;

public sealed class NavigatorCategoryNodeData : NavigatorNodeData
{
	public NavigatorCategoryNodeData()
	{
	}

	[SetsRequiredMembers]
	public NavigatorCategoryNodeData(int id, int parentId, string caption, int userCount, int usersMax)
		: base(id, parentId, caption, userCount, usersMax)
	{
	}
}
