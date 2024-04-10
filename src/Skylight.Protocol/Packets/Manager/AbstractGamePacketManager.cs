using Net.Communication.Manager;

namespace Skylight.Protocol.Packets.Manager;

public abstract class AbstractGamePacketManager(IServiceProvider serviceProvider, PacketManagerData<uint> baseData, PacketManagerData<uint> protocolData)
	: PacketManager<uint>(serviceProvider, AbstractGamePacketManager.Combine(baseData, protocolData))
{
	public abstract bool Modern { get; }

	private static PacketManagerData<uint> Combine(PacketManagerData<uint> baseData, PacketManagerData<uint> protocolData)
	{
		return new PacketManagerData<uint>(protocolData.Parsers, baseData.Handlers, protocolData.Composers);
	}
}
