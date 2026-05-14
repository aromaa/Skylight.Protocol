using Skylight.Protocol.Client.Variables.Entries;
using Skylight.Protocol.Client.Variables.Rules;

namespace Skylight.Protocol.Client.Variables;

public sealed class ClientVariable
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public bool Dynamic { get; set; }

	public ClientVariableSelectStrategy EntrySelectStrategy { get; set; }

	public OrderedDictionary<string, ClientVariableField> Fields { get; set; } = [];
	public OrderedDictionary<string, ClientVariableEntry> Entries { get; set; } = [];
	public OrderedDictionary<string, ClientVariableRuleSet> RuleSets { get; set; } = [];
}
