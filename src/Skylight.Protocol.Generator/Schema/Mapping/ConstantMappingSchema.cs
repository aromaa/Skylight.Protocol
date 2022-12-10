namespace Skylight.Protocol.Generator.Schema.Mapping;

internal sealed class ConstantMappingSchema : AbstractMappingSchema
{
	public required string Type { get; init; }
	public required string Value { get; init; }
}
