using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.RELEASE39_200910220522_22363.Packets;

[assembly: GameProtocol("RELEASE39-200910220522-22363")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets;

public class GamePacketManager : AbstractGamePacketManager, IGameProtocol
{
	public override bool Modern => false;

	public GamePacketManager(IServiceProvider serviceProvider) : base(serviceProvider)
	{
	}

	public static AbstractGamePacketManager CreatePacketManager(IServiceProvider serviceProvider) => new GamePacketManager(serviceProvider);
}
