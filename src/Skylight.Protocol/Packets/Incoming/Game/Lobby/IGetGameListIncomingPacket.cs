using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Incoming.Game.Lobby;

[IntroducedIn("RELEASE63-201211141113-913728051")]
[RemovedOn("WIN63-202111081545-75921380")]
public interface IGetGameListIncomingPacket : IGameIncomingPacket
{
}
