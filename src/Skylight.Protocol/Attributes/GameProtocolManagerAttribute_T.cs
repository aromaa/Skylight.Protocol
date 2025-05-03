using Net.Communication.Manager;
using Skylight.Protocol.Packets.Manager;

namespace Skylight.Protocol.Attributes;

public sealed class GameProtocolManagerAttribute<T> : GameProtocolManagerAttribute
	where T : IGameProtocol
{
	public override IGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData packetManagerData) => T.CreatePacketManager(serviceProvider, packetManagerData);
}
