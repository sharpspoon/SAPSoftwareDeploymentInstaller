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
            this.sevenZipCheckBox = new System.Windows.Forms.CheckBox();
            this.cmdBuilderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.installLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.iReport451CheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Downloaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectProgramGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.selectProgramGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installButton.Location = new System.Drawing.Point(307, 346);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(138, 23);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Install SAP Package";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // sevenZipCheckBox
            // 
            this.sevenZipCheckBox.AutoSize = true;
            this.sevenZipCheckBox.Location = new System.Drawing.Point(6, 42);
            this.sevenZipCheckBox.Name = "sevenZipCheckBox";
            this.sevenZipCheckBox.Size = new System.Drawing.Size(45, 17);
            this.sevenZipCheckBox.TabIndex = 1;
            this.sevenZipCheckBox.Text = "7zip";
            this.sevenZipCheckBox.UseVisualStyleBackColor = true;
            this.sevenZipCheckBox.Visible = false;
            // 
            // cmdBuilderRichTextBox
            // 
            this.cmdBuilderRichTextBox.Location = new System.Drawing.Point(564, 12);
            this.cmdBuilderRichTextBox.Name = "cmdBuilderRichTextBox";
            this.cmdBuilderRichTextBox.Size = new System.Drawing.Size(100, 11);
            this.cmdBuilderRichTextBox.TabIndex = 2;
            this.cmdBuilderRichTextBox.Text = "";
            this.cmdBuilderRichTextBox.Visible = false;
            // 
            // installLogRichTextBox
            // 
            this.installLogRichTextBox.Location = new System.Drawing.Point(451, 93);
            this.installLogRichTextBox.Name = "installLogRichTextBox";
            this.installLogRichTextBox.Size = new System.Drawing.Size(312, 247);
            this.installLogRichTextBox.TabIndex = 3;
            this.installLogRichTextBox.Text = "";
            // 
            // iReport451CheckBox
            // 
            this.iReport451CheckBox.AutoSize = true;
            this.iReport451CheckBox.Checked = true;
            this.iReport451CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.iReport451CheckBox.Location = new System.Drawing.Point(6, 19);
            this.iReport451CheckBox.Name = "iReport451CheckBox";
            this.iReport451CheckBox.Size = new System.Drawing.Size(87, 17);
            this.iReport451CheckBox.TabIndex = 4;
            this.iReport451CheckBox.Text = "iReport 4.5.1";
            this.iReport451CheckBox.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(307, 375);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(138, 23);
            this.progressBar.TabIndex = 5;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(433, 247);
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
            this.selectProgramGroupBox.Controls.Add(this.sevenZipCheckBox);
            this.selectProgramGroupBox.Controls.Add(this.iReport451CheckBox);
            this.selectProgramGroupBox.Location = new System.Drawing.Point(12, 346);
            this.selectProgramGroupBox.Name = "selectProgramGroupBox";
            this.selectProgramGroupBox.Size = new System.Drawing.Size(200, 100);
            this.selectProgramGroupBox.TabIndex = 7;
            this.selectProgramGroupBox.TabStop = false;
            this.selectProgramGroupBox.Text = "Select Program";
            // 
            // SAPSoftwareDeploymentInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 457);
            this.Controls.Add(this.selectProgramGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.installLogRichTextBox);
            this.Controls.Add(this.cmdBuilderRichTextBox);
            this.Controls.Add(this.installButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SAPSoftwareDeploymentInstaller";
            this.Text = "SAP Software Deployment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.selectProgramGroupBox.ResumeLayout(false);
            this.selectProgramGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.CheckBox sevenZipCheckBox;
        private System.Windows.Forms.RichTextBox cmdBuilderRichTextBox;
        private System.Windows.Forms.RichTextBox installLogRichTextBox;
        private System.Windows.Forms.CheckBox iReport451CheckBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox selectProgramGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.DataGridViewTextBoxColumn Downloaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installed;
    }
}

