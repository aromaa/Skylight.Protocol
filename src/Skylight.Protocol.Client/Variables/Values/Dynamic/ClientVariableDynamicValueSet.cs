using Skylight.Protocol.Client.Variables.Rules;

namespace Skylight.Protocol.Client.Variables.Values.Dynamic;

public sealed class ClientVariableDynamicValueSet
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public OrderedDictionary<string, OrderedDictionary<string, SortedSet<string>>> Mappings { get; set; } = [];
	public OrderedDictionary<string, ClientVariableRuleSet> RuleSets { get; set; } = [];
}
