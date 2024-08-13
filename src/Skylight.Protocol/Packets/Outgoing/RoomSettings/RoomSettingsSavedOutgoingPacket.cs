using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.RoomSettings;

public sealed class RoomSettingsSavedOutgoingPacket : IGameOutgoingPacket
{
	public required int RoomId { get; init; }

	public RoomSettingsSavedOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RoomSettingsSavedOutgoingPacket(int roomId)
	{
		this.RoomId = roomId;
	}
}
