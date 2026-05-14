using System.Text.Json.Serialization;

namespace Skylight.Protocol.Client.Variables;

[JsonConverter(typeof(JsonStringEnumConverter<ClientVariableSelectStrategy>))]
public enum ClientVariableSelectStrategy
{
	All,
	First
}
