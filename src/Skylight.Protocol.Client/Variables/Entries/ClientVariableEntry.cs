using System.Text.Json.Serialization;
using Skylight.Protocol.Client.Variables.Rules;

namespace Skylight.Protocol.Client.Variables.Entries;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "Type")]
[JsonDerivedType(typeof(ClientVariableDynamicEntry), "Dynamic")]
[JsonDerivedType(typeof(ClientVariableGroupEntry), "Group")]
[JsonDerivedType(typeof(ClientVariableStaticEntry), "Static")]
public abstract class ClientVariableEntry
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public OrderedDictionary<string, ClientVariableRuleSet> RuleSets { get; set; } = [];
}
