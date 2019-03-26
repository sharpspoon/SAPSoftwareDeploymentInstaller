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
            this.chromeCheckBox = new System.Windows.Forms.CheckBox();
            this.oracleCheckBox = new System.Windows.Forms.CheckBox();
            this.soapCheckBox = new System.Windows.Forms.CheckBox();
            this.sublimeCheckBox = new System.Windows.Forms.CheckBox();
            this.textpadCheckBox = new System.Windows.Forms.CheckBox();
            this.tomcatCheckBox = new System.Windows.Forms.CheckBox();
            this.trelloCheckBox = new System.Windows.Forms.CheckBox();
            this.visioCheckBox = new System.Windows.Forms.CheckBox();
            this.vscodeCheckBox = new System.Windows.Forms.CheckBox();
            this.winmergeCheckBox = new System.Windows.Forms.CheckBox();
            this.toadCheckBox = new System.Windows.Forms.CheckBox();
            this.beyondCompareCheckBox = new System.Windows.Forms.CheckBox();
            this.autoHotkeyCheckBox = new System.Windows.Forms.CheckBox();
            this.evernoteCheckBox = new System.Windows.Forms.CheckBox();
            this.screenpressoCheckBox = new System.Windows.Forms.CheckBox();
            this.postmanCheckBox = new System.Windows.Forms.CheckBox();
            this.lightshotCheckBox = new System.Windows.Forms.CheckBox();
            this.mailbirdCheckBox = new System.Windows.Forms.CheckBox();
            this.slackCheckBox = new System.Windows.Forms.CheckBox();
            this.snagitCheckBox = new System.Windows.Forms.CheckBox();
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
            this.selectProgramGroupBox.Controls.Add(this.chromeCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.oracleCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.soapCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.sublimeCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.textpadCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.tomcatCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.trelloCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.visioCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.vscodeCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.winmergeCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.toadCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.beyondCompareCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.autoHotkeyCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.evernoteCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.screenpressoCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.postmanCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.lightshotCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.mailbirdCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.slackCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.snagitCheckBox);
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
            // chromeCheckBox
            // 
            this.chromeCheckBox.AutoSize = true;
            this.chromeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chromeCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chromeCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.chrome;
            this.chromeCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chromeCheckBox.Location = new System.Drawing.Point(156, 138);
            this.chromeCheckBox.Name = "chromeCheckBox";
            this.chromeCheckBox.Size = new System.Drawing.Size(97, 24);
            this.chromeCheckBox.TabIndex = 38;
            this.chromeCheckBox.Text = "         Chrome ";
            this.chromeCheckBox.UseVisualStyleBackColor = true;
            this.chromeCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chromeCheckBox_MouseDown);
            this.chromeCheckBox.MouseEnter += new System.EventHandler(this.chromeCheckBox_MouseEnter);
            this.chromeCheckBox.MouseLeave += new System.EventHandler(this.chromeCheckBox_MouseLeave);
            this.chromeCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chromeCheckBox_MouseUp);
            // 
            // oracleCheckBox
            // 
            this.oracleCheckBox.AutoSize = true;
            this.oracleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oracleCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oracleCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.oracle;
            this.oracleCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oracleCheckBox.Location = new System.Drawing.Point(156, 168);
            this.oracleCheckBox.Name = "oracleCheckBox";
            this.oracleCheckBox.Size = new System.Drawing.Size(91, 24);
            this.oracleCheckBox.TabIndex = 37;
            this.oracleCheckBox.Text = "         Oracle  ";
            this.oracleCheckBox.UseVisualStyleBackColor = true;
            this.oracleCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.oracleCheckBox_MouseDown);
            this.oracleCheckBox.MouseEnter += new System.EventHandler(this.oracleCheckBox_MouseEnter);
            this.oracleCheckBox.MouseLeave += new System.EventHandler(this.oracleCheckBox_MouseLeave);
            this.oracleCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.oracleCheckBox_MouseUp);
            // 
            // soapCheckBox
            // 
            this.soapCheckBox.AutoSize = true;
            this.soapCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soapCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soapCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.soap;
            this.soapCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.soapCheckBox.Location = new System.Drawing.Point(156, 198);
            this.soapCheckBox.Name = "soapCheckBox";
            this.soapCheckBox.Size = new System.Drawing.Size(96, 24);
            this.soapCheckBox.TabIndex = 36;
            this.soapCheckBox.Text = "         Soap UI  ";
            this.soapCheckBox.UseVisualStyleBackColor = true;
            this.soapCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.soapCheckBox_MouseDown);
            this.soapCheckBox.MouseEnter += new System.EventHandler(this.soapCheckBox_MouseEnter);
            this.soapCheckBox.MouseLeave += new System.EventHandler(this.soapCheckBox_MouseLeave);
            this.soapCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.soapCheckBox_MouseUp);
            // 
            // sublimeCheckBox
            // 
            this.sublimeCheckBox.AutoSize = true;
            this.sublimeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sublimeCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublimeCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.sublime;
            this.sublimeCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sublimeCheckBox.Location = new System.Drawing.Point(156, 228);
            this.sublimeCheckBox.Name = "sublimeCheckBox";
            this.sublimeCheckBox.Size = new System.Drawing.Size(103, 24);
            this.sublimeCheckBox.TabIndex = 35;
            this.sublimeCheckBox.Text = "         Sublime   ";
            this.sublimeCheckBox.UseVisualStyleBackColor = true;
            this.sublimeCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sublimeCheckBox_MouseDown);
            this.sublimeCheckBox.MouseEnter += new System.EventHandler(this.sublimeCheckBox_MouseEnter);
            this.sublimeCheckBox.MouseLeave += new System.EventHandler(this.sublimeCheckBox_MouseLeave);
            this.sublimeCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sublimeCheckBox_MouseUp);
            // 
            // textpadCheckBox
            // 
            this.textpadCheckBox.AutoSize = true;
            this.textpadCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textpadCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpadCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.textpad;
            this.textpadCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textpadCheckBox.Location = new System.Drawing.Point(156, 258);
            this.textpadCheckBox.Name = "textpadCheckBox";
            this.textpadCheckBox.Size = new System.Drawing.Size(99, 24);
            this.textpadCheckBox.TabIndex = 34;
            this.textpadCheckBox.Text = "         Textpad  ";
            this.textpadCheckBox.UseVisualStyleBackColor = true;
            this.textpadCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textpadCheckBox_MouseDown);
            this.textpadCheckBox.MouseEnter += new System.EventHandler(this.textpadCheckBox_MouseEnter);
            this.textpadCheckBox.MouseLeave += new System.EventHandler(this.textpadCheckBox_MouseLeave);
            this.textpadCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textpadCheckBox_MouseUp);
            // 
            // tomcatCheckBox
            // 
            this.tomcatCheckBox.AutoSize = true;
            this.tomcatCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tomcatCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tomcatCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.tomcat;
            this.tomcatCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tomcatCheckBox.Location = new System.Drawing.Point(156, 318);
            this.tomcatCheckBox.Name = "tomcatCheckBox";
            this.tomcatCheckBox.Size = new System.Drawing.Size(95, 24);
            this.tomcatCheckBox.TabIndex = 32;
            this.tomcatCheckBox.Text = "         Tomcat  ";
            this.tomcatCheckBox.UseVisualStyleBackColor = true;
            this.tomcatCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tomcatCheckBox_MouseDown);
            this.tomcatCheckBox.MouseEnter += new System.EventHandler(this.tomcatCheckBox_MouseEnter);
            this.tomcatCheckBox.MouseLeave += new System.EventHandler(this.tomcatCheckBox_MouseLeave);
            this.tomcatCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tomcatCheckBox_MouseUp);
            // 
            // trelloCheckBox
            // 
            this.trelloCheckBox.AutoSize = true;
            this.trelloCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trelloCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trelloCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.trello;
            this.trelloCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trelloCheckBox.Location = new System.Drawing.Point(156, 348);
            this.trelloCheckBox.Name = "trelloCheckBox";
            this.trelloCheckBox.Size = new System.Drawing.Size(86, 24);
            this.trelloCheckBox.TabIndex = 31;
            this.trelloCheckBox.Text = "         Trello  ";
            this.trelloCheckBox.UseVisualStyleBackColor = true;
            this.trelloCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trelloCheckBox_MouseDown);
            this.trelloCheckBox.MouseEnter += new System.EventHandler(this.trelloCheckBox_MouseEnter);
            this.trelloCheckBox.MouseLeave += new System.EventHandler(this.trelloCheckBox_MouseLeave);
            this.trelloCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trelloCheckBox_MouseUp);
            // 
            // visioCheckBox
            // 
            this.visioCheckBox.AutoSize = true;
            this.visioCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visioCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visioCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.visio;
            this.visioCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.visioCheckBox.Location = new System.Drawing.Point(156, 378);
            this.visioCheckBox.Name = "visioCheckBox";
            this.visioCheckBox.Size = new System.Drawing.Size(82, 24);
            this.visioCheckBox.TabIndex = 30;
            this.visioCheckBox.Text = "         Visio  ";
            this.visioCheckBox.UseVisualStyleBackColor = true;
            this.visioCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.visioCheckBox_MouseDown);
            this.visioCheckBox.MouseEnter += new System.EventHandler(this.visioCheckBox_MouseEnter);
            this.visioCheckBox.MouseLeave += new System.EventHandler(this.visioCheckBox_MouseLeave);
            this.visioCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.visioCheckBox_MouseUp);
            // 
            // vscodeCheckBox
            // 
            this.vscodeCheckBox.AutoSize = true;
            this.vscodeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vscodeCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vscodeCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.vscode;
            this.vscodeCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vscodeCheckBox.Location = new System.Drawing.Point(156, 408);
            this.vscodeCheckBox.Name = "vscodeCheckBox";
            this.vscodeCheckBox.Size = new System.Drawing.Size(101, 24);
            this.vscodeCheckBox.TabIndex = 29;
            this.vscodeCheckBox.Text = "         VS Code  ";
            this.vscodeCheckBox.UseVisualStyleBackColor = true;
            this.vscodeCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.vscodeCheckBox_MouseDown);
            this.vscodeCheckBox.MouseEnter += new System.EventHandler(this.vscodeCheckBox_MouseEnter);
            this.vscodeCheckBox.MouseLeave += new System.EventHandler(this.vscodeCheckBox_MouseLeave);
            this.vscodeCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.vscodeCheckBox_MouseUp);
            // 
            // winmergeCheckBox
            // 
            this.winmergeCheckBox.AutoSize = true;
            this.winmergeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winmergeCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winmergeCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.winmerge;
            this.winmergeCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.winmergeCheckBox.Location = new System.Drawing.Point(288, 78);
            this.winmergeCheckBox.Name = "winmergeCheckBox";
            this.winmergeCheckBox.Size = new System.Drawing.Size(114, 24);
            this.winmergeCheckBox.TabIndex = 28;
            this.winmergeCheckBox.Text = "         WinMerge  ";
            this.winmergeCheckBox.UseVisualStyleBackColor = true;
            this.winmergeCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.winmergeCheckBox_MouseDown);
            this.winmergeCheckBox.MouseEnter += new System.EventHandler(this.winmergeCheckBox_MouseEnter);
            this.winmergeCheckBox.MouseLeave += new System.EventHandler(this.winmergeCheckBox_MouseLeave);
            this.winmergeCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.winmergeCheckBox_MouseUp);
            // 
            // toadCheckBox
            // 
            this.toadCheckBox.AutoSize = true;
            this.toadCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toadCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toadCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.toad;
            this.toadCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toadCheckBox.Location = new System.Drawing.Point(156, 288);
            this.toadCheckBox.Name = "toadCheckBox";
            this.toadCheckBox.Size = new System.Drawing.Size(81, 24);
            this.toadCheckBox.TabIndex = 33;
            this.toadCheckBox.Text = "         Toad  ";
            this.toadCheckBox.UseVisualStyleBackColor = true;
            this.toadCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toadCheckBox_MouseDown);
            this.toadCheckBox.MouseEnter += new System.EventHandler(this.toadCheckBox_MouseEnter);
            this.toadCheckBox.MouseLeave += new System.EventHandler(this.toadCheckBox_MouseLeave);
            this.toadCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toadCheckBox_MouseUp);
            // 
            // beyondCompareCheckBox
            // 
            this.beyondCompareCheckBox.AutoSize = true;
            this.beyondCompareCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beyondCompareCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beyondCompareCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.beyondcompare;
            this.beyondCompareCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.beyondCompareCheckBox.Location = new System.Drawing.Point(0, 318);
            this.beyondCompareCheckBox.Name = "beyondCompareCheckBox";
            this.beyondCompareCheckBox.Size = new System.Drawing.Size(147, 24);
            this.beyondCompareCheckBox.TabIndex = 20;
            this.beyondCompareCheckBox.Text = "         Beyond Compare ";
            this.beyondCompareCheckBox.UseVisualStyleBackColor = true;
            this.beyondCompareCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.beyondCompareCheckBox_MouseDown);
            this.beyondCompareCheckBox.MouseEnter += new System.EventHandler(this.beyondCompareCheckBox_MouseEnter);
            this.beyondCompareCheckBox.MouseLeave += new System.EventHandler(this.beyondCompareCheckBox_MouseLeave);
            this.beyondCompareCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.beyondCompareCheckBox_MouseUp);
            // 
            // autoHotkeyCheckBox
            // 
            this.autoHotkeyCheckBox.AutoSize = true;
            this.autoHotkeyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoHotkeyCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoHotkeyCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.autohotkey;
            this.autoHotkeyCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autoHotkeyCheckBox.Location = new System.Drawing.Point(0, 288);
            this.autoHotkeyCheckBox.Name = "autoHotkeyCheckBox";
            this.autoHotkeyCheckBox.Size = new System.Drawing.Size(126, 24);
            this.autoHotkeyCheckBox.TabIndex = 19;
            this.autoHotkeyCheckBox.Text = "         Auto HotKey  ";
            this.autoHotkeyCheckBox.UseVisualStyleBackColor = true;
            this.autoHotkeyCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.autoHotkeyCheckBox_MouseDown);
            this.autoHotkeyCheckBox.MouseEnter += new System.EventHandler(this.autoHotkeyCheckBox_MouseEnter);
            this.autoHotkeyCheckBox.MouseLeave += new System.EventHandler(this.autoHotkeyCheckBox_MouseLeave);
            this.autoHotkeyCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.autoHotkeyCheckBox_MouseUp);
            // 
            // evernoteCheckBox
            // 
            this.evernoteCheckBox.AutoSize = true;
            this.evernoteCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evernoteCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evernoteCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.evernote;
            this.evernoteCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.evernoteCheckBox.Location = new System.Drawing.Point(0, 348);
            this.evernoteCheckBox.Name = "evernoteCheckBox";
            this.evernoteCheckBox.Size = new System.Drawing.Size(103, 24);
            this.evernoteCheckBox.TabIndex = 18;
            this.evernoteCheckBox.Text = "         Evernote ";
            this.evernoteCheckBox.UseVisualStyleBackColor = true;
            this.evernoteCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.evernoteCheckBox_MouseDown);
            this.evernoteCheckBox.MouseEnter += new System.EventHandler(this.evernoteCheckBox_MouseEnter);
            this.evernoteCheckBox.MouseLeave += new System.EventHandler(this.evernoteCheckBox_MouseLeave);
            this.evernoteCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.evernoteCheckBox_MouseUp);
            // 
            // screenpressoCheckBox
            // 
            this.screenpressoCheckBox.AutoSize = true;
            this.screenpressoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.screenpressoCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenpressoCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.screenpresso;
            this.screenpressoCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.screenpressoCheckBox.Location = new System.Drawing.Point(156, 78);
            this.screenpressoCheckBox.Name = "screenpressoCheckBox";
            this.screenpressoCheckBox.Size = new System.Drawing.Size(126, 24);
            this.screenpressoCheckBox.TabIndex = 17;
            this.screenpressoCheckBox.Text = "         ScreenPresso ";
            this.screenpressoCheckBox.UseVisualStyleBackColor = true;
            this.screenpressoCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.screenpressoCheckBox_MouseDown);
            this.screenpressoCheckBox.MouseEnter += new System.EventHandler(this.screenpressoCheckBox_MouseEnter);
            this.screenpressoCheckBox.MouseLeave += new System.EventHandler(this.screenpressoCheckBox_MouseLeave);
            this.screenpressoCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.screenpressoCheckBox_MouseUp);
            // 
            // postmanCheckBox
            // 
            this.postmanCheckBox.AutoSize = true;
            this.postmanCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postmanCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postmanCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.postman;
            this.postmanCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postmanCheckBox.Location = new System.Drawing.Point(156, 48);
            this.postmanCheckBox.Name = "postmanCheckBox";
            this.postmanCheckBox.Size = new System.Drawing.Size(101, 24);
            this.postmanCheckBox.TabIndex = 16;
            this.postmanCheckBox.Text = "         Postman ";
            this.postmanCheckBox.UseVisualStyleBackColor = true;
            this.postmanCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.postmanCheckBox_MouseDown);
            this.postmanCheckBox.MouseEnter += new System.EventHandler(this.postmanCheckBox_MouseEnter);
            this.postmanCheckBox.MouseLeave += new System.EventHandler(this.postmanCheckBox_MouseLeave);
            this.postmanCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.postmanCheckBox_MouseUp);
            // 
            // lightshotCheckBox
            // 
            this.lightshotCheckBox.AutoSize = true;
            this.lightshotCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightshotCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightshotCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.lightshot;
            this.lightshotCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lightshotCheckBox.Location = new System.Drawing.Point(0, 378);
            this.lightshotCheckBox.Name = "lightshotCheckBox";
            this.lightshotCheckBox.Size = new System.Drawing.Size(107, 24);
            this.lightshotCheckBox.TabIndex = 15;
            this.lightshotCheckBox.Text = "         Lightshot  ";
            this.lightshotCheckBox.UseVisualStyleBackColor = true;
            this.lightshotCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lightshotCheckBox_MouseDown);
            this.lightshotCheckBox.MouseEnter += new System.EventHandler(this.lightshotCheckBox_MouseEnter);
            this.lightshotCheckBox.MouseLeave += new System.EventHandler(this.lightshotCheckBox_MouseLeave);
            this.lightshotCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lightshotCheckBox_MouseUp);
            // 
            // mailbirdCheckBox
            // 
            this.mailbirdCheckBox.AutoSize = true;
            this.mailbirdCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailbirdCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailbirdCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.mailbird;
            this.mailbirdCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailbirdCheckBox.Location = new System.Drawing.Point(0, 408);
            this.mailbirdCheckBox.Name = "mailbirdCheckBox";
            this.mailbirdCheckBox.Size = new System.Drawing.Size(101, 24);
            this.mailbirdCheckBox.TabIndex = 14;
            this.mailbirdCheckBox.Text = "         Mailbird  ";
            this.mailbirdCheckBox.UseVisualStyleBackColor = true;
            this.mailbirdCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mailbirdCheckBox_MouseDown);
            this.mailbirdCheckBox.MouseEnter += new System.EventHandler(this.mailbirdCheckBox_MouseEnter);
            this.mailbirdCheckBox.MouseLeave += new System.EventHandler(this.mailbirdCheckBox_MouseLeave);
            this.mailbirdCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mailbirdCheckBox_MouseUp);
            // 
            // slackCheckBox
            // 
            this.slackCheckBox.AutoSize = true;
            this.slackCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slackCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slackCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.slack;
            this.slackCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slackCheckBox.Location = new System.Drawing.Point(156, 108);
            this.slackCheckBox.Name = "slackCheckBox";
            this.slackCheckBox.Size = new System.Drawing.Size(82, 24);
            this.slackCheckBox.TabIndex = 13;
            this.slackCheckBox.Text = "         Slack  ";
            this.slackCheckBox.UseVisualStyleBackColor = true;
            this.slackCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slackCheckBox_MouseDown);
            this.slackCheckBox.MouseEnter += new System.EventHandler(this.slackCheckBox_MouseEnter);
            this.slackCheckBox.MouseLeave += new System.EventHandler(this.slackCheckBox_MouseLeave);
            this.slackCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slackCheckBox_MouseUp);
            // 
            // snagitCheckBox
            // 
            this.snagitCheckBox.AutoSize = true;
            this.snagitCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snagitCheckBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snagitCheckBox.Image = global::SAPSoftwareDeploymentInstaller.Properties.Resources.snagit;
            this.snagitCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.snagitCheckBox.Location = new System.Drawing.Point(156, 18);
            this.snagitCheckBox.Name = "snagitCheckBox";
            this.snagitCheckBox.Size = new System.Drawing.Size(89, 24);
            this.snagitCheckBox.TabIndex = 12;
            this.snagitCheckBox.Text = "         Snagit  ";
            this.snagitCheckBox.UseVisualStyleBackColor = true;
            this.snagitCheckBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.snagitCheckBox_MouseDown);
            this.snagitCheckBox.MouseEnter += new System.EventHandler(this.snagitCheckBox_MouseEnter);
            this.snagitCheckBox.MouseLeave += new System.EventHandler(this.snagitCheckBox_MouseLeave);
            this.snagitCheckBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.snagitCheckBox_MouseUp);
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
            this.checkAllPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.installPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.uncheckAllPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
        private System.Windows.Forms.CheckBox chromeCheckBox;
        private System.Windows.Forms.CheckBox beyondCompareCheckBox;
        private System.Windows.Forms.CheckBox autoHotkeyCheckBox;
        private System.Windows.Forms.CheckBox evernoteCheckBox;
        private System.Windows.Forms.CheckBox screenpressoCheckBox;
        private System.Windows.Forms.CheckBox postmanCheckBox;
        private System.Windows.Forms.CheckBox lightshotCheckBox;
        private System.Windows.Forms.CheckBox mailbirdCheckBox;
        private System.Windows.Forms.CheckBox slackCheckBox;
        private System.Windows.Forms.CheckBox snagitCheckBox;
        private System.Windows.Forms.CheckBox winmergeCheckBox;
        private System.Windows.Forms.CheckBox vscodeCheckBox;
        private System.Windows.Forms.CheckBox visioCheckBox;
        private System.Windows.Forms.CheckBox trelloCheckBox;
        private System.Windows.Forms.CheckBox tomcatCheckBox;
        private System.Windows.Forms.CheckBox toadCheckBox;
        private System.Windows.Forms.CheckBox textpadCheckBox;
        private System.Windows.Forms.CheckBox sublimeCheckBox;
        private System.Windows.Forms.CheckBox soapCheckBox;
        private System.Windows.Forms.CheckBox oracleCheckBox;
    }
}

