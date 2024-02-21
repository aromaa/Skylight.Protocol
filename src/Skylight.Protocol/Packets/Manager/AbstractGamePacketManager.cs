using Net.Communication.Manager;

namespace Skylight.Protocol.Packets.Manager;

public abstract class AbstractGamePacketManager(IServiceProvider serviceProvider) : PacketManager<uint>(serviceProvider)
{
	public abstract bool Modern { get; }
}
