using Net.Communication.Attributes;
using Net.Communication.Manager;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.WIN63_202111081545_75921380.Packets;

[assembly: GameProtocol("WIN63-202111081545-75921380")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets;

public sealed partial class GamePacketManager(IServiceProvider serviceProvider, PacketManagerData baseData)
	: AbstractGamePacketManager<uint>(serviceProvider, baseData, GamePacketManager.GetProtocolData()), IGameProtocol
{
	public override bool Modern => true;
	public override bool Fuse => false;

	public static IGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData packetManagerData) => new GamePacketManager(serviceProvider, packetManagerData);

	[PacketManagerGenerator(typeof(GamePacketManager))]
	private static partial PacketManagerData<uint> GetProtocolData();
}
