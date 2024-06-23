using Skylight.Protocol.Generator.Schema;

namespace Skylight.Protocol.Generator;

internal static class Program
{
	private static async Task Main(string[] args)
	{
		ProtocolSchemaResolver resolver = new(reformat: true);

		if (args is [string directory])
		{
			await resolver.LoadAllAsync(directory).ConfigureAwait(false);

			foreach (string subDirectory in Directory.EnumerateDirectories(directory, "*", new EnumerationOptions()))
			{
				ProtocolSchema schema = resolver.GetSchema(Path.GetFileName(subDirectory)["Skylight.Protocol.".Length..]);

				ProtocolGenerator.Run(subDirectory, schema, typeof(IGameProtocol).Assembly);
			}
		}
		else
		{
			await resolver.LoadAllAsync(Path.GetDirectoryName(Environment.CurrentDirectory)!).ConfigureAwait(false);

			ProtocolSchema schema = resolver.GetSchema(Path.GetFileName(Environment.CurrentDirectory)["Skylight.Protocol.".Length..]);

			ProtocolGenerator.Run(Path.GetFullPath(Environment.CurrentDirectory), schema, typeof(IGameProtocol).Assembly);
		}
	}
}
