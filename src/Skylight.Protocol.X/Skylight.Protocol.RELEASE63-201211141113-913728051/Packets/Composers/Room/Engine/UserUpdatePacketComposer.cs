using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Room.Engine;

[PacketComposerId(493u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserUpdatePacketComposer : IOutgoingPacketComposer<UserUpdateOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserUpdateOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Updates.Count);
		foreach (var updates in packet.Updates)
		{
			writer.WriteInt32(updates.RoomUnitId);
			writer.WriteInt32(updates.X);
			writer.WriteInt32(updates.Y);
			writer.WriteFixedUInt16String(updates.Z.ToString(CultureInfo.InvariantCulture));
			writer.WriteInt32(updates.BodyDirection);
			writer.WriteInt32(updates.HeadDirection);
			writer.WriteFixedUInt16String(updates.Data);
		}
	}
}
