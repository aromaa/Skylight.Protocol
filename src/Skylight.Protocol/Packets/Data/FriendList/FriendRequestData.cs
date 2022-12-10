using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.FriendList;

public sealed class FriendRequestData
{
	public required int RequesterId { get; init; }
	public required string RequesterName { get; init; }
	public required string RequesterFigure { get; init; }

	public FriendRequestData()
	{
	}

	[SetsRequiredMembers]
	public FriendRequestData(int requesterId, string requesterName, string requesterFigure)
	{
		this.RequesterId = requesterId;
		this.RequesterName = requesterName;
		this.RequesterFigure = requesterFigure;
	}
}
