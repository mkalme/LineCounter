namespace GUI {
    partial class ProjectExplorer {
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
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectExplorer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContainerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ToolBarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.PathContainer = new System.Windows.Forms.Panel();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.ExplorerGrid = new System.Windows.Forms.DataGridView();
            this.IndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new GUI.TextAndImageColumn();
            this.PathCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExplorerGridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProgramStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EndPanel = new System.Windows.Forms.Panel();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.CopyClipboardButton = new System.Windows.Forms.Button();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAndImageColumn1 = new GUI.TextAndImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContainerPanel.SuspendLayout();
            this.ToolBarTableLayoutPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.PathContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerGrid)).BeginInit();
            this.ExplorerGridMenuStrip.SuspendLayout();
            this.EndPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.ColumnCount = 1;
            this.ContainerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContainerPanel.Controls.Add(this.ToolBarTableLayoutPanel, 0, 0);
            this.ContainerPanel.Controls.Add(this.ExplorerGrid, 0, 1);
            this.ContainerPanel.Controls.Add(this.EndPanel, 0, 2);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContainerPanel.RowCount = 3;
            this.ContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContainerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.ContainerPanel.Size = new System.Drawing.Size(853, 473);
            this.ContainerPanel.TabIndex = 0;
            // 
            // ToolBarTableLayoutPanel
            // 
            this.ToolBarTableLayoutPanel.AutoSize = true;
            this.ToolBarTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToolBarTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolBarTableLayoutPanel.ColumnCount = 2;
            this.ToolBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ToolBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolBarTableLayoutPanel.Controls.Add(this.ButtonPanel, 0, 0);
            this.ToolBarTableLayoutPanel.Controls.Add(this.PathContainer, 1, 0);
            this.ToolBarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarTableLayoutPanel.Location = new System.Drawing.Point(5, 1);
            this.ToolBarTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.ToolBarTableLayoutPanel.Name = "ToolBarTableLayoutPanel";
            this.ToolBarTableLayoutPanel.RowCount = 1;
            this.ToolBarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolBarTableLayoutPanel.Size = new System.Drawing.Size(843, 30);
            this.ToolBarTableLayoutPanel.TabIndex = 2;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonPanel.Controls.Add(this.ForwardButton);
            this.ButtonPanel.Controls.Add(this.BackButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(55, 30);
            this.ButtonPanel.TabIndex = 2;
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = global::GUI.Properties.Resources.RightArrow;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ForwardButton.Location = new System.Drawing.Point(26, 4);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(23, 23);
            this.ForwardButton.TabIndex = 4;
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::GUI.Properties.Resources.LeftArrow;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackButton.Location = new System.Drawing.Point(1, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PathContainer
            // 
            this.PathContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathContainer.Controls.Add(this.PathTextBox);
            this.PathContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathContainer.Location = new System.Drawing.Point(58, 4);
            this.PathContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PathContainer.Name = "PathContainer";
            this.PathContainer.Padding = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.PathContainer.Size = new System.Drawing.Size(782, 22);
            this.PathContainer.TabIndex = 3;
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(4, 2);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(776, 16);
            this.PathTextBox.TabIndex = 4;
            // 
            // ExplorerGrid
            // 
            this.ExplorerGrid.AllowUserToAddRows = false;
            this.ExplorerGrid.AllowUserToDeleteRows = false;
            this.ExplorerGrid.AllowUserToOrderColumns = true;
            this.ExplorerGrid.AllowUserToResizeRows = false;
            this.ExplorerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExplorerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExplorerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ExplorerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExplorerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExplorerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExplorerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexCol,
            this.NameCol,
            this.PathCol,
            this.LinesCol,
            this.TypeCol,
            this.CreationDateCol});
            this.ExplorerGrid.ContextMenuStrip = this.ExplorerGridMenuStrip;
            this.ExplorerGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExplorerGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.ExplorerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerGrid.EnableHeadersVisualStyles = false;
            this.ExplorerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ExplorerGrid.Location = new System.Drawing.Point(8, 32);
            this.ExplorerGrid.Margin = new System.Windows.Forms.Padding(6, 1, 6, 0);
            this.ExplorerGrid.MultiSelect = false;
            this.ExplorerGrid.Name = "ExplorerGrid";
            this.ExplorerGrid.ReadOnly = true;
            this.ExplorerGrid.RowHeadersVisible = false;
            this.ExplorerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExplorerGrid.Size = new System.Drawing.Size(837, 415);
            this.ExplorerGrid.TabIndex = 0;
            this.ExplorerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellDoubleClick);
            this.ExplorerGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellMouseEnter);
            this.ExplorerGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellMouseLeave);
            this.ExplorerGrid.SelectionChanged += new System.EventHandler(this.ExplorerGrid_SelectionChanged);
            this.ExplorerGrid.Sorted += new System.EventHandler(this.ExplorerGrid_Sorted);
            this.ExplorerGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExplorerGrid_MouseDown);
            // 
            // IndexCol
            // 
            this.IndexCol.HeaderText = "";
            this.IndexCol.Name = "IndexCol";
            this.IndexCol.ReadOnly = true;
            this.IndexCol.Visible = false;
            // 
            // NameCol
            // 
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameCol.HeaderText = "Name";
            this.NameCol.Image = null;
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameCol.Width = 180;
            // 
            // PathCol
            // 
            this.PathCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PathCol.HeaderText = "Path";
            this.PathCol.Name = "PathCol";
            this.PathCol.ReadOnly = true;
            // 
            // LinesCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.LinesCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.LinesCol.HeaderText = "Lines of code";
            this.LinesCol.Name = "LinesCol";
            this.LinesCol.ReadOnly = true;
            this.LinesCol.Width = 105;
            // 
            // TypeCol
            // 
            this.TypeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TypeCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            this.TypeCol.Width = 120;
            // 
            // CreationDateCol
            // 
            this.CreationDateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.CreationDateCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.CreationDateCol.HeaderText = "Creation date";
            this.CreationDateCol.Name = "CreationDateCol";
            this.CreationDateCol.ReadOnly = true;
            this.CreationDateCol.Width = 105;
            // 
            // ExplorerGridMenuStrip
            // 
            this.ExplorerGridMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.ExplorerGridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileStripItem,
            this.OpenProgramStripItem});
            this.ExplorerGridMenuStrip.Name = "ExplorerGridMenuStrip";
            this.ExplorerGridMenuStrip.Size = new System.Drawing.Size(184, 48);
            this.ExplorerGridMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ExplorerGridMenuStrip_Opening);
            // 
            // OpenFileStripItem
            // 
            this.OpenFileStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OpenFileStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenFileStripItem.Image = global::GUI.Properties.Resources.FileExplorer;
            this.OpenFileStripItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenFileStripItem.Name = "OpenFileStripItem";
            this.OpenFileStripItem.Size = new System.Drawing.Size(183, 22);
            this.OpenFileStripItem.Text = "Open in File Explorer";
            this.OpenFileStripItem.Click += new System.EventHandler(this.OpenFileStripItem_Click);
            // 
            // OpenProgramStripItem
            // 
            this.OpenProgramStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OpenProgramStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OpenProgramStripItem.Image = global::GUI.Properties.Resources.Application;
            this.OpenProgramStripItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OpenProgramStripItem.Name = "OpenProgramStripItem";
            this.OpenProgramStripItem.Size = new System.Drawing.Size(183, 22);
            this.OpenProgramStripItem.Text = "Open in program";
            this.OpenProgramStripItem.Click += new System.EventHandler(this.OpenProgramStripItem_Click);
            // 
            // EndPanel
            // 
            this.EndPanel.Controls.Add(this.BrowseButton);
            this.EndPanel.Controls.Add(this.CopyClipboardButton);
            this.EndPanel.Controls.Add(this.InformationLabel);
            this.EndPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndPanel.Location = new System.Drawing.Point(2, 447);
            this.EndPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EndPanel.Name = "EndPanel";
            this.EndPanel.Size = new System.Drawing.Size(849, 26);
            this.EndPanel.TabIndex = 3;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("BrowseButton.Image")));
            this.BrowseButton.Location = new System.Drawing.Point(748, 1);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(23, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // CopyClipboardButton
            // 
            this.CopyClipboardButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CopyClipboardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CopyClipboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CopyClipboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CopyClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyClipboardButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CopyClipboardButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyClipboardButton.Location = new System.Drawing.Point(778, 1);
            this.CopyClipboardButton.Name = "CopyClipboardButton";
            this.CopyClipboardButton.Size = new System.Drawing.Size(65, 23);
            this.CopyClipboardButton.TabIndex = 1;
            this.CopyClipboardButton.Text = "Copy";
            this.CopyClipboardButton.UseVisualStyleBackColor = true;
            this.CopyClipboardButton.Click += new System.EventHandler(this.CopyClipboardButton_Click);
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.InformationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InformationLabel.Location = new System.Drawing.Point(5, 6);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(35, 15);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.Text = "Label";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // textAndImageColumn1
            // 
            this.textAndImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.textAndImageColumn1.HeaderText = "Name";
            this.textAndImageColumn1.Image = null;
            this.textAndImageColumn1.Name = "textAndImageColumn1";
            this.textAndImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.textAndImageColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Path";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "Lines of code";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 105;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn6.HeaderText = "Creation date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 105;
            // 
            // ProjectExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.ContainerPanel);
            this.Name = "ProjectExplorer";
            this.Size = new System.Drawing.Size(853, 473);
            this.Load += new System.EventHandler(this.ProjectExplorer_Load);
            this.ContainerPanel.ResumeLayout(false);
            this.ContainerPanel.PerformLayout();
            this.ToolBarTableLayoutPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.PathContainer.ResumeLayout(false);
            this.PathContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerGrid)).EndInit();
            this.ExplorerGridMenuStrip.ResumeLayout(false);
            this.EndPanel.ResumeLayout(false);
            this.EndPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContainerPanel;
        private System.Windows.Forms.DataGridView ExplorerGrid;
        private System.Windows.Forms.TableLayoutPanel ToolBarTableLayoutPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel PathContainer;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.ContextMenuStrip ExplorerGridMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenFileStripItem;
        private System.Windows.Forms.ToolStripMenuItem OpenProgramStripItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel EndPanel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Button CopyClipboardButton;
        private System.Windows.Forms.Button BrowseButton;
        private TextAndImageColumn textAndImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexCol;
        private TextAndImageColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDateCol;
    }
}
