using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.CallForHelp;

public sealed class CallForHelpTopicData
{
	public required int Id { get; init; }

	public required string Name { get; init; }
	public required string Consequence { get; init; }

	public CallForHelpTopicData()
	{
	}

	[SetsRequiredMembers]
	public CallForHelpTopicData(int id, string name, string consequence)
	{
		this.Id = id;

		this.Name = name;
		this.Consequence = consequence;
	}
}
