using Net.Communication.Manager;
using Skylight.Protocol.Packets.Manager;

namespace Skylight.Protocol;

public interface IGameProtocol
{
	public static abstract AbstractGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData<uint> packetManagerData);
}
