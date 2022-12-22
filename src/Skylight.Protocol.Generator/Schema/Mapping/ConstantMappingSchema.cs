namespace Skylight.Protocol.Generator.Schema.Mapping;

public sealed class ConstantMappingSchema : AbstractMappingSchema
{
	public required string Type { get; set; }
	public required string Value { get; set; }
}
