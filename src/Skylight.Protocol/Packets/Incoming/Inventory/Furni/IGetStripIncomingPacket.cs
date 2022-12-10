using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Incoming.Inventory.Furni;

[RemovedOn("RELEASE63-35255-34886-201108111108")]
public interface IGetStripIncomingPacket : IGameIncomingPacket
{
	public int Action { get; }
}
