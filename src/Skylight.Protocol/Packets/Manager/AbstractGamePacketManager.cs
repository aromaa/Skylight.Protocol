using Net.Communication.Manager;

namespace Skylight.Protocol.Packets.Manager;

public abstract class AbstractGamePacketManager : PacketManager<uint>
{
	public abstract bool Modern { get; }

	protected AbstractGamePacketManager(IServiceProvider serviceProvider)
		: base(serviceProvider)
	{
	}
}
