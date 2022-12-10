using Skylight.Protocol.Packets.Manager;

namespace Skylight.Protocol;

public interface IGameProtocol
{
	public static abstract AbstractGamePacketManager CreatePacketManager(IServiceProvider serviceProvider);
}
