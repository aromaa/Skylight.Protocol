using Skylight.Protocol.Client.Variables.Rules;

namespace Skylight.Protocol.Client.Variables.Values;

public sealed class ClientVariableValueSet
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public OrderedDictionary<string, ClientVariableValue> Values { get; set; } = [];
	public OrderedDictionary<string, ClientVariableRuleSet> RuleSets { get; set; } = [];
}
