using Net.Communication.Attributes;
using Net.Communication.Manager;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.RELEASE9.Packets;

[assembly: GameProtocol("RELEASE9")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.RELEASE9.Packets;

public sealed partial class GamePacketManager(IServiceProvider serviceProvider, PacketManagerData<uint> baseData)
	: AbstractGamePacketManager(serviceProvider, baseData, GamePacketManager.GetProtocolData()), IGameProtocol
{
	public override bool Modern => false;

	public static AbstractGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData<uint> packetManagerData) => new GamePacketManager(serviceProvider, packetManagerData);

	[PacketManagerGenerator(typeof(GamePacketManager))]
	private static partial PacketManagerData<uint> GetProtocolData();
}
