using System.CodeDom.Compiler;
using System.Reflection;
using Skylight.Protocol.Generator.Extensions;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;

namespace Skylight.Protocol.Generator.Writer.Handlers;

internal sealed class TypeMappingWriteHandler : MappingWriterHandler
{
	internal override void Read(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not TypeMappingSyntax typeMapping)
		{
			throw new NotSupportedException();
		}

		if (type is PropertyInfo propertyInfo)
		{
			type = propertyInfo.PropertyType;
		}

		if (typeMapping.Type == typeof(string).FromAssembly(typeMapping.Type))
		{
			writer.Write(protocol.Protocol is "Modern"
				? $"reader.ReadBytes(reader.ReadInt16())"
				: $"reader.ReadBytes(reader.ReadBase64UInt32(2))");
		}
		else if (typeMapping.Type == typeof(int).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(bool).FromAssembly(type))
			{
				writer.Write($"reader.ReadInt32() != 0");
			}
			else if (((Type)type).IsEnum)
			{
				Type enumType = (Type)type;

				writer.Write(protocol.Protocol is "Modern"
					? $"({enumType.Namespace}.{enumType.Name})reader.ReadInt32()"
					: $"({enumType.Namespace}.{enumType.Name})reader.ReadVL64UInt32()");
			}
			else
			{
				writer.Write(protocol.Protocol is "Modern"
					? $"reader.ReadInt32()"
					: "(int)reader.ReadVL64UInt32()");
			}
		}
		else if (typeMapping.Type == typeof(bool).FromAssembly(typeMapping.Type))
		{
			writer.Write($"reader.ReadBool()");
		}
		else
		{
			throw new NotSupportedException();
		}
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not TypeMappingSyntax typeMapping)
		{
			throw new NotSupportedException();
		}

		if (type is PropertyInfo propertyInfo)
		{
			type = propertyInfo.PropertyType;
		}

		if (typeMapping.Type == typeof(bool).FromAssembly(typeMapping.Type))
		{
			writer.WriteLine($"writer.WriteBool({context.Name});");
		}
		else if (typeMapping.Type == typeof(short).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(short).FromAssembly(type))
			{
				writer.WriteLine($"writer.WriteInt16({context.Name});");
			}
			else
			{
				writer.WriteLine($"writer.WriteInt16((short){context.Name});");
			}
		}
		else if (typeMapping.Type == typeof(int).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(bool).FromAssembly(type))
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteInt32({context.Name} ? 1 : 0);"
					: $"writer.WriteVL64Int32({context.Name} ? 1 : 0);");
			}
			else if (((Type)type).IsEnum)
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteInt32((int){context.Name});"
					: $"writer.WriteVL64Int32((int){context.Name});");
			}
			else
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteInt32({context.Name});"
					: $"writer.WriteVL64Int32({context.Name});");
			}
		}
		else if (typeMapping.Type == typeof(string).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(ICollection<short>).FromAssembly(type))
			{
				writer.WriteLine($"writer.WriteFixedUInt16String(string.Join('\\r', {context.Name}.Select(i => (byte)('0' + i)).Chunk((int)packet.Width).Select(c => System.Text.Encoding.UTF8.GetString(c))));");
			}
			else if (type == typeof(double).FromAssembly(type))
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteFixedUInt16String({context.Name}.ToString(CultureInfo.InvariantCulture));"
					: $"writer.WriteDelimiter2BrokenString({context.Name}.ToString(CultureInfo.InvariantCulture));");
			}
			else if (type != typeof(string).FromAssembly(type))
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteFixedUInt16String({context.Name}.ToString());"
					: $"writer.WriteDelimiter2BrokenString({context.Name}.ToString());");
			}
			else
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteFixedUInt16String({context.Name});"
					: $"writer.WriteDelimiter2BrokenString({context.Name});");
			}
		}
		else if (typeMapping.Type == typeof(byte[]).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(ICollection<short>).FromAssembly(type))
			{
				writer.WriteLine($"writer.WriteText(string.Join('\\r', {context.Name}.Select(i => (byte)('0' + i)).Chunk((int)packet.Width).Select(c => System.Text.Encoding.UTF8.GetString(c))));");
			}
			else if (type == typeof(DateTime).FromAssembly(type))
			{
				writer.WriteLine($"writer.WriteText({context.Name}.ToString(\"d-M-yyyy\"));");
			}
			else if (type == typeof(ICollection<int>).FromAssembly(type))
			{
				writer.WriteLine($"writer.WriteText('[' + string.Join(',', {context.Name}) + ']');");
			}
			else
			{
				writer.WriteLine($"writer.WriteText({context.Name});");
			}
		}
		else
		{
			throw new NotImplementedException();
		}
	}
}
