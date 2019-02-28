namespace SAPSoftwareDeploymentInstaller
{
    partial class Form1
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
            this.installButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmdBuilderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.isntallLogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(307, 346);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(138, 23);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Install SAP Package";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(58, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "7zip";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmdBuilderRichTextBox
            // 
            this.cmdBuilderRichTextBox.Location = new System.Drawing.Point(663, 12);
            this.cmdBuilderRichTextBox.Name = "cmdBuilderRichTextBox";
            this.cmdBuilderRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.cmdBuilderRichTextBox.TabIndex = 2;
            this.cmdBuilderRichTextBox.Text = "";
            this.cmdBuilderRichTextBox.Visible = false;
            // 
            // isntallLogRichTextBox
            // 
            this.isntallLogRichTextBox.Location = new System.Drawing.Point(181, 74);
            this.isntallLogRichTextBox.Name = "isntallLogRichTextBox";
            this.isntallLogRichTextBox.Size = new System.Drawing.Size(406, 205);
            this.isntallLogRichTextBox.TabIndex = 3;
            this.isntallLogRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 457);
            this.Controls.Add(this.isntallLogRichTextBox);
            this.Controls.Add(this.cmdBuilderRichTextBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.installButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox cmdBuilderRichTextBox;
        private System.Windows.Forms.RichTextBox isntallLogRichTextBox;
    }
}

