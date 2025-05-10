using Net.Communication.Attributes;
using Net.Communication.Manager;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.RELEASE1.Packets;

[assembly: GameProtocol("RELEASE1")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.RELEASE1.Packets;

public sealed partial class GamePacketManager(IServiceProvider serviceProvider, PacketManagerData baseData)
	: AbstractGamePacketManager<string>(serviceProvider, baseData, GamePacketManager.GetProtocolData()), IGameProtocol
{
	public override bool Modern => false;
	public override bool Fuse => true;

	public static IGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData packetManagerData) => new GamePacketManager(serviceProvider, packetManagerData);

	[PacketManagerGenerator(typeof(GamePacketManager))]
	private static partial PacketManagerData<string> GetProtocolData();
}
