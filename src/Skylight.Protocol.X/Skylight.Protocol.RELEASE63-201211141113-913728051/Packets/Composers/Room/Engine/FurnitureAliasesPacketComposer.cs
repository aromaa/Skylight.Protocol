using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(2027u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FurnitureAliasesPacketComposer : IOutgoingPacketComposer<FurnitureAliasesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FurnitureAliasesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Aliases.Count);
		foreach (var aliases in packet.Aliases)
		{
			writer.WriteFixedUInt16String(aliases.Name);
			writer.WriteFixedUInt16String(aliases.Alias);
		}
	}
}
