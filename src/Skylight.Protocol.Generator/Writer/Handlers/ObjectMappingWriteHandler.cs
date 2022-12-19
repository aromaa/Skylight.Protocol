using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;
using Skylight.Protocol.Packets.Data.Room.Object.Data;

namespace Skylight.Protocol.Generator.Writer.Handlers;

internal sealed class ObjectMappingWriteHandler : MappingWriterHandler
{
	internal override void Read(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		throw new NotImplementedException();
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not ObjectMappingSyntax objectMapping)
		{
			throw new NotSupportedException();
		}

		if (protocol.Interfaces.TryGetValue(objectMapping.Name, out Dictionary<string, string>? interfaces))
		{
			bool first = true;
			foreach ((string objectData, string mappingTarget) in interfaces)
			{
				string name = $"{char.ToLowerInvariant(mappingTarget[0])}{mappingTarget.Substring(1)}";

				Type interfaceType = type is PropertyInfo interfacePropertyInfo ? interfacePropertyInfo.PropertyType : (Type)type;

				writer.WriteLine($"{(first ? string.Empty : "else ")}if ({context.Name} is {objectData}{(interfaceType.IsEnum ? string.Empty : $" {name}")})");
				writer.WriteLine($"{{");
				writer.Indent++;

				if (!interfaceType.IsEnum)
				{
					using (context.PushScope(name, true))
					{
						context.Write(protocol, writer, new ObjectMappingSyntax(mappingTarget), typeof(IItemData).Assembly.GetType(objectData)!);
					}
				}
				else
				{
					using (context.PushScope(context.Name[..context.Name.LastIndexOf('.')], true))
					{
						context.Write(protocol, writer, new ObjectMappingSyntax(mappingTarget), type.DeclaringType!);
					}
				}

				writer.Indent--;
				writer.WriteLine($"}}");

				first = false;
			}

			if (!first)
			{
				writer.WriteLine($"else");
				writer.WriteLine($"{{");
				writer.Indent++;

				writer.WriteLine($"throw new NotSupportedException();");

				writer.Indent--;
				writer.WriteLine($"}}");
			}

			return;
		}

		TupleElementNamesAttribute? names;
		if (type is PropertyInfo propertyInfo)
		{
			names = propertyInfo.GetCustomAttribute<TupleElementNamesAttribute>();
			type = propertyInfo.PropertyType;

			if (names is not null)
			{
				if (!((Type)type).IsAssignableTo(typeof(ITuple)))
				{
					type = ((Type)type).GetGenericArguments()[0];
				}
			}
		}
		else
		{
			names = null;
		}

		ObjectStructure structure = protocol.Structures[objectMapping.Name];

		foreach ((string? fieldName, AbstractMappingSyntax syntax) in structure.Mapping)
		{
			if (structure.Recursive && syntax is GenericTypeMappingSyntax genericSyntax && genericSyntax.GenericArgument == mapping)
			{
				continue;
			}

			using (context.PushScope(fieldName))
			{
				if (fieldName is not null)
				{
					if (names is not null)
					{
						int index = names.TransformNames.IndexOf(fieldName) + 1;

						Type tupleTargetType = (Type)type;

						while (index >= 8)
						{
							tupleTargetType = tupleTargetType.GetField("Rest")!.FieldType;

							index -= 7;
						}

						FieldInfo fieldInfo = tupleTargetType.GetField($"Item{index}")!;

						context.Write(protocol, writer, syntax, fieldInfo.FieldType);

						continue;
					}
					else if (type is Type typeType)
					{
						PropertyInfo? property = typeType.GetProperty(fieldName);
						if (property is not null)
						{
							context.Write(protocol, writer, syntax, property);

							continue;
						}
					}
				}

				context.Write(protocol, writer, syntax, type);
			}
		}
	}
}
