using Skylight.Protocol.Client.Variables.Values.Static;

namespace Skylight.Protocol.Client.Variables.Entries;

public sealed class ClientVariableStaticEntry : ClientVariableEntry
{
	public OrderedDictionary<string, ClientVariableStaticValueSet> ValueSets { get; set; } = [];
}
