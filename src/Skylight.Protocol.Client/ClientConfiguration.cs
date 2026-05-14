using System.Collections;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Skylight.Protocol.Client.Variables;

namespace Skylight.Protocol.Client;

public sealed class ClientConfiguration
{
	public static JsonSerializerOptions JsonOptions { get; } = new()
	{
		Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
		WriteIndented = true,
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
		RespectRequiredConstructorParameters = true,
		TypeInfoResolver = new DefaultJsonTypeInfoResolver()
		{
			Modifiers =
			{
				t =>
				{
					foreach (JsonPropertyInfo propertyInfo in t.Properties)
					{
						if (propertyInfo.PropertyType == typeof(string))
						{
							propertyInfo.ShouldSerialize = (_, v) => v is string { Length: > 0 };
						}
						else if (propertyInfo.PropertyType.IsAssignableTo(typeof(ICollection)))
						{
							propertyInfo.ShouldSerialize = (_, v) => v is ICollection { Count: > 0 };
						}
					}
				}
			}
		}
	};

	public SortedDictionary<string, ClientCapability> Capabilities { get; set; } = [];
	public SortedDictionary<string, ClientVariable> Variables { get; set; } = [];
}
