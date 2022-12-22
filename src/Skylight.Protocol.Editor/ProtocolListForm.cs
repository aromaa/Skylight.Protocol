namespace Skylight.Protocol.Editor;

internal partial class ProtocolListForm : Form
{
	internal ProtocolListForm()
	{
		this.InitializeComponent();

		this.SetProtocolDirectory(Environment.CurrentDirectory);
	}

	private void SetProtocolDirectory(string directory)
	{
		this.currentDirectoryLabel.Text = directory;
		this.protocolDirectoryWatcher.Path = directory;

		this.protocolList.Items.Clear();

		foreach (string protocolDirectory in Directory.EnumerateDirectories(directory, "*", new EnumerationOptions()))
		{
			string protocol = Path.GetFileName(protocolDirectory);

			this.protocolList.Items.Add(protocol, protocol, string.Empty);
		}
	}

	private void ChangeProtocolDirectory(object sender, EventArgs e)
	{
		DialogResult result = this.protocolFolderBrowser.ShowDialog();
		if (result == DialogResult.OK)
		{
			this.SetProtocolDirectory(this.protocolFolderBrowser.SelectedPath);
		}
	}

	private void ProtocolDirectoryCreated(object sender, FileSystemEventArgs e)
	{
		string protocol = Path.GetFileName(e.FullPath);

		this.protocolList.Items.Add(protocol, protocol, string.Empty);
	}

	private void ProtocolDirectoryRenamed(object sender, RenamedEventArgs e)
	{
		string oldProtocol = Path.GetFileName(e.OldFullPath);
		string newProtocol = Path.GetFileName(e.FullPath);

		this.protocolList.Items.RemoveByKey(oldProtocol);
		this.protocolList.Items.Add(newProtocol, newProtocol, string.Empty);
	}

	private void ProtocolDirectoryDeleted(object sender, FileSystemEventArgs e)
	{
		string protocol = Path.GetFileName(e.FullPath);

		this.protocolList.Items.RemoveByKey(protocol);
	}

	private void SelectProtocol(object sender, EventArgs e)
	{
		ProtocolOverviewForm protocolOverview = new(Path.Combine(this.currentDirectoryLabel.Text, this.protocolList.SelectedItems[0].Text));
		protocolOverview.Show();
	}
}
