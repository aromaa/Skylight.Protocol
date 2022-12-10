using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Navigator;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class GuestRoomSearchResultOutgoingPacket : IGameOutgoingPacket
{
	public required int SearchType { get; init; }
	public required string Text { get; init; }

	public required ICollection<GuestRoomData> Rooms { get; init; }

	public GuestRoomSearchResultOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public GuestRoomSearchResultOutgoingPacket(int searchType, string text, ICollection<GuestRoomData> rooms)
	{
		this.SearchType = searchType;
		this.Text = text;

		this.Rooms = rooms;
	}
}
