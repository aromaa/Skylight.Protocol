using Net.Communication.Attributes;
using Net.Communication.Manager;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.RELEASE6.Packets;

[assembly: GameProtocol("RELEASE6")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.RELEASE6.Packets;

public sealed partial class GamePacketManager(IServiceProvider serviceProvider, PacketManagerData baseData)
	: AbstractGamePacketManager<uint>(serviceProvider, baseData, GamePacketManager.GetProtocolData()), IGameProtocol
{
	public override bool Modern => false;
	public override bool Fuse => false;

	public static IGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData packetManagerData) => new GamePacketManager(serviceProvider, packetManagerData);

	[PacketManagerGenerator(typeof(GamePacketManager))]
	private static partial PacketManagerData<uint> GetProtocolData();
}
