using System.Text.Json.Serialization;

namespace Skylight.Protocol.Generator.Schema.Mapping;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "Mapping")]
[JsonDerivedType(typeof(FieldMappingSchema), "Field")]
[JsonDerivedType(typeof(ConstantMappingSchema), "Constant")]
[JsonDerivedType(typeof(ConditionalMappingSchema), "Conditional")]
[JsonDerivedType(typeof(CombineMappingSchema), "Combine")]
internal abstract class AbstractMappingSchema
{
}
