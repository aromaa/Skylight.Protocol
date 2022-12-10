using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Room.Engine;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Room.Engine;

[PacketComposerId(34u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class UserUpdatePacketComposer : IOutgoingPacketComposer<UserUpdateOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in UserUpdateOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.Updates.Count);
		foreach (var updates in packet.Updates)
		{
			writer.WriteVL64Int32(updates.RoomUnitId);
			writer.WriteVL64Int32(updates.X);
			writer.WriteVL64Int32(updates.Y);
			writer.WriteDelimiter2BrokenString(updates.Z.ToString(CultureInfo.InvariantCulture));
			writer.WriteVL64Int32(updates.BodyDirection);
			writer.WriteVL64Int32(updates.HeadDirection);
			writer.WriteDelimiter2BrokenString(updates.Data);
		}
	}
}
