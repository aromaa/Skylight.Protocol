using Skylight.Protocol.Client.Variables.Values;

namespace Skylight.Protocol.Client.Variables.Entries;

public sealed class ClientVariableStaticEntryValue
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public OrderedDictionary<string, ClientVariableValueSet> ValueSets { get; set; } = [];
}
