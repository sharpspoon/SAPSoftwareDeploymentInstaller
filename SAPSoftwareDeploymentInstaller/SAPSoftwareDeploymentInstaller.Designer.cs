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
            this.installLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Downloaded = new System.Windows.Forms.DataGridViewImageColumn();
            this.selectProgramGroupBox = new System.Windows.Forms.GroupBox();
            this.winSCPCheckBox = new System.Windows.Forms.CheckBox();
            this.puttyCheckBox = new System.Windows.Forms.CheckBox();
            this.filezillaCheckBox = new System.Windows.Forms.CheckBox();
            this.greenshotCheckBox = new System.Windows.Forms.CheckBox();
            this.jaspersoftStudioCheckBox = new System.Windows.Forms.CheckBox();
            this.virtualBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.nPlusPlusCheckBox = new System.Windows.Forms.CheckBox();
            this.sevenZipCheckBox = new System.Windows.Forms.CheckBox();
            this.iReport451CheckBox = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sapLinkLabel = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.versionLabel = new System.Windows.Forms.Label();
            this.checkAllPictureBox = new System.Windows.Forms.PictureBox();
            this.installPictureBox = new System.Windows.Forms.PictureBox();
            this.uncheckAllPictureBox = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.selectProgramGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheckAllPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // installLogRichTextBox
            // 
            this.installLogRichTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.installLogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installLogRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.installLogRichTextBox.Name = "installLogRichTextBox";
            this.installLogRichTextBox.ReadOnly = true;
            this.installLogRichTextBox.Size = new System.Drawing.Size(659, 368);
            this.installLogRichTextBox.TabIndex = 3;
            this.installLogRichTextBox.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Program,
            this.Downloaded});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(325, 368);
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
            this.Downloaded.HeaderText = "Status";
            this.Downloaded.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.Download;
            this.Downloaded.Name = "Downloaded";
            this.Downloaded.ReadOnly = true;
            this.Downloaded.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Downloaded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // selectProgramGroupBox
            // 
            this.selectProgramGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectProgramGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.selectProgramGroupBox.Controls.Add(this.checkBox27);
            this.selectProgramGroupBox.Controls.Add(this.checkBox26);
            this.selectProgramGroupBox.Controls.Add(this.checkBox25);
            this.selectProgramGroupBox.Controls.Add(this.checkBox24);
            this.selectProgramGroupBox.Controls.Add(this.checkBox23);
            this.selectProgramGroupBox.Controls.Add(this.checkBox21);
            this.selectProgramGroupBox.Controls.Add(this.checkBox20);
            this.selectProgramGroupBox.Controls.Add(this.checkBox19);
            this.selectProgramGroupBox.Controls.Add(this.checkBox18);
            this.selectProgramGroupBox.Controls.Add(this.checkBox17);
            this.selectProgramGroupBox.Controls.Add(this.checkBox22);
            this.selectProgramGroupBox.Controls.Add(this.checkBox9);
            this.selectProgramGroupBox.Controls.Add(this.checkBox8);
            this.selectProgramGroupBox.Controls.Add(this.checkBox7);
            this.selectProgramGroupBox.Controls.Add(this.checkBox6);
            this.selectProgramGroupBox.Controls.Add(this.checkBox5);
            this.selectProgramGroupBox.Controls.Add(this.checkBox4);
            this.selectProgramGroupBox.Controls.Add(this.checkBox3);
            this.selectProgramGroupBox.Controls.Add(this.checkBox2);
            this.selectProgramGroupBox.Controls.Add(this.checkBox1);
            this.selectProgramGroupBox.Controls.Add(this.winSCPCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.puttyCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.filezillaCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.greenshotCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.jaspersoftStudioCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.virtualBoxCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.nPlusPlusCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.sevenZipCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.iReport451CheckBox);
            this.selectProgramGroupBox.Location = new System.Drawing.Point(13, 400);
            this.selectProgramGroupBox.Name = "selectProgramGroupBox";
            this.selectProgramGroupBox.Size = new System.Drawing.Size(988, 435);
            this.selectProgramGroupBox.TabIndex = 7;
            this.selectProgramGroupBox.TabStop = false;
            this.selectProgramGroupBox.Text = "Select Program";
            // 
            // winSCPCheckBox
            // 
            this.winSCPCheckBox.AutoSize = true;
            this.winSCPCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winSCPCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winSCPCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.winscp;
            this.winSCPCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.winSCPCheckBox.Location = new System.Drawing.Point(0, 258);
            this.winSCPCheckBox.Name = "winSCPCheckBox";
            this.winSCPCheckBox.Size = new System.Drawing.Size(149, 24);
            this.winSCPCheckBox.TabIndex = 11;
            this.winSCPCheckBox.Text = "         WinSCP                   ";
            this.winSCPCheckBox.UseVisualStyleBackColor = true;
            this.winSCPCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.winSCPCheckBox_MouseDown);
            this.winSCPCheckBox.MouseEnter += new System.EventHandler(this.winSCPCheckBox_MouseEnter);
            this.winSCPCheckBox.MouseLeave += new System.EventHandler(this.winSCPCheckBox_MouseLeave);
            this.winSCPCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.winSCPCheckBox_MouseUp);
            // 
            // puttyCheckBox
            // 
            this.puttyCheckBox.AutoSize = true;
            this.puttyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.puttyCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puttyCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.putty;
            this.puttyCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.puttyCheckBox.Location = new System.Drawing.Point(0, 228);
            this.puttyCheckBox.Name = "puttyCheckBox";
            this.puttyCheckBox.Size = new System.Drawing.Size(149, 24);
            this.puttyCheckBox.TabIndex = 10;
            this.puttyCheckBox.Text = "         PuTTY                      ";
            this.puttyCheckBox.UseVisualStyleBackColor = true;
            this.puttyCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.puttyCheckBox_MouseDown);
            this.puttyCheckBox.MouseEnter += new System.EventHandler(this.puttyCheckBox_MouseEnter);
            this.puttyCheckBox.MouseLeave += new System.EventHandler(this.puttyCheckBox_MouseLeave);
            this.puttyCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.puttyCheckBox_MouseUp);
            // 
            // filezillaCheckBox
            // 
            this.filezillaCheckBox.AutoSize = true;
            this.filezillaCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filezillaCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filezillaCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.filezilla;
            this.filezillaCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filezillaCheckBox.Location = new System.Drawing.Point(0, 198);
            this.filezillaCheckBox.Name = "filezillaCheckBox";
            this.filezillaCheckBox.Size = new System.Drawing.Size(150, 24);
            this.filezillaCheckBox.TabIndex = 9;
            this.filezillaCheckBox.Text = "         FileZilla                    ";
            this.filezillaCheckBox.UseVisualStyleBackColor = true;
            this.filezillaCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.filezillaCheckBox_MouseDown);
            this.filezillaCheckBox.MouseEnter += new System.EventHandler(this.filezillaCheckBox_MouseEnter);
            this.filezillaCheckBox.MouseLeave += new System.EventHandler(this.filezillaCheckBox_MouseLeave);
            this.filezillaCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.filezillaCheckBox_MouseUp);
            // 
            // greenshotCheckBox
            // 
            this.greenshotCheckBox.AutoSize = true;
            this.greenshotCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenshotCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenshotCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.greenshot;
            this.greenshotCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.greenshotCheckBox.Location = new System.Drawing.Point(0, 168);
            this.greenshotCheckBox.Name = "greenshotCheckBox";
            this.greenshotCheckBox.Size = new System.Drawing.Size(150, 24);
            this.greenshotCheckBox.TabIndex = 8;
            this.greenshotCheckBox.Text = "         Greenshot              ";
            this.greenshotCheckBox.UseVisualStyleBackColor = true;
            this.greenshotCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.greenshotCheckBox_MouseDown);
            this.greenshotCheckBox.MouseEnter += new System.EventHandler(this.greenshotCheckBox_MouseEnter);
            this.greenshotCheckBox.MouseLeave += new System.EventHandler(this.greenshotCheckBox_MouseLeave);
            this.greenshotCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.greenshotCheckBox_MouseUp);
            // 
            // jaspersoftStudioCheckBox
            // 
            this.jaspersoftStudioCheckBox.AutoSize = true;
            this.jaspersoftStudioCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jaspersoftStudioCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jaspersoftStudioCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.jaspersoftStudioCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jaspersoftStudioCheckBox.Location = new System.Drawing.Point(0, 48);
            this.jaspersoftStudioCheckBox.Name = "jaspersoftStudioCheckBox";
            this.jaspersoftStudioCheckBox.Size = new System.Drawing.Size(149, 24);
            this.jaspersoftStudioCheckBox.TabIndex = 7;
            this.jaspersoftStudioCheckBox.Text = "         JasperSoft Studio  ";
            this.jaspersoftStudioCheckBox.UseVisualStyleBackColor = true;
            this.jaspersoftStudioCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jaspersoftStudioCheckBox_MouseDown);
            this.jaspersoftStudioCheckBox.MouseEnter += new System.EventHandler(this.jaspersoftStudioCheckBox_MouseEnter);
            this.jaspersoftStudioCheckBox.MouseLeave += new System.EventHandler(this.jaspersoftStudioCheckBox_MouseLeave);
            this.jaspersoftStudioCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jaspersoftStudioCheckBox_MouseUp);
            // 
            // virtualBoxCheckBox
            // 
            this.virtualBoxCheckBox.AutoSize = true;
            this.virtualBoxCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.virtualBoxCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virtualBoxCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.virtualbox;
            this.virtualBoxCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.virtualBoxCheckBox.Location = new System.Drawing.Point(0, 108);
            this.virtualBoxCheckBox.Name = "virtualBoxCheckBox";
            this.virtualBoxCheckBox.Size = new System.Drawing.Size(149, 24);
            this.virtualBoxCheckBox.TabIndex = 6;
            this.virtualBoxCheckBox.Text = "         VirtualBox              ";
            this.virtualBoxCheckBox.UseVisualStyleBackColor = true;
            this.virtualBoxCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.virtualBoxCheckBox_MouseDown);
            this.virtualBoxCheckBox.MouseEnter += new System.EventHandler(this.virtualBoxCheckBox_MouseEnter);
            this.virtualBoxCheckBox.MouseLeave += new System.EventHandler(this.virtualBoxCheckBox_MouseLeave);
            this.virtualBoxCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.virtualBoxCheckBox_MouseUp);
            // 
            // nPlusPlusCheckBox
            // 
            this.nPlusPlusCheckBox.AutoSize = true;
            this.nPlusPlusCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nPlusPlusCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPlusPlusCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.npp;
            this.nPlusPlusCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nPlusPlusCheckBox.Location = new System.Drawing.Point(0, 78);
            this.nPlusPlusCheckBox.Name = "nPlusPlusCheckBox";
            this.nPlusPlusCheckBox.Size = new System.Drawing.Size(149, 24);
            this.nPlusPlusCheckBox.TabIndex = 5;
            this.nPlusPlusCheckBox.Text = "         Notepad++             ";
            this.nPlusPlusCheckBox.UseVisualStyleBackColor = true;
            this.nPlusPlusCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nPlusPlusCheckBox_MouseDown);
            this.nPlusPlusCheckBox.MouseEnter += new System.EventHandler(this.nPlusPlusCheckBox_MouseEnter);
            this.nPlusPlusCheckBox.MouseLeave += new System.EventHandler(this.nPlusPlusCheckBox_MouseLeave);
            this.nPlusPlusCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nPlusPlusCheckBox_MouseUp);
            // 
            // sevenZipCheckBox
            // 
            this.sevenZipCheckBox.AutoSize = true;
            this.sevenZipCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenZipCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenZipCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.sevenzip;
            this.sevenZipCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sevenZipCheckBox.Location = new System.Drawing.Point(0, 138);
            this.sevenZipCheckBox.Name = "sevenZipCheckBox";
            this.sevenZipCheckBox.Size = new System.Drawing.Size(150, 24);
            this.sevenZipCheckBox.TabIndex = 1;
            this.sevenZipCheckBox.Text = "         7zip                          ";
            this.sevenZipCheckBox.UseVisualStyleBackColor = true;
            this.sevenZipCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sevenZipCheckBox_MouseDown);
            this.sevenZipCheckBox.MouseEnter += new System.EventHandler(this.sevenZipCheckBox_MouseEnter);
            this.sevenZipCheckBox.MouseLeave += new System.EventHandler(this.sevenZipCheckBox_MouseLeave);
            this.sevenZipCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sevenZipCheckBox_MouseUp);
            // 
            // iReport451CheckBox
            // 
            this.iReport451CheckBox.AutoSize = true;
            this.iReport451CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iReport451CheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iReport451CheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.ireport1;
            this.iReport451CheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iReport451CheckBox.Location = new System.Drawing.Point(0, 18);
            this.iReport451CheckBox.Name = "iReport451CheckBox";
            this.iReport451CheckBox.Size = new System.Drawing.Size(148, 24);
            this.iReport451CheckBox.TabIndex = 4;
            this.iReport451CheckBox.Text = "         iReport 4.5.1         ";
            this.iReport451CheckBox.UseVisualStyleBackColor = true;
            this.iReport451CheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iReport451CheckBox_MouseDown);
            this.iReport451CheckBox.MouseEnter += new System.EventHandler(this.iReport451CheckBox_MouseEnter);
            this.iReport451CheckBox.MouseLeave += new System.EventHandler(this.iReport451CheckBox_MouseLeave);
            this.iReport451CheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iReport451CheckBox_MouseUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(13, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.installLogRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(988, 368);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // sapLinkLabel
            // 
            this.sapLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sapLinkLabel.AutoSize = true;
            this.sapLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.sapLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sapLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.sapLinkLabel.Location = new System.Drawing.Point(941, 841);
            this.sapLinkLabel.Name = "sapLinkLabel";
            this.sapLinkLabel.Size = new System.Drawing.Size(60, 16);
            this.sapLinkLabel.TabIndex = 7;
            this.sapLinkLabel.TabStop = true;
            this.sapLinkLabel.Text = "sap.com";
            this.sapLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sapLinkLabel_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 879);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1013, 10);
            this.progressBar1.TabIndex = 11;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Location = new System.Drawing.Point(933, 860);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(68, 13);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "version 1.0.1";
            // 
            // checkAllPictureBox
            // 
            this.checkAllPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAllPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.checkAllPictureBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.buttoncheckall;
            this.checkAllPictureBox.Location = new System.Drawing.Point(0, 841);
            this.checkAllPictureBox.Name = "checkAllPictureBox";
            this.checkAllPictureBox.Size = new System.Drawing.Size(123, 38);
            this.checkAllPictureBox.TabIndex = 14;
            this.checkAllPictureBox.TabStop = false;
            this.checkAllPictureBox.Click += new System.EventHandler(this.checkAllPictureBox_Click);
            this.checkAllPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.checkAllPictureBox.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.checkAllPictureBox.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.checkAllPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // installPictureBox
            // 
            this.installPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.installPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.installPictureBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.buttoninstall;
            this.installPictureBox.Location = new System.Drawing.Point(291, 841);
            this.installPictureBox.Name = "installPictureBox";
            this.installPictureBox.Size = new System.Drawing.Size(95, 38);
            this.installPictureBox.TabIndex = 15;
            this.installPictureBox.TabStop = false;
            this.installPictureBox.Click += new System.EventHandler(this.installButton_Click);
            this.installPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.installPictureBox_MouseDown);
            this.installPictureBox.MouseEnter += new System.EventHandler(this.installPictureBox_MouseEnter);
            this.installPictureBox.MouseLeave += new System.EventHandler(this.installPictureBox_MouseLeave);
            this.installPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.installPictureBox_MouseUp);
            // 
            // uncheckAllPictureBox
            // 
            this.uncheckAllPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uncheckAllPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.uncheckAllPictureBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.buttonuncheckall;
            this.uncheckAllPictureBox.Location = new System.Drawing.Point(129, 841);
            this.uncheckAllPictureBox.Name = "uncheckAllPictureBox";
            this.uncheckAllPictureBox.Size = new System.Drawing.Size(156, 38);
            this.uncheckAllPictureBox.TabIndex = 16;
            this.uncheckAllPictureBox.TabStop = false;
            this.uncheckAllPictureBox.Click += new System.EventHandler(this.uncheckAllPictureBox_Click);
            this.uncheckAllPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uncheckAllPictureBox_MouseDown);
            this.uncheckAllPictureBox.MouseEnter += new System.EventHandler(this.uncheckAllPictureBox_MouseEnter);
            this.uncheckAllPictureBox.MouseLeave += new System.EventHandler(this.uncheckAllPictureBox_MouseLeave);
            this.uncheckAllPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uncheckAllPictureBox_MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox1.Location = new System.Drawing.Point(156, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "         Snagit  ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox2.Location = new System.Drawing.Point(156, 108);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 24);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "         Slack  ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox3.Location = new System.Drawing.Point(0, 408);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 24);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "         Mailbird  ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox4.Location = new System.Drawing.Point(0, 378);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(107, 24);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "         Lightshot  ";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox5.Location = new System.Drawing.Point(156, 48);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(101, 24);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "         Postman ";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox6.Location = new System.Drawing.Point(156, 78);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(126, 24);
            this.checkBox6.TabIndex = 17;
            this.checkBox6.Text = "         ScreenPresso ";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox7.Location = new System.Drawing.Point(0, 348);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(103, 24);
            this.checkBox7.TabIndex = 18;
            this.checkBox7.Text = "         Evernote ";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox8.Location = new System.Drawing.Point(0, 288);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(126, 24);
            this.checkBox8.TabIndex = 19;
            this.checkBox8.Text = "         Auto HotKey  ";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox9.Location = new System.Drawing.Point(0, 318);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(147, 24);
            this.checkBox9.TabIndex = 20;
            this.checkBox9.Text = "         Beyond Compare ";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox17.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox17.Location = new System.Drawing.Point(288, 78);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(114, 24);
            this.checkBox17.TabIndex = 28;
            this.checkBox17.Text = "         WinMerge  ";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox18.Location = new System.Drawing.Point(156, 408);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(101, 24);
            this.checkBox18.TabIndex = 29;
            this.checkBox18.Text = "         VS Code  ";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox19.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox19.Location = new System.Drawing.Point(156, 378);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(82, 24);
            this.checkBox19.TabIndex = 30;
            this.checkBox19.Text = "         Visio  ";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox20.Location = new System.Drawing.Point(156, 348);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(86, 24);
            this.checkBox20.TabIndex = 31;
            this.checkBox20.Text = "         Trello  ";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox21.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox21.Location = new System.Drawing.Point(156, 318);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(95, 24);
            this.checkBox21.TabIndex = 32;
            this.checkBox21.Text = "         Tomcat  ";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox22.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox22.Location = new System.Drawing.Point(156, 288);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(81, 24);
            this.checkBox22.TabIndex = 33;
            this.checkBox22.Text = "         Toad  ";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox23.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox23.Location = new System.Drawing.Point(156, 258);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(99, 24);
            this.checkBox23.TabIndex = 34;
            this.checkBox23.Text = "         Textpad  ";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox24.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox24.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox24.Location = new System.Drawing.Point(156, 228);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(103, 24);
            this.checkBox24.TabIndex = 35;
            this.checkBox24.Text = "         Sublime   ";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox25.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox25.Location = new System.Drawing.Point(156, 198);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(96, 24);
            this.checkBox25.TabIndex = 36;
            this.checkBox25.Text = "         Soap UI  ";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox26.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox26.Location = new System.Drawing.Point(156, 168);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(91, 24);
            this.checkBox26.TabIndex = 37;
            this.checkBox26.Text = "         Oracle  ";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox27.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.jaspersoft_studio_icon;
            this.checkBox27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox27.Location = new System.Drawing.Point(156, 138);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(97, 24);
            this.checkBox27.TabIndex = 38;
            this.checkBox27.Text = "         Chrome ";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // SAPSoftwareDeploymentInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::SAPSoftwareDeploymentInstaller.Properties.Resources.lightcolorbackground;
            this.ClientSize = new System.Drawing.Size(1013, 891);
            this.Controls.Add(this.uncheckAllPictureBox);
            this.Controls.Add(this.installPictureBox);
            this.Controls.Add(this.checkAllPictureBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.sapLinkLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.selectProgramGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SAPSoftwareDeploymentInstaller";
            this.Text = "SAP Software Deployment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SAPSoftwareDeploymentInstaller_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.selectProgramGroupBox.ResumeLayout(false);
            this.selectProgramGroupBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkAllPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheckAllPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox sevenZipCheckBox;
        private System.Windows.Forms.RichTextBox installLogRichTextBox;
        private System.Windows.Forms.CheckBox iReport451CheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox selectProgramGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.LinkLabel sapLinkLabel;
        private System.Windows.Forms.CheckBox nPlusPlusCheckBox;
        private System.Windows.Forms.CheckBox virtualBoxCheckBox;
        private System.Windows.Forms.CheckBox jaspersoftStudioCheckBox;
        private System.Windows.Forms.CheckBox greenshotCheckBox;
        private System.Windows.Forms.CheckBox filezillaCheckBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewImageColumn Downloaded;
        private System.Windows.Forms.CheckBox puttyCheckBox;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.CheckBox winSCPCheckBox;
        private System.Windows.Forms.PictureBox checkAllPictureBox;
        private System.Windows.Forms.PictureBox installPictureBox;
        private System.Windows.Forms.PictureBox uncheckAllPictureBox;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
    }
}

