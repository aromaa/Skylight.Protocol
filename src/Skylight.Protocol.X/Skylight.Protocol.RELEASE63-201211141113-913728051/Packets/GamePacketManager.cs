using Net.Communication.Attributes;
using Net.Communication.Manager;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.RELEASE63_201211141113_913728051.Packets;

[assembly: GameProtocol("RELEASE63-201211141113-913728051")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets;

public sealed partial class GamePacketManager(IServiceProvider serviceProvider, PacketManagerData baseData)
	: AbstractGamePacketManager<uint>(serviceProvider, baseData, GamePacketManager.GetProtocolData()), IGameProtocol
{
	public override bool Modern => true;
	public override bool Fuse => false;

	public static IGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData packetManagerData) => new GamePacketManager(serviceProvider, packetManagerData);

	[PacketManagerGenerator(typeof(GamePacketManager))]
	private static partial PacketManagerData<uint> GetProtocolData();
}
