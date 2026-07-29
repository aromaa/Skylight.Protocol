using Skylight.Protocol.Client.Variables.Values;

namespace Skylight.Protocol.Client.Variables.Entries;

public sealed class ClientVariableStaticEntry : ClientVariableEntry
{
	public OrderedDictionary<string, ClientVariableValueSet> ValueSets { get; set; } = [];
}
