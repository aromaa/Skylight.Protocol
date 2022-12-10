using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.FriendList;

namespace Skylight.Protocol.Packets.Outgoing.FriendList;

public sealed class MessengerInitOutgoingPacket : IGameOutgoingPacket
{
	public required int UserFriendLimit { get; init; }
	public required int NormalFriendLimit { get; init; }
	public required int ExtendedFriendLimit { get; init; }
	public required int SuperExtendedFriendLimit { get; init; }

	public required ICollection<FriendCategoryData> Categories { get; init; }

	public MessengerInitOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public MessengerInitOutgoingPacket(int userFriendLimit, int normalFriendLimit, int extendedFriendLimit, int superExtendedFriendLimit, ICollection<FriendCategoryData> categories)
	{
		this.UserFriendLimit = userFriendLimit;
		this.NormalFriendLimit = normalFriendLimit;
		this.ExtendedFriendLimit = extendedFriendLimit;
		this.SuperExtendedFriendLimit = superExtendedFriendLimit;

		this.Categories = categories;
	}
}
