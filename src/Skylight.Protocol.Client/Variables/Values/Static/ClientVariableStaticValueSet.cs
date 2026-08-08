using Skylight.Protocol.Client.Variables.Rules;

namespace Skylight.Protocol.Client.Variables.Values.Static;

public sealed class ClientVariableStaticValueSet
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public SortedDictionary<string, ClientVariableStaticValueSetField> Fields { get; set; } = [];
	public OrderedDictionary<string, ClientVariableRuleSet> RuleSets { get; set; } = [];
}
