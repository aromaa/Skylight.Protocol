using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.CallForHelp;

public sealed class CallForHelpCategoryData
{
	public required string Name { get; init; }

	public required ICollection<CallForHelpTopicData> Topics { get; init; }

	public CallForHelpCategoryData()
	{
	}

	[SetsRequiredMembers]
	public CallForHelpCategoryData(string name, ICollection<CallForHelpTopicData> topics)
	{
		this.Name = name;
		this.Topics = topics;
	}
}
