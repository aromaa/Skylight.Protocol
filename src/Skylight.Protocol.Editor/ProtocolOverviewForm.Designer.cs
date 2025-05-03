namespace Skylight.Protocol.Editor;

partial class ProtocolOverviewForm
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
		this.label1 = new Label();
		this.protocolName = new Label();
		this.splitContainer1 = new SplitContainer();
		this.addNewButton = new Button();
		this.addNewTextBox = new TextBox();
		this.structuresTab = new TabControl();
		this.incomingPacketsTab = new TabPage();
		this.incomingPacketList = new ListView();
		this.incomingPacket = new ColumnHeader();
		this.outgoingPacketsTab = new TabPage();
		this.outgoingPacketsList = new ListView();
		this.outgoingPacket = new ColumnHeader();
		this.selectStructureTab = new TabPage();
		this.structuresList = new ListView();
		this.structureColumn = new ColumnHeader();
		this.interfacesTab = new TabPage();
		this.interfacesList = new ListView();
		this.interfacesColumn = new ColumnHeader();
		this.optionsTab = new TabPage();
		this.sulekDevImport = new Button();
		this.packetTabControl = new TabControl();
		this.emptyTab = new TabPage();
		this.packetTab = new TabPage();
		this.packetIdImportedFrom = new Label();
		this.addPacketConditional = new Button();
		this.addPacketConstant = new Button();
		this.addPacketField = new Button();
		this.packetData = new FlowLayoutPanel();
		this.label2 = new Label();
		this.structureTab = new TabPage();
		this.addStructureConditional = new Button();
		this.addStructureConstant = new Button();
		this.addStructureField = new Button();
		this.structureData = new FlowLayoutPanel();
		this.interfaceTab = new TabPage();
		this.addInterface = new Button();
		this.interfaceData = new FlowLayoutPanel();
		this.save = new Button();
		this.openSulekData = new OpenFileDialog();
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).BeginInit();
		this.splitContainer1.Panel1.SuspendLayout();
		this.splitContainer1.Panel2.SuspendLayout();
		this.splitContainer1.SuspendLayout();
		this.structuresTab.SuspendLayout();
		this.incomingPacketsTab.SuspendLayout();
		this.outgoingPacketsTab.SuspendLayout();
		this.selectStructureTab.SuspendLayout();
		this.interfacesTab.SuspendLayout();
		this.optionsTab.SuspendLayout();
		this.packetTabControl.SuspendLayout();
		this.packetTab.SuspendLayout();
		this.structureTab.SuspendLayout();
		this.interfaceTab.SuspendLayout();
		this.SuspendLayout();
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new Point(12, 9);
		this.label1.Name = "label1";
		this.label1.Size = new Size(72, 15);
		this.label1.TabIndex = 0;
		this.label1.Text = "Working on:";
		// 
		// protocolName
		// 
		this.protocolName.AutoSize = true;
		this.protocolName.Location = new Point(90, 9);
		this.protocolName.Name = "protocolName";
		this.protocolName.Size = new Size(86, 15);
		this.protocolName.TabIndex = 1;
		this.protocolName.Text = "%PROTOCOL%";
		// 
		// splitContainer1
		// 
		this.splitContainer1.Location = new Point(12, 27);
		this.splitContainer1.Name = "splitContainer1";
		// 
		// splitContainer1.Panel1
		// 
		this.splitContainer1.Panel1.Controls.Add(this.addNewButton);
		this.splitContainer1.Panel1.Controls.Add(this.addNewTextBox);
		this.splitContainer1.Panel1.Controls.Add(this.structuresTab);
		// 
		// splitContainer1.Panel2
		// 
		this.splitContainer1.Panel2.Controls.Add(this.packetTabControl);
		this.splitContainer1.Size = new Size(1368, 596);
		this.splitContainer1.SplitterDistance = 362;
		this.splitContainer1.TabIndex = 2;
		// 
		// addNewButton
		// 
		this.addNewButton.Location = new Point(274, 568);
		this.addNewButton.Name = "addNewButton";
		this.addNewButton.Size = new Size(75, 23);
		this.addNewButton.TabIndex = 5;
		this.addNewButton.Text = "New";
		this.addNewButton.UseVisualStyleBackColor = true;
		this.addNewButton.Click += this.AddNew;
		// 
		// addNewTextBox
		// 
		this.addNewTextBox.Location = new Point(7, 568);
		this.addNewTextBox.Name = "addNewTextBox";
		this.addNewTextBox.Size = new Size(261, 23);
		this.addNewTextBox.TabIndex = 4;
		// 
		// structuresTab
		// 
		this.structuresTab.Controls.Add(this.incomingPacketsTab);
		this.structuresTab.Controls.Add(this.outgoingPacketsTab);
		this.structuresTab.Controls.Add(this.selectStructureTab);
		this.structuresTab.Controls.Add(this.interfacesTab);
		this.structuresTab.Controls.Add(this.optionsTab);
		this.structuresTab.Location = new Point(3, 3);
		this.structuresTab.Name = "structuresTab";
		this.structuresTab.SelectedIndex = 0;
		this.structuresTab.Size = new Size(356, 563);
		this.structuresTab.TabIndex = 3;
		// 
		// incomingPacketsTab
		// 
		this.incomingPacketsTab.Controls.Add(this.incomingPacketList);
		this.incomingPacketsTab.Location = new Point(4, 24);
		this.incomingPacketsTab.Name = "incomingPacketsTab";
		this.incomingPacketsTab.Padding = new Padding(3);
		this.incomingPacketsTab.Size = new Size(348, 535);
		this.incomingPacketsTab.TabIndex = 0;
		this.incomingPacketsTab.Text = "Incoming";
		this.incomingPacketsTab.UseVisualStyleBackColor = true;
		// 
		// incomingPacketList
		// 
		this.incomingPacketList.Columns.AddRange(new ColumnHeader[] { this.incomingPacket });
		this.incomingPacketList.Location = new Point(6, 6);
		this.incomingPacketList.Name = "incomingPacketList";
		this.incomingPacketList.Size = new Size(336, 523);
		this.incomingPacketList.TabIndex = 0;
		this.incomingPacketList.UseCompatibleStateImageBehavior = false;
		this.incomingPacketList.View = View.Details;
		this.incomingPacketList.SelectedIndexChanged += this.SelectIncomingPacket;
		this.incomingPacketList.KeyDown += this.KeyDownIncomingPackets;
		// 
		// incomingPacket
		// 
		this.incomingPacket.Text = "Packet";
		this.incomingPacket.Width = 332;
		// 
		// outgoingPacketsTab
		// 
		this.outgoingPacketsTab.Controls.Add(this.outgoingPacketsList);
		this.outgoingPacketsTab.Location = new Point(4, 24);
		this.outgoingPacketsTab.Name = "outgoingPacketsTab";
		this.outgoingPacketsTab.Padding = new Padding(3);
		this.outgoingPacketsTab.Size = new Size(348, 535);
		this.outgoingPacketsTab.TabIndex = 1;
		this.outgoingPacketsTab.Text = "Outgoing";
		this.outgoingPacketsTab.UseVisualStyleBackColor = true;
		// 
		// outgoingPacketsList
		// 
		this.outgoingPacketsList.Columns.AddRange(new ColumnHeader[] { this.outgoingPacket });
		this.outgoingPacketsList.Location = new Point(6, 6);
		this.outgoingPacketsList.Name = "outgoingPacketsList";
		this.outgoingPacketsList.Size = new Size(336, 523);
		this.outgoingPacketsList.TabIndex = 0;
		this.outgoingPacketsList.UseCompatibleStateImageBehavior = false;
		this.outgoingPacketsList.View = View.Details;
		this.outgoingPacketsList.SelectedIndexChanged += this.SelectOutgoingPacket;
		this.outgoingPacketsList.KeyDown += this.KeyDownOutgoingPacket;
		// 
		// outgoingPacket
		// 
		this.outgoingPacket.Text = "Packet";
		this.outgoingPacket.Width = 332;
		// 
		// selectStructureTab
		// 
		this.selectStructureTab.Controls.Add(this.structuresList);
		this.selectStructureTab.Location = new Point(4, 24);
		this.selectStructureTab.Name = "selectStructureTab";
		this.selectStructureTab.Padding = new Padding(3);
		this.selectStructureTab.Size = new Size(348, 535);
		this.selectStructureTab.TabIndex = 2;
		this.selectStructureTab.Text = "Structures";
		this.selectStructureTab.UseVisualStyleBackColor = true;
		// 
		// structuresList
		// 
		this.structuresList.Columns.AddRange(new ColumnHeader[] { this.structureColumn });
		this.structuresList.Location = new Point(6, 6);
		this.structuresList.Name = "structuresList";
		this.structuresList.Size = new Size(336, 523);
		this.structuresList.TabIndex = 0;
		this.structuresList.UseCompatibleStateImageBehavior = false;
		this.structuresList.View = View.Details;
		this.structuresList.SelectedIndexChanged += this.SelectStructure;
		this.structuresList.KeyDown += this.KeyDownStructures;
		// 
		// structureColumn
		// 
		this.structureColumn.Text = "Structure";
		this.structureColumn.Width = 332;
		// 
		// interfacesTab
		// 
		this.interfacesTab.Controls.Add(this.interfacesList);
		this.interfacesTab.Location = new Point(4, 24);
		this.interfacesTab.Name = "interfacesTab";
		this.interfacesTab.Padding = new Padding(3);
		this.interfacesTab.Size = new Size(348, 535);
		this.interfacesTab.TabIndex = 3;
		this.interfacesTab.Text = "Interfaces";
		this.interfacesTab.UseVisualStyleBackColor = true;
		// 
		// interfacesList
		// 
		this.interfacesList.Columns.AddRange(new ColumnHeader[] { this.interfacesColumn });
		this.interfacesList.Location = new Point(6, 6);
		this.interfacesList.Name = "interfacesList";
		this.interfacesList.Size = new Size(336, 523);
		this.interfacesList.TabIndex = 0;
		this.interfacesList.UseCompatibleStateImageBehavior = false;
		this.interfacesList.View = View.Details;
		this.interfacesList.SelectedIndexChanged += this.SelectInterface;
		this.interfacesList.KeyDown += this.KeyDownInterfaces;
		// 
		// interfacesColumn
		// 
		this.interfacesColumn.Text = "Interfaces";
		this.interfacesColumn.Width = 332;
		// 
		// optionsTab
		// 
		this.optionsTab.Controls.Add(this.sulekDevImport);
		this.optionsTab.Location = new Point(4, 24);
		this.optionsTab.Name = "optionsTab";
		this.optionsTab.Padding = new Padding(3);
		this.optionsTab.Size = new Size(348, 535);
		this.optionsTab.TabIndex = 4;
		this.optionsTab.Text = "Options";
		this.optionsTab.UseVisualStyleBackColor = true;
		// 
		// sulekDevImport
		// 
		this.sulekDevImport.Location = new Point(6, 6);
		this.sulekDevImport.Name = "sulekDevImport";
		this.sulekDevImport.Size = new Size(336, 23);
		this.sulekDevImport.TabIndex = 0;
		this.sulekDevImport.Text = "Import sulek.dev data";
		this.sulekDevImport.UseVisualStyleBackColor = true;
		this.sulekDevImport.Click += this.SulekDevImport;
		// 
		// packetTabControl
		// 
		this.packetTabControl.Controls.Add(this.emptyTab);
		this.packetTabControl.Controls.Add(this.packetTab);
		this.packetTabControl.Controls.Add(this.structureTab);
		this.packetTabControl.Controls.Add(this.interfaceTab);
		this.packetTabControl.Location = new Point(3, 3);
		this.packetTabControl.Name = "packetTabControl";
		this.packetTabControl.SelectedIndex = 0;
		this.packetTabControl.Size = new Size(996, 588);
		this.packetTabControl.TabIndex = 0;
		// 
		// emptyTab
		// 
		this.emptyTab.Location = new Point(4, 24);
		this.emptyTab.Name = "emptyTab";
		this.emptyTab.Padding = new Padding(3);
		this.emptyTab.Size = new Size(988, 560);
		this.emptyTab.TabIndex = 3;
		this.emptyTab.Text = "Empty";
		this.emptyTab.UseVisualStyleBackColor = true;
		// 
		// packetTab
		// 
		this.packetTab.Controls.Add(this.packetIdImportedFrom);
		this.packetTab.Controls.Add(this.addPacketConditional);
		this.packetTab.Controls.Add(this.addPacketConstant);
		this.packetTab.Controls.Add(this.addPacketField);
		this.packetTab.Controls.Add(this.packetData);
		this.packetTab.Controls.Add(this.label2);
		this.packetTab.Location = new Point(4, 24);
		this.packetTab.Name = "packetTab";
		this.packetTab.Padding = new Padding(3);
		this.packetTab.Size = new Size(988, 560);
		this.packetTab.TabIndex = 0;
		this.packetTab.Text = "Packet";
		this.packetTab.UseVisualStyleBackColor = true;
		// 
		// packetIdImportedFrom
		// 
		this.packetIdImportedFrom.AutoSize = true;
		this.packetIdImportedFrom.Location = new Point(197, 9);
		this.packetIdImportedFrom.Name = "packetIdImportedFrom";
		this.packetIdImportedFrom.Size = new Size(0, 15);
		this.packetIdImportedFrom.TabIndex = 6;
		// 
		// addPacketConditional
		// 
		this.addPacketConditional.Location = new Point(185, 531);
		this.addPacketConditional.Name = "addPacketConditional";
		this.addPacketConditional.Size = new Size(102, 23);
		this.addPacketConditional.TabIndex = 5;
		this.addPacketConditional.Text = "Add Conditional";
		this.addPacketConditional.UseVisualStyleBackColor = true;
		this.addPacketConditional.Click += this.AddPacketConditional;
		// 
		// addPacketConstant
		// 
		this.addPacketConstant.Location = new Point(87, 531);
		this.addPacketConstant.Name = "addPacketConstant";
		this.addPacketConstant.Size = new Size(92, 23);
		this.addPacketConstant.TabIndex = 4;
		this.addPacketConstant.Text = "Add Constant";
		this.addPacketConstant.UseVisualStyleBackColor = true;
		this.addPacketConstant.Click += this.AddPacketConstant;
		// 
		// addPacketField
		// 
		this.addPacketField.Location = new Point(6, 531);
		this.addPacketField.Name = "addPacketField";
		this.addPacketField.Size = new Size(75, 23);
		this.addPacketField.TabIndex = 3;
		this.addPacketField.Text = "Add Field";
		this.addPacketField.UseVisualStyleBackColor = true;
		this.addPacketField.Click += this.AddPacketField;
		// 
		// packetData
		// 
		this.packetData.AutoScroll = true;
		this.packetData.FlowDirection = FlowDirection.TopDown;
		this.packetData.Location = new Point(6, 35);
		this.packetData.Name = "packetData";
		this.packetData.Size = new Size(976, 494);
		this.packetData.TabIndex = 2;
		this.packetData.WrapContents = false;
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Location = new Point(6, 9);
		this.label2.Name = "label2";
		this.label2.Size = new Size(59, 15);
		this.label2.TabIndex = 1;
		this.label2.Text = "Packet ID:";
		// 
		// structureTab
		// 
		this.structureTab.Controls.Add(this.addStructureConditional);
		this.structureTab.Controls.Add(this.addStructureConstant);
		this.structureTab.Controls.Add(this.addStructureField);
		this.structureTab.Controls.Add(this.structureData);
		this.structureTab.Location = new Point(4, 24);
		this.structureTab.Name = "structureTab";
		this.structureTab.Padding = new Padding(3);
		this.structureTab.Size = new Size(988, 560);
		this.structureTab.TabIndex = 1;
		this.structureTab.Text = "Structure";
		this.structureTab.UseVisualStyleBackColor = true;
		// 
		// addStructureConditional
		// 
		this.addStructureConditional.Location = new Point(187, 534);
		this.addStructureConditional.Name = "addStructureConditional";
		this.addStructureConditional.Size = new Size(102, 23);
		this.addStructureConditional.TabIndex = 3;
		this.addStructureConditional.Text = "Add Conditional";
		this.addStructureConditional.UseVisualStyleBackColor = true;
		this.addStructureConditional.Click += this.AddStructureConditional;
		// 
		// addStructureConstant
		// 
		this.addStructureConstant.Location = new Point(84, 534);
		this.addStructureConstant.Name = "addStructureConstant";
		this.addStructureConstant.Size = new Size(97, 23);
		this.addStructureConstant.TabIndex = 2;
		this.addStructureConstant.Text = "Add Constant";
		this.addStructureConstant.UseVisualStyleBackColor = true;
		this.addStructureConstant.Click += this.AddStructureConstant;
		// 
		// addStructureField
		// 
		this.addStructureField.Location = new Point(3, 534);
		this.addStructureField.Name = "addStructureField";
		this.addStructureField.Size = new Size(75, 23);
		this.addStructureField.TabIndex = 1;
		this.addStructureField.Text = "Add Field";
		this.addStructureField.UseVisualStyleBackColor = true;
		this.addStructureField.Click += this.AddStructureField;
		// 
		// structureData
		// 
		this.structureData.AutoScroll = true;
		this.structureData.FlowDirection = FlowDirection.TopDown;
		this.structureData.Location = new Point(6, 6);
		this.structureData.Name = "structureData";
		this.structureData.Size = new Size(976, 523);
		this.structureData.TabIndex = 0;
		this.structureData.WrapContents = false;
		// 
		// interfaceTab
		// 
		this.interfaceTab.Controls.Add(this.addInterface);
		this.interfaceTab.Controls.Add(this.interfaceData);
		this.interfaceTab.Location = new Point(4, 24);
		this.interfaceTab.Name = "interfaceTab";
		this.interfaceTab.Padding = new Padding(3);
		this.interfaceTab.Size = new Size(988, 560);
		this.interfaceTab.TabIndex = 2;
		this.interfaceTab.Text = "Interface";
		this.interfaceTab.UseVisualStyleBackColor = true;
		// 
		// addInterface
		// 
		this.addInterface.Location = new Point(3, 534);
		this.addInterface.Name = "addInterface";
		this.addInterface.Size = new Size(75, 23);
		this.addInterface.TabIndex = 1;
		this.addInterface.Text = "Add";
		this.addInterface.UseVisualStyleBackColor = true;
		this.addInterface.Click += this.AddInterface;
		// 
		// interfaceData
		// 
		this.interfaceData.AutoScroll = true;
		this.interfaceData.FlowDirection = FlowDirection.TopDown;
		this.interfaceData.Location = new Point(6, 6);
		this.interfaceData.Name = "interfaceData";
		this.interfaceData.Size = new Size(976, 522);
		this.interfaceData.TabIndex = 0;
		this.interfaceData.WrapContents = false;
		// 
		// save
		// 
		this.save.Location = new Point(385, 1);
		this.save.Name = "save";
		this.save.Size = new Size(995, 23);
		this.save.TabIndex = 3;
		this.save.Text = "Save";
		this.save.UseVisualStyleBackColor = true;
		this.save.Click += this.Save;
		// 
		// openSulekData
		// 
		this.openSulekData.FileName = "messages.json";
		this.openSulekData.Filter = "Sulek|messages.json";
		// 
		// ProtocolOverviewForm
		// 
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.ClientSize = new Size(1392, 635);
		this.Controls.Add(this.save);
		this.Controls.Add(this.splitContainer1);
		this.Controls.Add(this.protocolName);
		this.Controls.Add(this.label1);
		this.Name = "ProtocolOverviewForm";
		this.Text = "Protocol";
		this.Load += this.ProtocolOverviewFormLoad;
		this.splitContainer1.Panel1.ResumeLayout(false);
		this.splitContainer1.Panel1.PerformLayout();
		this.splitContainer1.Panel2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.splitContainer1).EndInit();
		this.splitContainer1.ResumeLayout(false);
		this.structuresTab.ResumeLayout(false);
		this.incomingPacketsTab.ResumeLayout(false);
		this.outgoingPacketsTab.ResumeLayout(false);
		this.selectStructureTab.ResumeLayout(false);
		this.interfacesTab.ResumeLayout(false);
		this.optionsTab.ResumeLayout(false);
		this.packetTabControl.ResumeLayout(false);
		this.packetTab.ResumeLayout(false);
		this.packetTab.PerformLayout();
		this.structureTab.ResumeLayout(false);
		this.interfaceTab.ResumeLayout(false);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private Label label1;
	private Label protocolName;
	private SplitContainer splitContainer1;
	private ListView incomingPacketList;
	private ColumnHeader incomingPacket;
	private TabControl structuresTab;
	private TabPage incomingPacketsTab;
	private TabPage outgoingPacketsTab;
	private TabPage selectStructureTab;
	private ListView outgoingPacketsList;
	private TabPage interfacesTab;
	private ColumnHeader outgoingPacket;
	private ListView structuresList;
	private ColumnHeader structureColumn;
	private ListView interfacesList;
	private ColumnHeader interfacesColumn;
	private Button addNewButton;
	private TextBox addNewTextBox;
	private TabControl packetTabControl;
	private TabPage packetTab;
	private TabPage structureTab;
	private TabPage interfaceTab;
	private Label label2;
	private FlowLayoutPanel packetData;
	private FlowLayoutPanel structureData;
	private FlowLayoutPanel interfaceData;
	private Button addPacketConditional;
	private Button addPacketConstant;
	private Button addPacketField;
	private Button addStructureConditional;
	private Button addStructureConstant;
	private Button addStructureField;
	private Button addInterface;
	private Button save;
	private TabPage emptyTab;
	private TabPage optionsTab;
	private Button sulekDevImport;
	private OpenFileDialog openSulekData;
	private Label packetIdImportedFrom;
}
