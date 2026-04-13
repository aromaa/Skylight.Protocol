using System.Collections.Frozen;

namespace Skylight.Protocol.Packets.Manager;

public interface IGamePacketManager
{
	public bool Modern { get; }
	public bool Fuse { get; }

	public FrozenSet<string> Capabilities { get; }
}
