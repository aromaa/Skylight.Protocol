using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Engine;

[PacketComposerId(297u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FurnitureAliasesPacketComposer : IOutgoingPacketComposer<FurnitureAliasesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FurnitureAliasesOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Aliases.Count);
		foreach (var aliases in packet.Aliases)
		{
			writer.WriteDelimiter2BrokenString(aliases.Name);
			writer.WriteDelimiter2BrokenString(aliases.Alias);
		}
	}
}
