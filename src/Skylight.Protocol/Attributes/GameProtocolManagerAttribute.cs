using Net.Communication.Manager;
using Skylight.Protocol.Packets.Manager;

namespace Skylight.Protocol.Attributes;

[AttributeUsage(AttributeTargets.Assembly)]
public abstract class GameProtocolManagerAttribute : Attribute
{
	private protected GameProtocolManagerAttribute()
	{
	}

	public abstract IGamePacketManager CreatePacketManager(IServiceProvider serviceProvider, PacketManagerData packetManagerData);
}
