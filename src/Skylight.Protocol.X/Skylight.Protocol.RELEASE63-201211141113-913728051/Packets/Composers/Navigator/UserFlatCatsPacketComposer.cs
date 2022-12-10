using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Navigator;

[PacketComposerId(1154u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserFlatCatsPacketComposer : IOutgoingPacketComposer<UserFlatCatsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserFlatCatsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.FlatCategories.Count);
		foreach (var flatCategories in packet.FlatCategories)
		{
			writer.WriteInt32(flatCategories.Id);
			writer.WriteFixedUInt16String(flatCategories.Name);
			writer.WriteBool(flatCategories.Visible);
		}
	}
}
