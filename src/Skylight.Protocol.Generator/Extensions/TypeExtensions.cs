using System.Reflection;

namespace Skylight.Protocol.Generator.Extensions;

internal static class TypeExtensions
{
	internal static Type FromAssembly(this Type type, Assembly assembly)
	{
		return assembly.GetType(type.FullName!)!;
	}

	internal static Type FromAssembly(this Type type, MemberInfo memberFromAssembly)
	{
		if (memberFromAssembly.DeclaringType is not null)
		{
			return type.FromAssembly(memberFromAssembly.DeclaringType);
		}

		return memberFromAssembly.Module.Assembly.GetType(type.FullName!)!;
	}

	internal static Type FromAssembly(this Type type, Type typeFromAssembly)
	{
		while (true)
		{
			Type? foundType = typeFromAssembly.Assembly.GetType(type.FullName!);
			if (foundType is not null)
			{
				return foundType;
			}

			if (typeFromAssembly.BaseType is not null)
			{
				typeFromAssembly = typeFromAssembly.BaseType;

				continue;
			}

			break;
		}

		return null!;
	}
}
