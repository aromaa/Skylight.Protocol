using Net.Buffers;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.Packets.Outgoing;

//TODO: A hack for Fuse, only few packets need it but abstracting it out is not worth it.
public interface IGameOutgoingPacketComposer<T> : IOutgoingPacketComposer<T>
{
	public void AppendHeader(ref PacketWriter writer, in T packet);
}
