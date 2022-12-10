using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.FriendList;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.FriendList;

[PacketComposerId(398u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MessengerInitPacketComposer : IOutgoingPacketComposer<MessengerInitOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in MessengerInitOutgoingPacket packet)
	{
		writer.WriteInt32(packet.UserFriendLimit);
		writer.WriteInt32(0);
		writer.WriteInt32(packet.NormalFriendLimit);
		writer.WriteInt32(packet.ExtendedFriendLimit);
		writer.WriteInt32(packet.Categories.Count);
		foreach (var categories in packet.Categories)
		{
			writer.WriteInt32(categories.Id);
			writer.WriteFixedUInt16String(categories.Name);
		}
		writer.WriteInt32(0);
	}
}
