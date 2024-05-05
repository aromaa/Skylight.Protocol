using System.Reflection;
using Skylight.Protocol.Generator.Extensions;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Parser;

internal static class MappingParser
{
	internal static AbstractMappingSyntax Parse(AbstractMappingSchema mapping, Assembly assembly)
	{
		if (mapping is FieldMappingSchema fieldMapping)
		{
			return MappingParser.ParseType(fieldMapping.Type, assembly, fieldMapping.Name);
		}
		else if (mapping is ConstantMappingSchema constantMapping)
		{
			if (MappingParser.ParseType(constantMapping.Type, assembly) is TypeMappingSyntax typeMapping)
			{
				return new ConstantMappingSyntax(Convert.ChangeType(constantMapping.Value, typeMapping.Type.FromAssembly(typeof(object))), typeMapping);
			}
		}
		else if (mapping is ConditionalMappingSchema conditionalMapping)
		{
			return new ConditionalMappingSyntax(conditionalMapping.Condition, MappingParser.Parse(conditionalMapping.WhenTrue, assembly));
		}
		else if (mapping is CombineMappingSchema combineMapping)
		{
			return new CombineMappingSyntax(MappingParser.ParseType(combineMapping.Type, assembly), combineMapping.Fields.Select(f => MappingParser.Parse(f, assembly)).ToList());
		}

		throw new NotSupportedException();
	}

	private static AbstractMappingSyntax ParseType(string type, Assembly assembly, string? name = default)
	{
		Span<Range> ranges = stackalloc Range[2];

		int splitCount = type.AsSpan().Split(ranges, ':', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

		switch (type.AsSpan()[ranges[0]])
		{
			case "string":
				return new TypeMappingSyntax(typeof(string).FromAssembly(assembly), name);
			case "text":
				return new TypeMappingSyntax(typeof(byte[]).FromAssembly(assembly), name, splitCount == 2 ? type[ranges[1]] : null);
			case "int":
				return new TypeMappingSyntax(typeof(int).FromAssembly(assembly), name);
			case "short":
				return new TypeMappingSyntax(typeof(short).FromAssembly(assembly), name);
			case "bool":
				return new TypeMappingSyntax(typeof(bool).FromAssembly(assembly), name);
			case "List":
				return new TypeMappingSyntax(typeof(List<>).FromAssembly(assembly), name);
			case "BufferedList":
				return new TypeMappingSyntax(typeof(IAsyncEnumerator<>).FromAssembly(assembly), name);
		}

		int genericArgumentIndex = type.IndexOf('<');
		if (genericArgumentIndex != -1)
		{
			string genericType = type.Substring(0, genericArgumentIndex);
			string genericArgument = type.Substring(genericArgumentIndex + 1, type.LastIndexOf('>') - genericArgumentIndex - 1);

			if (MappingParser.ParseType(genericType, assembly) is TypeMappingSyntax typeMapping)
			{
				return new GenericTypeMappingSyntax(typeMapping.Type, MappingParser.ParseType(genericArgument, assembly));
			}
		}

		return new ObjectMappingSyntax(type);
	}
}
