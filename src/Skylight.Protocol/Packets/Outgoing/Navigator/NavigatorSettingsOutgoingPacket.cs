using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class NavigatorSettingsOutgoingPacket : IGameOutgoingPacket
{
	public required int HomeRoomId { get; init; }
	public required int RoomIdToEnter { get; init; }

	public NavigatorSettingsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NavigatorSettingsOutgoingPacket(int homeRoomId, int roomIdToEnter)
	{
		this.HomeRoomId = homeRoomId;
		this.RoomIdToEnter = roomIdToEnter;
	}
}
