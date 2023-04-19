namespace Skylight.Protocol.Editor;

partial class ProtocolListForm
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
            this.protocolList = new System.Windows.Forms.ListView();
            this.protocol = new System.Windows.Forms.ColumnHeader();
            this.protocolDirectoryWatcher = new System.IO.FileSystemWatcher();
            this.protocolFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.currentDirectoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protocolDirectoryWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // protocolList
            // 
            this.protocolList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.protocol});
            this.protocolList.Location = new System.Drawing.Point(12, 36);
            this.protocolList.Name = "protocolList";
            this.protocolList.Size = new System.Drawing.Size(363, 247);
            this.protocolList.TabIndex = 0;
            this.protocolList.UseCompatibleStateImageBehavior = false;
            this.protocolList.View = System.Windows.Forms.View.Details;
            this.protocolList.DoubleClick += new System.EventHandler(this.SelectProtocol);
            // 
            // protocol
            // 
            this.protocol.Text = "Protocol";
            this.protocol.Width = 359;
            // 
            // protocolDirectoryWatcher
            // 
            this.protocolDirectoryWatcher.EnableRaisingEvents = true;
            this.protocolDirectoryWatcher.NotifyFilter = System.IO.NotifyFilters.DirectoryName;
            this.protocolDirectoryWatcher.SynchronizingObject = this;
            this.protocolDirectoryWatcher.Created += new System.IO.FileSystemEventHandler(this.ProtocolDirectoryCreated);
            this.protocolDirectoryWatcher.Deleted += new System.IO.FileSystemEventHandler(this.ProtocolDirectoryDeleted);
            this.protocolDirectoryWatcher.Renamed += new System.IO.RenamedEventHandler(this.ProtocolDirectoryRenamed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Watching:";
            // 
            // currentDirectoryLabel
            // 
            this.currentDirectoryLabel.AutoSize = true;
            this.currentDirectoryLabel.Location = new System.Drawing.Point(79, 9);
            this.currentDirectoryLabel.Name = "currentDirectoryLabel";
            this.currentDirectoryLabel.Size = new System.Drawing.Size(87, 15);
            this.currentDirectoryLabel.TabIndex = 2;
            this.currentDirectoryLabel.Text = "%DIRECTORY%";
            this.currentDirectoryLabel.Click += new System.EventHandler(this.ChangeProtocolDirectory);
            // 
            // ProtocolListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 294);
            this.Controls.Add(this.currentDirectoryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.protocolList);
            this.Name = "ProtocolListForm";
            this.Text = "Protocols";
            ((System.ComponentModel.ISupportInitialize)(this.protocolDirectoryWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	#endregion

	private ListView protocolList;
	private FileSystemWatcher protocolDirectoryWatcher;
	private Label currentDirectoryLabel;
	private Label label1;
	private FolderBrowserDialog protocolFolderBrowser;
	private ColumnHeader protocol;
}
