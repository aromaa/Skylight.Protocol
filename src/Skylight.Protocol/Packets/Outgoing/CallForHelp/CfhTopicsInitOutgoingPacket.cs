using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.CallForHelp;

namespace Skylight.Protocol.Packets.Outgoing.CallForHelp;

public sealed class CfhTopicsInitOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<CallForHelpCategoryData> Categories { get; init; }

	public CfhTopicsInitOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public CfhTopicsInitOutgoingPacket(ICollection<CallForHelpCategoryData> categories)
	{
		this.Categories = categories;
	}
}
