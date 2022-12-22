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
			this.label1 = new System.Windows.Forms.Label();
			this.protocolName = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.addNewButton = new System.Windows.Forms.Button();
			this.addNewTextBox = new System.Windows.Forms.TextBox();
			this.structuresTab = new System.Windows.Forms.TabControl();
			this.incomingPacketsTab = new System.Windows.Forms.TabPage();
			this.incomingPacketList = new System.Windows.Forms.ListView();
			this.incomingPacket = new System.Windows.Forms.ColumnHeader();
			this.outgoingPacketsTab = new System.Windows.Forms.TabPage();
			this.outgoingPacketsList = new System.Windows.Forms.ListView();
			this.outgoingPacket = new System.Windows.Forms.ColumnHeader();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.structuresList = new System.Windows.Forms.ListView();
			this.structureColumn = new System.Windows.Forms.ColumnHeader();
			this.interfacesTab = new System.Windows.Forms.TabPage();
			this.interfacesList = new System.Windows.Forms.ListView();
			this.interfacesColumn = new System.Windows.Forms.ColumnHeader();
			this.packetTabControl = new System.Windows.Forms.TabControl();
			this.packetTab = new System.Windows.Forms.TabPage();
			this.addPacketConditional = new System.Windows.Forms.Button();
			this.addPacketConstant = new System.Windows.Forms.Button();
			this.addPacketField = new System.Windows.Forms.Button();
			this.packetData = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.packetId = new System.Windows.Forms.NumericUpDown();
			this.structureTab = new System.Windows.Forms.TabPage();
			this.addStructureConditional = new System.Windows.Forms.Button();
			this.addStructureConstant = new System.Windows.Forms.Button();
			this.addStructureField = new System.Windows.Forms.Button();
			this.structureData = new System.Windows.Forms.FlowLayoutPanel();
			this.interfaceTab = new System.Windows.Forms.TabPage();
			this.addInterface = new System.Windows.Forms.Button();
			this.interfaceData = new System.Windows.Forms.FlowLayoutPanel();
			this.save = new System.Windows.Forms.Button();
			this.emptyTab = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.structuresTab.SuspendLayout();
			this.incomingPacketsTab.SuspendLayout();
			this.outgoingPacketsTab.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.interfacesTab.SuspendLayout();
			this.packetTabControl.SuspendLayout();
			this.packetTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.packetId)).BeginInit();
			this.structureTab.SuspendLayout();
			this.interfaceTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Working on:";
			// 
			// protocolName
			// 
			this.protocolName.AutoSize = true;
			this.protocolName.Location = new System.Drawing.Point(90, 9);
			this.protocolName.Name = "protocolName";
			this.protocolName.Size = new System.Drawing.Size(86, 15);
			this.protocolName.TabIndex = 1;
			this.protocolName.Text = "%PROTOCOL%";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 27);
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
			this.splitContainer1.Size = new System.Drawing.Size(1368, 596);
			this.splitContainer1.SplitterDistance = 362;
			this.splitContainer1.TabIndex = 2;
			// 
			// addNewButton
			// 
			this.addNewButton.Location = new System.Drawing.Point(274, 568);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(75, 23);
			this.addNewButton.TabIndex = 5;
			this.addNewButton.Text = "New";
			this.addNewButton.UseVisualStyleBackColor = true;
			// 
			// addNewTextBox
			// 
			this.addNewTextBox.Location = new System.Drawing.Point(7, 568);
			this.addNewTextBox.Name = "addNewTextBox";
			this.addNewTextBox.Size = new System.Drawing.Size(261, 23);
			this.addNewTextBox.TabIndex = 4;
			// 
			// structuresTab
			// 
			this.structuresTab.Controls.Add(this.incomingPacketsTab);
			this.structuresTab.Controls.Add(this.outgoingPacketsTab);
			this.structuresTab.Controls.Add(this.tabPage3);
			this.structuresTab.Controls.Add(this.interfacesTab);
			this.structuresTab.Location = new System.Drawing.Point(3, 3);
			this.structuresTab.Name = "structuresTab";
			this.structuresTab.SelectedIndex = 0;
			this.structuresTab.Size = new System.Drawing.Size(356, 563);
			this.structuresTab.TabIndex = 3;
			// 
			// incomingPacketsTab
			// 
			this.incomingPacketsTab.Controls.Add(this.incomingPacketList);
			this.incomingPacketsTab.Location = new System.Drawing.Point(4, 24);
			this.incomingPacketsTab.Name = "incomingPacketsTab";
			this.incomingPacketsTab.Padding = new System.Windows.Forms.Padding(3);
			this.incomingPacketsTab.Size = new System.Drawing.Size(348, 535);
			this.incomingPacketsTab.TabIndex = 0;
			this.incomingPacketsTab.Text = "Incoming";
			this.incomingPacketsTab.UseVisualStyleBackColor = true;
			// 
			// incomingPacketList
			// 
			this.incomingPacketList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.incomingPacket});
			this.incomingPacketList.Location = new System.Drawing.Point(6, 6);
			this.incomingPacketList.Name = "incomingPacketList";
			this.incomingPacketList.Size = new System.Drawing.Size(336, 523);
			this.incomingPacketList.TabIndex = 0;
			this.incomingPacketList.UseCompatibleStateImageBehavior = false;
			this.incomingPacketList.View = System.Windows.Forms.View.Details;
			this.incomingPacketList.SelectedIndexChanged += new System.EventHandler(this.SelectIncomingPacket);
			// 
			// incomingPacket
			// 
			this.incomingPacket.Text = "Packet";
			this.incomingPacket.Width = 332;
			// 
			// outgoingPacketsTab
			// 
			this.outgoingPacketsTab.Controls.Add(this.outgoingPacketsList);
			this.outgoingPacketsTab.Location = new System.Drawing.Point(4, 24);
			this.outgoingPacketsTab.Name = "outgoingPacketsTab";
			this.outgoingPacketsTab.Padding = new System.Windows.Forms.Padding(3);
			this.outgoingPacketsTab.Size = new System.Drawing.Size(348, 535);
			this.outgoingPacketsTab.TabIndex = 1;
			this.outgoingPacketsTab.Text = "Outgoing";
			this.outgoingPacketsTab.UseVisualStyleBackColor = true;
			// 
			// outgoingPacketsList
			// 
			this.outgoingPacketsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.outgoingPacket});
			this.outgoingPacketsList.Location = new System.Drawing.Point(6, 6);
			this.outgoingPacketsList.Name = "outgoingPacketsList";
			this.outgoingPacketsList.Size = new System.Drawing.Size(336, 523);
			this.outgoingPacketsList.TabIndex = 0;
			this.outgoingPacketsList.UseCompatibleStateImageBehavior = false;
			this.outgoingPacketsList.View = System.Windows.Forms.View.Details;
			this.outgoingPacketsList.SelectedIndexChanged += new System.EventHandler(this.SelectOutgoingPacket);
			// 
			// outgoingPacket
			// 
			this.outgoingPacket.Text = "Packet";
			this.outgoingPacket.Width = 332;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.structuresList);
			this.tabPage3.Location = new System.Drawing.Point(4, 24);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(348, 535);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Structures";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// structuresList
			// 
			this.structuresList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.structureColumn});
			this.structuresList.Location = new System.Drawing.Point(6, 6);
			this.structuresList.Name = "structuresList";
			this.structuresList.Size = new System.Drawing.Size(336, 523);
			this.structuresList.TabIndex = 0;
			this.structuresList.UseCompatibleStateImageBehavior = false;
			this.structuresList.View = System.Windows.Forms.View.Details;
			this.structuresList.SelectedIndexChanged += new System.EventHandler(this.SelectStructure);
			// 
			// structureColumn
			// 
			this.structureColumn.Text = "Structure";
			this.structureColumn.Width = 332;
			// 
			// interfacesTab
			// 
			this.interfacesTab.Controls.Add(this.interfacesList);
			this.interfacesTab.Location = new System.Drawing.Point(4, 24);
			this.interfacesTab.Name = "interfacesTab";
			this.interfacesTab.Padding = new System.Windows.Forms.Padding(3);
			this.interfacesTab.Size = new System.Drawing.Size(348, 535);
			this.interfacesTab.TabIndex = 3;
			this.interfacesTab.Text = "Interfaces";
			this.interfacesTab.UseVisualStyleBackColor = true;
			// 
			// interfacesList
			// 
			this.interfacesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.interfacesColumn});
			this.interfacesList.Location = new System.Drawing.Point(6, 6);
			this.interfacesList.Name = "interfacesList";
			this.interfacesList.Size = new System.Drawing.Size(336, 523);
			this.interfacesList.TabIndex = 0;
			this.interfacesList.UseCompatibleStateImageBehavior = false;
			this.interfacesList.View = System.Windows.Forms.View.Details;
			this.interfacesList.SelectedIndexChanged += new System.EventHandler(this.SelectInterface);
			// 
			// interfacesColumn
			// 
			this.interfacesColumn.Text = "Interfaces";
			this.interfacesColumn.Width = 332;
			// 
			// packetTabControl
			// 
			this.packetTabControl.Controls.Add(this.emptyTab);
			this.packetTabControl.Controls.Add(this.packetTab);
			this.packetTabControl.Controls.Add(this.structureTab);
			this.packetTabControl.Controls.Add(this.interfaceTab);
			this.packetTabControl.Location = new System.Drawing.Point(3, 3);
			this.packetTabControl.Name = "packetTabControl";
			this.packetTabControl.SelectedIndex = 0;
			this.packetTabControl.Size = new System.Drawing.Size(996, 588);
			this.packetTabControl.TabIndex = 0;
			// 
			// packetTab
			// 
			this.packetTab.Controls.Add(this.addPacketConditional);
			this.packetTab.Controls.Add(this.addPacketConstant);
			this.packetTab.Controls.Add(this.addPacketField);
			this.packetTab.Controls.Add(this.packetData);
			this.packetTab.Controls.Add(this.label2);
			this.packetTab.Controls.Add(this.packetId);
			this.packetTab.Location = new System.Drawing.Point(4, 24);
			this.packetTab.Name = "packetTab";
			this.packetTab.Padding = new System.Windows.Forms.Padding(3);
			this.packetTab.Size = new System.Drawing.Size(988, 560);
			this.packetTab.TabIndex = 0;
			this.packetTab.Text = "Packet";
			this.packetTab.UseVisualStyleBackColor = true;
			// 
			// addPacketConditional
			// 
			this.addPacketConditional.Location = new System.Drawing.Point(185, 531);
			this.addPacketConditional.Name = "addPacketConditional";
			this.addPacketConditional.Size = new System.Drawing.Size(102, 23);
			this.addPacketConditional.TabIndex = 5;
			this.addPacketConditional.Text = "Add Conditional";
			this.addPacketConditional.UseVisualStyleBackColor = true;
			this.addPacketConditional.Click += new System.EventHandler(this.AddPacketConditional);
			// 
			// addPacketConstant
			// 
			this.addPacketConstant.Location = new System.Drawing.Point(87, 531);
			this.addPacketConstant.Name = "addPacketConstant";
			this.addPacketConstant.Size = new System.Drawing.Size(92, 23);
			this.addPacketConstant.TabIndex = 4;
			this.addPacketConstant.Text = "Add Constant";
			this.addPacketConstant.UseVisualStyleBackColor = true;
			this.addPacketConstant.Click += new System.EventHandler(this.AddPacketConstant);
			// 
			// addPacketField
			// 
			this.addPacketField.Location = new System.Drawing.Point(6, 531);
			this.addPacketField.Name = "addPacketField";
			this.addPacketField.Size = new System.Drawing.Size(75, 23);
			this.addPacketField.TabIndex = 3;
			this.addPacketField.Text = "Add Field";
			this.addPacketField.UseVisualStyleBackColor = true;
			this.addPacketField.Click += new System.EventHandler(this.AddPacketField);
			// 
			// packetData
			// 
			this.packetData.AutoScroll = true;
			this.packetData.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.packetData.Location = new System.Drawing.Point(6, 35);
			this.packetData.Name = "packetData";
			this.packetData.Size = new System.Drawing.Size(976, 494);
			this.packetData.TabIndex = 2;
			this.packetData.WrapContents = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Packet ID:";
			// 
			// packetId
			// 
			this.packetId.Location = new System.Drawing.Point(71, 6);
			this.packetId.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.packetId.Name = "packetId";
			this.packetId.Size = new System.Drawing.Size(120, 23);
			this.packetId.TabIndex = 0;
			// 
			// structureTab
			// 
			this.structureTab.Controls.Add(this.addStructureConditional);
			this.structureTab.Controls.Add(this.addStructureConstant);
			this.structureTab.Controls.Add(this.addStructureField);
			this.structureTab.Controls.Add(this.structureData);
			this.structureTab.Location = new System.Drawing.Point(4, 24);
			this.structureTab.Name = "structureTab";
			this.structureTab.Padding = new System.Windows.Forms.Padding(3);
			this.structureTab.Size = new System.Drawing.Size(988, 560);
			this.structureTab.TabIndex = 1;
			this.structureTab.Text = "Structure";
			this.structureTab.UseVisualStyleBackColor = true;
			// 
			// addStructureConditional
			// 
			this.addStructureConditional.Location = new System.Drawing.Point(187, 534);
			this.addStructureConditional.Name = "addStructureConditional";
			this.addStructureConditional.Size = new System.Drawing.Size(102, 23);
			this.addStructureConditional.TabIndex = 3;
			this.addStructureConditional.Text = "Add Conditional";
			this.addStructureConditional.UseVisualStyleBackColor = true;
			this.addStructureConditional.Click += new System.EventHandler(this.AddStructureConditional);
			// 
			// addStructureConstant
			// 
			this.addStructureConstant.Location = new System.Drawing.Point(84, 534);
			this.addStructureConstant.Name = "addStructureConstant";
			this.addStructureConstant.Size = new System.Drawing.Size(97, 23);
			this.addStructureConstant.TabIndex = 2;
			this.addStructureConstant.Text = "Add Constant";
			this.addStructureConstant.UseVisualStyleBackColor = true;
			this.addStructureConstant.Click += new System.EventHandler(this.AddStructureConstant);
			// 
			// addStructureField
			// 
			this.addStructureField.Location = new System.Drawing.Point(3, 534);
			this.addStructureField.Name = "addStructureField";
			this.addStructureField.Size = new System.Drawing.Size(75, 23);
			this.addStructureField.TabIndex = 1;
			this.addStructureField.Text = "Add Field";
			this.addStructureField.UseVisualStyleBackColor = true;
			this.addStructureField.Click += new System.EventHandler(this.AddStructureField);
			// 
			// structureData
			// 
			this.structureData.AutoScroll = true;
			this.structureData.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.structureData.Location = new System.Drawing.Point(6, 6);
			this.structureData.Name = "structureData";
			this.structureData.Size = new System.Drawing.Size(976, 523);
			this.structureData.TabIndex = 0;
			this.structureData.WrapContents = false;
			// 
			// interfaceTab
			// 
			this.interfaceTab.Controls.Add(this.addInterface);
			this.interfaceTab.Controls.Add(this.interfaceData);
			this.interfaceTab.Location = new System.Drawing.Point(4, 24);
			this.interfaceTab.Name = "interfaceTab";
			this.interfaceTab.Padding = new System.Windows.Forms.Padding(3);
			this.interfaceTab.Size = new System.Drawing.Size(988, 560);
			this.interfaceTab.TabIndex = 2;
			this.interfaceTab.Text = "Interface";
			this.interfaceTab.UseVisualStyleBackColor = true;
			// 
			// addInterface
			// 
			this.addInterface.Location = new System.Drawing.Point(3, 534);
			this.addInterface.Name = "addInterface";
			this.addInterface.Size = new System.Drawing.Size(75, 23);
			this.addInterface.TabIndex = 1;
			this.addInterface.Text = "Add";
			this.addInterface.UseVisualStyleBackColor = true;
			this.addInterface.Click += new System.EventHandler(this.AddInterface);
			// 
			// interfaceData
			// 
			this.interfaceData.AutoScroll = true;
			this.interfaceData.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.interfaceData.Location = new System.Drawing.Point(6, 6);
			this.interfaceData.Name = "interfaceData";
			this.interfaceData.Size = new System.Drawing.Size(976, 522);
			this.interfaceData.TabIndex = 0;
			this.interfaceData.WrapContents = false;
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(385, 1);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(995, 23);
			this.save.TabIndex = 3;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.Save);
			// 
			// emptyTab
			// 
			this.emptyTab.Location = new System.Drawing.Point(4, 24);
			this.emptyTab.Name = "emptyTab";
			this.emptyTab.Padding = new System.Windows.Forms.Padding(3);
			this.emptyTab.Size = new System.Drawing.Size(988, 560);
			this.emptyTab.TabIndex = 3;
			this.emptyTab.Text = "Empty";
			this.emptyTab.UseVisualStyleBackColor = true;
			// 
			// ProtocolOverviewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1392, 635);
			this.Controls.Add(this.save);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.protocolName);
			this.Controls.Add(this.label1);
			this.Name = "ProtocolOverviewForm";
			this.Text = "Protocol";
			this.Load += new System.EventHandler(this.ProtocolOverviewFormLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.structuresTab.ResumeLayout(false);
			this.incomingPacketsTab.ResumeLayout(false);
			this.outgoingPacketsTab.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.interfacesTab.ResumeLayout(false);
			this.packetTabControl.ResumeLayout(false);
			this.packetTab.ResumeLayout(false);
			this.packetTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.packetId)).EndInit();
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
	private TabPage tabPage3;
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
	private NumericUpDown packetId;
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
}
