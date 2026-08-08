using Skylight.Protocol.Client.Variables.Values.Dynamic;

namespace Skylight.Protocol.Client.Variables.Entries;

public sealed class ClientVariableDynamicEntry : ClientVariableEntry
{
	public OrderedDictionary<string, ClientVariableDynamicValueSet> ValueSets { get; set; } = [];
}
