using System.Text.Json.Serialization;

namespace Skylight.Protocol.Client.Variables.Rules.Expressions;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "Operation")]
[JsonDerivedType(typeof(ClientVariableRuleEqualsExpression), "Equals")]
[JsonDerivedType(typeof(ClientVariableRuleNotExpression), "Not")]
public abstract class ClientVariableRuleExpression;
