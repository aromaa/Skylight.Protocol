using System.Collections.Frozen;

namespace Skylight.Protocol.Packets.Manager;

public interface IGamePacketManager
{
	public FrozenSet<string> Capabilities { get; }
}
