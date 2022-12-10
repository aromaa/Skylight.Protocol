using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.WIN63_202111081545_75921380.Packets;

[assembly: GameProtocol("WIN63-202111081545-75921380")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets;

public class GamePacketManager : AbstractGamePacketManager, IGameProtocol
{
	public override bool Modern => true;

	public GamePacketManager(IServiceProvider serviceProvider) : base(serviceProvider)
	{
	}

	public static AbstractGamePacketManager CreatePacketManager(IServiceProvider serviceProvider) => new GamePacketManager(serviceProvider);
}
