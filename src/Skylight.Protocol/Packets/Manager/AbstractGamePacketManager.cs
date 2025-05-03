using Net.Communication.Manager;

namespace Skylight.Protocol.Packets.Manager;

public abstract class AbstractGamePacketManager<T>(IServiceProvider serviceProvider, PacketManagerData baseData, PacketManagerData<T> protocolData)
	: PacketManager<T>(serviceProvider, AbstractGamePacketManager<T>.Combine(baseData, protocolData)), IGamePacketManager
	where T : notnull
{
	public abstract bool Modern { get; }
	public abstract bool Fuse { get; }

	private static PacketManagerData<T> Combine(PacketManagerData baseData, PacketManagerData<T> protocolData)
	{
		return new PacketManagerData<T>(protocolData.Parsers, baseData.Handlers, protocolData.Composers);
	}
}
