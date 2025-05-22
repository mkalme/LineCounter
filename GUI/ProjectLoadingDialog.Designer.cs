namespace GUI {
    partial class ProjectLoadingDialog {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectLoadingDialog));
            this.PathContainer = new System.Windows.Forms.Panel();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.ProjectsFolderLabel = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar = new System.Windows.Forms.Panel();
            this.ProgressPanel = new System.Windows.Forms.Panel();
            this.PathContainer.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathContainer
            // 
            this.PathContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PathContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathContainer.Controls.Add(this.PathTextBox);
            this.PathContainer.Location = new System.Drawing.Point(92, 28);
            this.PathContainer.Name = "PathContainer";
            this.PathContainer.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.PathContainer.Size = new System.Drawing.Size(327, 23);
            this.PathContainer.TabIndex = 9;
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PathTextBox.Location = new System.Drawing.Point(1, 3);
            this.PathTextBox.Multiline = true;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(324, 18);
            this.PathTextBox.TabIndex = 2;
            // 
            // ProjectsFolderLabel
            // 
            this.ProjectsFolderLabel.AutoSize = true;
            this.ProjectsFolderLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProjectsFolderLabel.Location = new System.Drawing.Point(8, 11);
            this.ProjectsFolderLabel.Name = "ProjectsFolderLabel";
            this.ProjectsFolderLabel.Size = new System.Drawing.Size(74, 13);
            this.ProjectsFolderLabel.TabIndex = 8;
            this.ProjectsFolderLabel.Text = "Projects folder";
            // 
            // SelectButton
            // 
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectButton.Location = new System.Drawing.Point(11, 99);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(70, 23);
            this.SelectButton.TabIndex = 10;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Image = global::GUI.Properties.Resources.BrowseIcon;
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.Location = new System.Drawing.Point(11, 28);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(70, 23);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(171)))), ((int)(((byte)(105)))));
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProgressBar.Location = new System.Drawing.Point(0, 0);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(0, 5);
            this.ProgressBar.TabIndex = 11;
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ProgressPanel.Controls.Add(this.ProgressBar);
            this.ProgressPanel.Location = new System.Drawing.Point(0, 133);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.Size = new System.Drawing.Size(431, 5);
            this.ProgressPanel.TabIndex = 12;
            // 
            // ProjectLoadingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(431, 133);
            this.Controls.Add(this.ProgressPanel);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.PathContainer);
            this.Controls.Add(this.ProjectsFolderLabel);
            this.Controls.Add(this.BrowseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectLoadingDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Browse for projects";
            this.Shown += new System.EventHandler(this.ProjectLoadingDialog_Shown);
            this.PathContainer.ResumeLayout(false);
            this.PathContainer.PerformLayout();
            this.ProgressPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PathContainer;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label ProjectsFolderLabel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Panel ProgressBar;
        private System.Windows.Forms.Panel ProgressPanel;
    }
}