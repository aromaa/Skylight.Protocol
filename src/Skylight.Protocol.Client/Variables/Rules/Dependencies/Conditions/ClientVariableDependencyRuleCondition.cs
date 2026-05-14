using System.Text.Json.Serialization;

namespace Skylight.Protocol.Client.Variables.Rules.Dependencies.Conditions;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "Condition")]
[JsonDerivedType(typeof(ClientVariableDependencyRuleActiveValueSetCondition), "ActiveValueSet")]
[JsonDerivedType(typeof(ClientVariableDependencyRuleValueEqualsCondition), "ValueEquals")]
public abstract class ClientVariableDependencyRuleCondition;
