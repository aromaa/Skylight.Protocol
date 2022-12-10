using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Data.FriendList;

namespace Skylight.Protocol.Packets.Outgoing.FriendList;

[Aliases("BuddyRequests", "RELEASE63-35255-34886-201108111108")]
public sealed class FriendRequestsOutgoingPacket : IGameOutgoingPacket
{
	public required int TotalCount { get; init; }

	public required ICollection<FriendRequestData> Requests { get; init; }

	public FriendRequestsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public FriendRequestsOutgoingPacket(int totalCount, ICollection<FriendRequestData> requests)
	{
		this.TotalCount = totalCount;

		this.Requests = requests;
	}
}
