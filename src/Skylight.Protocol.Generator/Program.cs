namespace Skylight.Protocol.Generator;

internal static class Program
{
	private static async Task Main(string[] args)
	{
		if (args is [string directory])
		{
			foreach (string subDirectory in Directory.EnumerateDirectories(directory, "*", new EnumerationOptions()))
			{
				await ProtocolGenerator.Run(subDirectory, typeof(IGameProtocol).Assembly).ConfigureAwait(false);
			}
		}
		else
		{
			await ProtocolGenerator.Run(Path.GetFullPath(Environment.CurrentDirectory), typeof(IGameProtocol).Assembly).ConfigureAwait(false);
		}
	}
}
