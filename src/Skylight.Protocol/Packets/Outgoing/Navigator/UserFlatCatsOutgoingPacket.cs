using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Navigator;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class UserFlatCatsOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<FlatCategoryData> FlatCategories { get; init; }

	public UserFlatCatsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UserFlatCatsOutgoingPacket(ICollection<FlatCategoryData> flatCategories)
	{
		this.FlatCategories = flatCategories;
	}
}
