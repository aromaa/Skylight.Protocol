namespace Skylight.Protocol.Generator.Schema.Mapping;

internal sealed class CombineMappingSchema : AbstractMappingSchema
{
	public required string Type { get; init; }

	public required List<AbstractMappingSchema> Fields { get; init; }
}
