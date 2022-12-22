namespace Skylight.Protocol.Generator.Schema.Mapping;

public sealed class FieldMappingSchema : AbstractMappingSchema
{
	public required string Type { get; set; }
	public required string Name { get; set; }
}
