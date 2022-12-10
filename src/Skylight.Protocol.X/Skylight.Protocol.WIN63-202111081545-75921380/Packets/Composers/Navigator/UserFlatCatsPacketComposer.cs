using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Navigator;

[PacketComposerId(204u)]
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
			writer.WriteBool(flatCategories.Automatic);
			writer.WriteFixedUInt16String(flatCategories.AutomaticCategory);
			writer.WriteFixedUInt16String(flatCategories.GlobalCategory);
			writer.WriteBool(flatCategories.StaffOnly);
		}
	}
}
