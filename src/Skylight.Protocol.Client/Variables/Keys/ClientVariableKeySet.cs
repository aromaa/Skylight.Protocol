using Skylight.Protocol.Client.Variables.Rules;

namespace Skylight.Protocol.Client.Variables.Keys;

public sealed class ClientVariableKeySet
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public OrderedDictionary<string, ClientVariableKey> Keys { get; set; } = [];
	public OrderedDictionary<string, ClientVariableRuleSet> RuleSets { get; set; } = [];
}
