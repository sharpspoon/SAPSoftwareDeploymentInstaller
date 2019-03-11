namespace SAPSoftwareDeploymentInstaller
{
    partial class SAPSoftwareDeploymentInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAPSoftwareDeploymentInstaller));
            this.installButton = new System.Windows.Forms.Button();
            this.cmdBuilderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.installLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Downloaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectProgramGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sapLinkLabel = new System.Windows.Forms.LinkLabel();
            this.virtualBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.nPlusPlusCheckBox = new System.Windows.Forms.CheckBox();
            this.sevenZipCheckBox = new System.Windows.Forms.CheckBox();
            this.iReport451CheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.selectProgramGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.installButton.BackColor = System.Drawing.Color.Honeydew;
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.Location = new System.Drawing.Point(291, 596);
            this.installButton.Margin = new System.Windows.Forms.Padding(4);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(85, 126);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Install SAP Package";
            this.installButton.UseVisualStyleBackColor = false;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // cmdBuilderRichTextBox
            // 
            this.cmdBuilderRichTextBox.Location = new System.Drawing.Point(676, 478);
            this.cmdBuilderRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBuilderRichTextBox.Name = "cmdBuilderRichTextBox";
            this.cmdBuilderRichTextBox.Size = new System.Drawing.Size(132, 13);
            this.cmdBuilderRichTextBox.TabIndex = 2;
            this.cmdBuilderRichTextBox.Text = "";
            this.cmdBuilderRichTextBox.Visible = false;
            // 
            // installLogRichTextBox
            // 
            this.installLogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installLogRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.installLogRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.installLogRichTextBox.Name = "installLogRichTextBox";
            this.installLogRichTextBox.ReadOnly = true;
            this.installLogRichTextBox.Size = new System.Drawing.Size(543, 467);
            this.installLogRichTextBox.TabIndex = 3;
            this.installLogRichTextBox.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Program,
            this.Downloaded,
            this.Installed});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 467);
            this.dataGridView1.TabIndex = 6;
            // 
            // Program
            // 
            this.Program.Frozen = true;
            this.Program.HeaderText = "Program";
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            // 
            // Downloaded
            // 
            this.Downloaded.Frozen = true;
            this.Downloaded.HeaderText = "Downloaded";
            this.Downloaded.Name = "Downloaded";
            this.Downloaded.ReadOnly = true;
            // 
            // Installed
            // 
            this.Installed.Frozen = true;
            this.Installed.HeaderText = "Installed";
            this.Installed.Name = "Installed";
            this.Installed.ReadOnly = true;
            // 
            // selectProgramGroupBox
            // 
            this.selectProgramGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectProgramGroupBox.Controls.Add(this.virtualBoxCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.nPlusPlusCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.sevenZipCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.iReport451CheckBox);
            this.selectProgramGroupBox.Location = new System.Drawing.Point(16, 508);
            this.selectProgramGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectProgramGroupBox.Name = "selectProgramGroupBox";
            this.selectProgramGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.selectProgramGroupBox.Size = new System.Drawing.Size(267, 214);
            this.selectProgramGroupBox.TabIndex = 7;
            this.selectProgramGroupBox.TabStop = false;
            this.selectProgramGroupBox.Text = "Select Program";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 33);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.installLogRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1001, 467);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1033, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // sapLinkLabel
            // 
            this.sapLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sapLinkLabel.AutoSize = true;
            this.sapLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sapLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.sapLinkLabel.Location = new System.Drawing.Point(937, 702);
            this.sapLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sapLinkLabel.Name = "sapLinkLabel";
            this.sapLinkLabel.Size = new System.Drawing.Size(72, 20);
            this.sapLinkLabel.TabIndex = 7;
            this.sapLinkLabel.TabStop = true;
            this.sapLinkLabel.Text = "sap.com";
            this.sapLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sapLinkLabel_LinkClicked);
            // 
            // virtualBoxCheckBox
            // 
            this.virtualBoxCheckBox.AutoSize = true;
            this.virtualBoxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virtualBoxCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.virtualbox;
            this.virtualBoxCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.virtualBoxCheckBox.Location = new System.Drawing.Point(8, 116);
            this.virtualBoxCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.virtualBoxCheckBox.Name = "virtualBoxCheckBox";
            this.virtualBoxCheckBox.Size = new System.Drawing.Size(148, 24);
            this.virtualBoxCheckBox.TabIndex = 6;
            this.virtualBoxCheckBox.Text = "     VirtualBox";
            this.virtualBoxCheckBox.UseVisualStyleBackColor = true;
            // 
            // nPlusPlusCheckBox
            // 
            this.nPlusPlusCheckBox.AutoSize = true;
            this.nPlusPlusCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPlusPlusCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.n__;
            this.nPlusPlusCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nPlusPlusCheckBox.Location = new System.Drawing.Point(8, 84);
            this.nPlusPlusCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.nPlusPlusCheckBox.Name = "nPlusPlusCheckBox";
            this.nPlusPlusCheckBox.Size = new System.Drawing.Size(152, 24);
            this.nPlusPlusCheckBox.TabIndex = 5;
            this.nPlusPlusCheckBox.Text = "     Notepad++";
            this.nPlusPlusCheckBox.UseVisualStyleBackColor = true;
            // 
            // sevenZipCheckBox
            // 
            this.sevenZipCheckBox.AutoSize = true;
            this.sevenZipCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenZipCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources._7zip;
            this.sevenZipCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sevenZipCheckBox.Location = new System.Drawing.Point(8, 52);
            this.sevenZipCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.sevenZipCheckBox.Name = "sevenZipCheckBox";
            this.sevenZipCheckBox.Size = new System.Drawing.Size(96, 24);
            this.sevenZipCheckBox.TabIndex = 1;
            this.sevenZipCheckBox.Text = "     7zip";
            this.sevenZipCheckBox.UseVisualStyleBackColor = true;
            // 
            // iReport451CheckBox
            // 
            this.iReport451CheckBox.AutoSize = true;
            this.iReport451CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iReport451CheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.ireport1;
            this.iReport451CheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iReport451CheckBox.Location = new System.Drawing.Point(8, 23);
            this.iReport451CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.iReport451CheckBox.Name = "iReport451CheckBox";
            this.iReport451CheckBox.Size = new System.Drawing.Size(168, 24);
            this.iReport451CheckBox.TabIndex = 4;
            this.iReport451CheckBox.Text = "     iReport 4.5.1";
            this.iReport451CheckBox.UseVisualStyleBackColor = true;
            // 
            // SAPSoftwareDeploymentInstaller
            // 
            this.AcceptButton = this.installButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 732);
            this.Controls.Add(this.sapLinkLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.selectProgramGroupBox);
            this.Controls.Add(this.cmdBuilderRichTextBox);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SAPSoftwareDeploymentInstaller";
            this.Text = "SAP Software Deployment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.selectProgramGroupBox.ResumeLayout(false);
            this.selectProgramGroupBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.CheckBox sevenZipCheckBox;
        private System.Windows.Forms.RichTextBox cmdBuilderRichTextBox;
        private System.Windows.Forms.RichTextBox installLogRichTextBox;
        private System.Windows.Forms.CheckBox iReport451CheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox selectProgramGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Downloaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installed;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.LinkLabel sapLinkLabel;
        private System.Windows.Forms.CheckBox nPlusPlusCheckBox;
        private System.Windows.Forms.CheckBox virtualBoxCheckBox;
    }
}

