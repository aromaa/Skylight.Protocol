using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.RELEASE63_201211141113_913728051.Packets;

[assembly: GameProtocol("RELEASE63-201211141113-913728051")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets;

public class GamePacketManager : AbstractGamePacketManager, IGameProtocol
{
	public override bool Modern => true;

	public GamePacketManager(IServiceProvider serviceProvider) : base(serviceProvider)
	{
	}

	public static AbstractGamePacketManager CreatePacketManager(IServiceProvider serviceProvider) => new GamePacketManager(serviceProvider);
}
