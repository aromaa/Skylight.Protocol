using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Navigator;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class UserEventCatsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<EventCategoryData> EventCategories { get; init; }

	public UserEventCatsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserEventCatsOutgoingPacket(ICollection<EventCategoryData> eventCategories)
	{
		this.EventCategories = eventCategories;
	}
}
