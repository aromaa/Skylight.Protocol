using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.FriendList;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.FriendList;

[PacketComposerId(3679u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class MessengerInitPacketComposer : IOutgoingPacketComposer<MessengerInitOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in MessengerInitOutgoingPacket packet)
	{
		writer.WriteInt32(packet.UserFriendLimit);
		writer.WriteInt32(packet.NormalFriendLimit);
		writer.WriteInt32(packet.ExtendedFriendLimit);
		writer.WriteInt32(packet.Categories.Count);
		foreach (var categories in packet.Categories)
		{
			writer.WriteInt32(categories.Id);
			writer.WriteFixedUInt16String(categories.Name);
		}
	}
}
