namespace Skylight.Protocol.Generator.Schema.Mapping;

public sealed class CombineMappingSchema : AbstractMappingSchema
{
	public required string Type { get; set; }

	public required List<AbstractMappingSchema> Fields { get; set; }
}
