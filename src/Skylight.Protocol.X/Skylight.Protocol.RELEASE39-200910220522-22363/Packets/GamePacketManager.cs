using Net.Communication.Attributes;
using Net.Communication.Manager;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Manager;
using Skylight.Protocol.RELEASE39_200910220522_22363.Packets;

[assembly: GameProtocol("RELEASE39-200910220522-22363")]
[assembly: GameProtocolManager<GamePacketManager>]

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets;

public sealed partial class GamePacketManager(IServiceProvider serviceProvider, PacketManagerData<uint> baseData)
	: AbstractGamePacketManager(serviceProvider, baseData, GamePacketManager.GetProtocolData()), IGameProtocol
{
	public override bool Modern => false;

	public static AbstractGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData<uint> packetManagerData) => new GamePacketManager(serviceProvider, packetManagerData);

	[PacketManagerGenerator(typeof(GamePacketManager))]
	private static partial PacketManagerData<uint> GetProtocolData();
}
