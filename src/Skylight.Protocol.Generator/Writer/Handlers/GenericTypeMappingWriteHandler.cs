using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime.CompilerServices;
using Skylight.Protocol.Generator.Extensions;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;

namespace Skylight.Protocol.Generator.Writer.Handlers;

internal sealed class GenericTypeMappingWriteHandler : MappingWriterHandler
{
	internal override void Read(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not GenericTypeMappingSyntax genericMapping)
		{
			throw new NotSupportedException();
		}

		if (genericMapping.Type == typeof(List<>).FromAssembly(genericMapping.Type))
		{
			int variableIndex = context.Name.LastIndexOf('.');

			string name = $"{context.Name.Substring(variableIndex + 1)}";

			writer.Write($"Read{name}(ref reader)");
		}
	}

	internal override void ReadPost(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not GenericTypeMappingSyntax genericMapping)
		{
			throw new NotSupportedException();
		}

		if (genericMapping.Type == typeof(List<>).FromAssembly(genericMapping.Type))
		{
			int variableIndex = context.Name.LastIndexOf('.');

			string name = $"{context.Name.Substring(variableIndex + 1)}";

			writer.WriteLineNoTabs(string.Empty);
			writer.WriteLine($"static List<{((TypeMappingSyntax)genericMapping.GenericArgument).Type}> Read{name}(ref PacketReader reader)");
			writer.WriteLine($"{{");
			writer.Indent++;
			writer.WriteLine($"List<{((TypeMappingSyntax)genericMapping.GenericArgument).Type}> list = new();");
			writer.WriteLine($"int count = reader.ReadInt32();");
			writer.WriteLine($"for (int i = 0; i < count; i++)");
			writer.WriteLine($"{{");
			writer.Indent++;

			writer.Write($"list.Add(");
			context.Read(protocol, writer, genericMapping.GenericArgument, ((TypeMappingSyntax)genericMapping.GenericArgument).Type);
			writer.WriteLine($");");

			writer.Indent--;
			writer.WriteLine($"}}");
			writer.WriteLine($"return list;");
			writer.Indent--;
			writer.WriteLine($"}};");
		}
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not GenericTypeMappingSyntax genericMapping)
		{
			throw new NotSupportedException();
		}

		if (genericMapping.Type == typeof(List<>).FromAssembly(genericMapping.Type) || genericMapping.Type == typeof(IAsyncEnumerator<>).FromAssembly(genericMapping.Type))
		{
			int variableIndex = context.Name.LastIndexOf('.');

			string name = $"{char.ToLowerInvariant(context.Name[variableIndex + 1])}{context.Name.Substring(variableIndex + 2)}";

			bool recursive = genericMapping.GenericArgument is ObjectMappingSyntax objectMapping && protocol.Structures[objectMapping.Name].Recursive;
			if (recursive)
			{
				writer.WriteLine($"Write(ref writer, {context.Name});");
				writer.WriteLineNoTabs(string.Empty);
				writer.WriteLine($"static void Write(ref PacketWriter writer, {(type is PropertyInfo propertyInfo ? propertyInfo.PropertyType.ToString() : type.ToString())!.Replace(']', '>').Replace('[', '<').Replace("`1", string.Empty)} {name}s)");
				writer.WriteLine($"{{");
				writer.Indent++;
			}

			if (genericMapping.Type == typeof(List<>).FromAssembly(genericMapping.Type))
			{
				using (context.PushScope($"{(recursive ? $"{name}s" : context.Name)}.Count", true))
				{
					context.Write(protocol, writer, new TypeMappingSyntax(typeof(int)), typeof(int));
				}
			}

			writer.WriteLine($"foreach (var {name} in {(recursive ? $"{name}s" : context.Name)})");
			writer.WriteLine($"{{");
			writer.Indent++;

			using (context.PushScope(name, overrideName: true))
			{
				if (type is PropertyInfo propertyInfo)
				{
					if (propertyInfo.GetCustomAttributesData().Any(a => a.AttributeType == typeof(TupleElementNamesAttribute).FromAssembly(type)))
					{
						context.Write(protocol, writer, genericMapping.GenericArgument, type);
					}
					else
					{
						context.Write(protocol, writer, genericMapping.GenericArgument, propertyInfo.PropertyType.GetGenericArguments()[0]);
					}
				}
				else
				{
					context.Write(protocol, writer, genericMapping.GenericArgument, ((Type)type).GetGenericArguments()[0]);
				}
			}

			if (recursive)
			{
				writer.WriteLine($"Write(ref writer, {name}.{context.Name.Substring(variableIndex + 1)});");
				writer.Indent--;
				writer.WriteLine($"}}");
				writer.WriteLineNoTabs(string.Empty);
			}

			writer.Indent--;
			writer.WriteLine($"}}");
		}
		else
		{
			throw new NotSupportedException();
		}
	}
}
