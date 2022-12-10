using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.FriendList;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.FriendList;

[PacketComposerId(1767u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class FriendRequestsPacketComposer : IOutgoingPacketComposer<FriendRequestsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in FriendRequestsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.TotalCount);
		writer.WriteInt32(packet.Requests.Count);
		foreach (var requests in packet.Requests)
		{
			writer.WriteInt32(requests.RequesterId);
			writer.WriteFixedUInt16String(requests.RequesterName);
			writer.WriteFixedUInt16String(requests.RequesterFigure);
		}
	}
}
