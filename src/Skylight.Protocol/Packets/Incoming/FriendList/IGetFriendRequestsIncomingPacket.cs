using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Incoming.FriendList;

[Aliases("GetBuddyRequests", "RELEASE63-35255-34886-201108111108")]
public interface IGetFriendRequestsIncomingPacket : IGameIncomingPacket
{
}
