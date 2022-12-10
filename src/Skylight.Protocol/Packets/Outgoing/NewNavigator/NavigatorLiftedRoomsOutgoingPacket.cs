using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Data.NewNavigator;

namespace Skylight.Protocol.Packets.Outgoing.NewNavigator;

[IntroducedIn("WIN63-202111081545-75921380")]
public sealed class NavigatorLiftedRoomsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<LiftedRoomData> LiftedRooms { get; init; }

	public NavigatorLiftedRoomsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NavigatorLiftedRoomsOutgoingPacket(ICollection<LiftedRoomData> liftedRooms)
	{
		this.LiftedRooms = liftedRooms;
	}
}
