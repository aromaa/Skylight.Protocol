using System.Text.Json.Serialization;
using Skylight.Protocol.Client.Variables.Rules.Dependencies;
using Skylight.Protocol.Client.Variables.Rules.Expressions;

namespace Skylight.Protocol.Client.Variables.Rules;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "Subject")]
[JsonDerivedType(typeof(ClientVariableCapabilityRule), "Capability")]
[JsonDerivedType(typeof(ClientVariableDependencyRule), "Dependency")]
[JsonDerivedType(typeof(ClientVariableEncodingRule), "Encoding")]
[JsonDerivedType(typeof(ClientVariableEnvironmentRule), "Environment")]
[JsonDerivedType(typeof(ClientVariableLocaleRule), "Locale")]
[JsonDerivedType(typeof(ClientVariableRevisionRule), "Revision")]
public abstract class ClientVariableRule
{
	public List<ClientVariableRuleExpression> Expressions { get; set; } = [];
}
