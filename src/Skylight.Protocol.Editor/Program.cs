using Microsoft.Build.Locator;

namespace Skylight.Protocol.Editor;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();

		try
		{
			MSBuildLocator.RegisterDefaults();
		}
		catch
		{
			MessageBox.Show("Failed to locate MSBuild, automatic builds will not be performed!");
		}

		Application.Run(new ProtocolListForm());
	}
}
