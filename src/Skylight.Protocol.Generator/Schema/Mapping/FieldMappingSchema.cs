namespace Skylight.Protocol.Generator.Schema.Mapping;

internal sealed class FieldMappingSchema : AbstractMappingSchema
{
	public required string Type { get; init; }
	public required string Name { get; init; }
}
