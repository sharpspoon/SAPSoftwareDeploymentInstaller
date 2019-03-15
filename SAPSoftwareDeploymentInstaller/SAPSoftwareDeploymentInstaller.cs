using IWshRuntimeLibrary;
using SAPSoftwareDeploymentInstaller.Properties;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Drawing;

namespace SAPSoftwareDeploymentInstaller
{
    public partial class SAPSoftwareDeploymentInstaller : Form
    {
        public SAPSoftwareDeploymentInstaller()
        {
            InitializeComponent();
        }

        //global stuff

        private void iReport451CheckBox_MouseEnter(object sender, EventArgs e)
        {
            //this.iReport451CheckBox.ForeColor = Color.Green;
            this.iReport451CheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void iReport451CheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.iReport451CheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void jaspersoftStudioCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.jaspersoftStudioCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void jaspersoftStudioCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.jaspersoftStudioCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void nPlusPlusCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.nPlusPlusCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void nPlusPlusCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.nPlusPlusCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void virtualBoxCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.virtualBoxCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void virtualBoxCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.virtualBoxCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void sevenZipCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.sevenZipCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void sevenZipCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.sevenZipCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void greenshotCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.greenshotCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void greenshotCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.greenshotCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void filezillaCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.filezillaCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void filezillaCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.filezillaCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void iReport451CheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.iReport451CheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void iReport451CheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.iReport451CheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void jaspersoftStudioCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.jaspersoftStudioCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void jaspersoftStudioCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.jaspersoftStudioCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void nPlusPlusCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.nPlusPlusCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void nPlusPlusCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.nPlusPlusCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void virtualBoxCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.virtualBoxCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void virtualBoxCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.virtualBoxCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void sevenZipCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.sevenZipCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void sevenZipCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.sevenZipCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void greenshotCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.greenshotCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void greenshotCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.greenshotCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void filezillaCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.filezillaCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void filezillaCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.filezillaCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        string user = Environment.UserName;
        string userDir = @"C:\Users\" + Environment.UserName + @"\SAPSDITemp";
        string sevenZipInstaller = "7z1900-x64.exe";
        string nppInstaller = "npp.7.6.4.Installer.x64.exe";
        string jaspersoftInstaller = "TIB_js-studiocomm_6.6.0_windows_x86_64.exe";
        string filezillaInstaller = "FileZilla_3.41.1_win64-setup.exe";
        string greenshotInstaller = "Greenshot-INSTALLER-1.2.10.6-RELEASE.exe";

        private void installButton_MouseEnter(object sender, EventArgs e)
        {
            this.installButton.Image = Resources.Downloadcolor;
        }

        private void installButton_MouseLeave(object sender, EventArgs e)
        {
            this.installButton.Image = Resources.Download;
        }

        private void installButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.installButton.Image = Resources.Downloadfilled;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sapLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sap.com");
        }

        private void SAPSoftwareDeploymentInstaller_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "SAP Software Deployment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {
            //check if any software is selected
            if (iReport451CheckBox.Checked == false && sevenZipCheckBox.Checked == false && nPlusPlusCheckBox.Checked == false && virtualBoxCheckBox.Checked == false && jaspersoftStudioCheckBox.Checked == false && greenshotCheckBox.Checked == false && filezillaCheckBox.Checked == false)
            {
                MessageBox.Show("Must select at least one program to install.", "SAP Software Deployment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //disable the run abliity if running
            installButton.Enabled = false;

            //show loading gif
            loadingPictureBox.Visible = true;

            //get os bit version
            bool sixtyFourBitOperatingSystem = System.Environment.Is64BitOperatingSystem;

            //clear contents after each run
            installLogRichTextBox.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            //install temp user directory
            System.IO.Directory.CreateDirectory(userDir);
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Creating temp directory: " + userDir + " ...Done.");

            ////////////////////////////////////////////////////////////////////////
            //CHECK WHICH ITEMS ARE SELECTED AND THEN ADD THEM TO THE DATAGRIDVIEW//
            ////////////////////////////////////////////////////////////////////////

            /////////////////
            //iReport 4.5.1//
            /////////////////
            //looks at each checkbox and adds to the table if it is checked 
            if (iReport451CheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("iReport 4.5.1", Resources.filedownload);
                //check if jre is installed
                string javaFile = @"C:\Program Files (x86)\Java\jre1.7.0_25\bin\java.exe";
                if (!System.IO.File.Exists(javaFile))
                {
                    dataGridView1.Rows.Add("jre1.7.0_25", Resources.filedownload);
                }
            }

            /////////////////
            //7zip///////////
            /////////////////
            if (sevenZipCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("7zip", Resources.filedownload);
            }

            /////////////////
            //N++////////////
            /////////////////
            if (nPlusPlusCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("N++", Resources.filedownload);
            }

            /////////////////
            //VIRTUALBOX/////
            /////////////////
            if (virtualBoxCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("VirtualBox", Resources.filedownload);
            }

            /////////////////
            //JASPERSOFT/////
            /////////////////
            if (jaspersoftStudioCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Jaspersoft Studio", Resources.filedownload);
            }

            /////////////////
            //GREENSHOT//////
            /////////////////
            if (greenshotCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Greenshot", Resources.filedownload);
            }

            /////////////////
            //FILEZILLA//////
            /////////////////
            if (filezillaCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("FileZilla", Resources.filedownload);
            }

            //////////////////////////////////
            //BEGIN DOWNLOAD / INSTALLATION///
            //////////////////////////////////

            /////////////////
            //iReport 4.5.1//
            /////////////////
            if (iReport451CheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading iReport 4.5.1 ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/ireport451/iReport-4.5.1.zip"),
                        // Param2 = Path to save
                        userDir + @"\iReport-4.5.1.zip"
                    );
                    wc.DownloadFileCompleted += DownloadCompleted;
                }

                string javaFile = @"C:\Program Files (x86)\Java\jre1.7.0_25\bin\java.exe";
                if (!System.IO.File.Exists(javaFile))
                {
                    installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading jre1.7.0_25 ....");
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;

                        wc.DownloadFileAsync(
                            // Param1 = Link of file
                            new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/jre17025/Java.zip"),
                            // Param2 = Path to save
                            userDir + @"\Java.zip"
                        );
                        wc.DownloadFileCompleted += DownloadCompleted2;
                    }
                }
            }

            /////////////////
            //7ZIP///////////
            /////////////////
            if (sevenZipCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading "+sevenZipInstaller+" ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/7zip/"+sevenZipInstaller),
                        // Param2 = Path to save
                        userDir + @"\"+sevenZipInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted3;
                }
            }

            /////////////////
            //N++////////////
            /////////////////
            if (nPlusPlusCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading "+nppInstaller+" ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/npp/"+nppInstaller),
                        // Param2 = Path to save
                        userDir + @"\"+nppInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted4;
                }
            }

            /////////////////
            //VIRTUALBOX/////
            /////////////////
            if (virtualBoxCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading VirtualBox 64-bit ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/virtualbox/VirtualBox-6.0.4-r128413-MultiArch_amd64.msi"),
                        // Param2 = Path to save
                        userDir + @"\VirtualBox-6.0.4-r128413-MultiArch_amd64.msi"
                    );
                }

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/virtualbox/common.cab"),
                        // Param2 = Path to save
                        userDir + @"\common.cab"
                    );
                    wc.DownloadFileCompleted += DownloadCompleted5;
                }
            }

            /////////////////
            //JASPERSOFT/////
            /////////////////
            if (jaspersoftStudioCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading "+jaspersoftInstaller+" ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/jaspersoftstudio/"+jaspersoftInstaller),
                        // Param2 = Path to save
                        userDir + @"\"+jaspersoftInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted6;
                }
            }

            /////////////////
            //GREENSHOT//////
            /////////////////
            if (greenshotCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading "+greenshotInstaller+" ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/greenshot/"+greenshotInstaller),
                        // Param2 = Path to save
                        userDir + @"\"+greenshotInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted7;
                }
            }

            /////////////////
            //FILEZILLA//////
            /////////////////
            if (filezillaCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading "+filezillaInstaller+" ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/filezilla/"+filezillaInstaller),
                        // Param2 = Path to save
                        userDir + @"\"+filezillaInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted8;
                }
            }
            //System.IO.Directory.Delete(userDir);
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {


            string startPath = userDir + @"/zip";
            string zipPath = userDir + @"\iReport-4.5.1.zip";
            string extractPath = @"C:\Program Files (x86)\Jaspersoft";
            System.IO.Directory.CreateDirectory(extractPath);

            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
            //create desktop shortcut
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\iReport 4.5.1.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Shortcut for iReport 4.5.1";
            //shortcut.Hotkey = "Ctrl+Shift+N";
            shortcut.TargetPath = @"C:\Program Files (x86)\Jaspersoft\iReport-4.5.1\bin\ireport.exe";
            shortcut.Save();

            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing iReport 4.5.1 ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "iReport 4.5.1")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                }
                if (row.Cells[1].Value != Resources.checkgreen)
                {
                    loadingPictureBox.Visible = true;
                    //disable the run abliity if running
                    installButton.Enabled = false;
                }
                else
                {
                    loadingPictureBox.Visible = false;
                    //enable the run abliity if complete
                    installButton.Enabled = true;
                }

            }

            if (progressBar1.Value == 100)
            {
                loadingPictureBox.Visible = false;
                //enable the run abliity if complete
                installButton.Enabled = true;
            }
        }

        private void DownloadCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            string startPath = userDir + @"/zip";
            string zipPath = userDir + @"\Java.zip";
            string extractPath = @"C:\Program Files (x86)";
            System.IO.File.SetAttributes(extractPath, FileAttributes.Normal);

            System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing jre1.7.0_25 ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "jre1.7.0_25")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                }
                if (row.Cells[1].Value != Resources.checkgreen)
                {
                    loadingPictureBox.Visible = true;
                    //disable the run abliity if running
                    installButton.Enabled = false;
                }
                else
                {
                    loadingPictureBox.Visible = false;
                    //enable the run abliity if complete
                    installButton.Enabled = true;
                }
            }
        }

        /////////////////
        //7ZIP///////////
        /////////////////


        private void DownloadCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "7zip")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder3(user, userDir, sevenZipInstaller);
                }
                if (row.Cells[1].Value != Resources.checkgreen)
                {
                    loadingPictureBox.Visible = true;
                    //disable the run abliity if running
                    installButton.Enabled = false;
                }
                else
                {
                    loadingPictureBox.Visible = false;
                    //enable the run abliity if complete
                    installButton.Enabled = true;
                }
            }
        }
        private void ProcessFolder3(string user, string userDir, string sevenZipInstaller)
        {
            if (Directory.GetFiles(userDir, sevenZipInstaller).Length > 0)
            {
                string[] files = Directory.GetFiles(userDir, sevenZipInstaller);

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/S /D=""C:\Program Files\7-Zip""'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
            }
        }

        /////////////////
        //N++////////////
        /////////////////

        private void DownloadCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "N++")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder4(user, userDir, nppInstaller);
                }
                if (row.Cells[1].Value != Resources.checkgreen)
                {
                    loadingPictureBox.Visible = true;
                    //disable the run abliity if running
                    installButton.Enabled = false;
                }
                else
                {
                    loadingPictureBox.Visible = false;
                    //enable the run abliity if complete
                    installButton.Enabled = true;
                }
            }
        }
        private void ProcessFolder4(string user, string userDir, string nppInstaller)
        {
            if (Directory.GetFiles(userDir, nppInstaller).Length > 0)
            {
                string[] files = Directory.GetFiles(userDir, nppInstaller);

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"/S";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
            }
        }

        /////////////////
        //VIRTUALBOX/////
        /////////////////

        private void DownloadCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "VirtualBox")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder5();
                }
                if (row.Cells[1].Value != Resources.checkgreen)
                {
                    loadingPictureBox.Visible = true;
                    //disable the run abliity if running
                    installButton.Enabled = false;
                }
                else
                {
                    loadingPictureBox.Visible = false;
                    //enable the run abliity if complete
                    installButton.Enabled = true;
                }
            }
        }
        private static void ProcessFolder5()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "VirtualBox*.msi").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "VirtualBox*.msi*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/quiet /qn /norestart ALLUSERS=2'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
            }
        }

        /////////////////
        //JASPERSOFT/////
        /////////////////

        private void DownloadCompleted6(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Jaspersoft Studio")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder6();
                }
                if (row.Cells[1].Value != Resources.checkgreen)
                {
                    loadingPictureBox.Visible = true;
                    //disable the run abliity if running
                    installButton.Enabled = false;
                }
                else
                {
                    loadingPictureBox.Visible = false;
                    //enable the run abliity if complete
                    installButton.Enabled = true;
                }
            }
        }
        private static void ProcessFolder6()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "TIB_js-studiocomm*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "TIB_js-studiocomm*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    //Deploy application  
                    Console.Read(); DeployApplications6(fileNameWithPath, fileName); Console.ReadLine();
                }
            }
        }

        public static void DeployApplications6(string executableFilePath, string fileName)
        {
            PowerShell powerShell = null;
            Console.WriteLine("Deploying application..." + executableFilePath);
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(@"$setup=Start-Process " + executableFilePath + @" -ArgumentList '/S /D=""C:\Program Files\Jaspersoft""' -Wait -PassThru");


                    Collection<PSObject> PSOutput = powerShell.Invoke(); foreach (PSObject outputItem in PSOutput)
                    {

                        if (outputItem != null)
                        {
                            Console.WriteLine(outputItem.BaseObject.GetType().FullName);
                            Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
                        }
                    }

                    if (powerShell.Streams.Error.Count > 0)
                    {
                        string temp = powerShell.Streams.Error.First().ToString();
                        Console.WriteLine("Error: {0}", temp);
                    }
                    else
                        Console.WriteLine("Installation has completed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.InnerException);
                //throw;  
            }
            finally
            {
                if (powerShell != null)
                    powerShell.Dispose();
            }
        }

        /////////////////
        //GREENSHOT//////
        /////////////////
        void wc7_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e7)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Greenshot")
                    row.Cells[1].Value = e7.ProgressPercentage + @"%";
            }
        }

        private void DownloadCompleted7(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Greenshot")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder7();
                }
                if (row.Cells[1].Value != Resources.checkgreen)
                {
                    loadingPictureBox.Visible = true;
                    //disable the run abliity if running
                    installButton.Enabled = false;
                }
                else
                {
                    loadingPictureBox.Visible = false;
                    //enable the run abliity if complete
                    installButton.Enabled = true;
                }
            }
        }
        private static void ProcessFolder7()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "Greenshot*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "Greenshot*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    //Deploy application  
                    Console.Read(); DeployApplications7(fileNameWithPath, fileName); Console.ReadLine();
                }
            }
        }

        public static void DeployApplications7(string executableFilePath, string fileName)
        {
            PowerShell powerShell = null;
            Console.WriteLine("Deploying application..." + executableFilePath);
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(@"$setup=Start-Process " + executableFilePath + @" -ArgumentList '/verysilent' -Wait -PassThru");


                    Collection<PSObject> PSOutput = powerShell.Invoke(); foreach (PSObject outputItem in PSOutput)
                    {

                        if (outputItem != null)
                        {
                            Console.WriteLine(outputItem.BaseObject.GetType().FullName);
                            Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
                        }
                    }

                    if (powerShell.Streams.Error.Count > 0)
                    {
                        string temp = powerShell.Streams.Error.First().ToString();
                        Console.WriteLine("Error: {0}", temp);
                    }
                    else
                        Console.WriteLine("Installation has completed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.InnerException);
                //throw;  
            }
            finally
            {
                if (powerShell != null)
                    powerShell.Dispose();
            }
        }

        /////////////////
        //FILEZILLA//////
        /////////////////

        private void DownloadCompleted8(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "FileZilla")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder8();
                }
                if (row.Cells[1].Value != Resources.checkgreen)
                {
                    loadingPictureBox.Visible = true;
                    //disable the run abliity if running
                    installButton.Enabled = false;
                }
                else
                {
                    loadingPictureBox.Visible = false;
                    //enable the run abliity if complete
                    installButton.Enabled = true;
                }
            }
        }
        private static void ProcessFolder8()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "FileZilla*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "FileZilla*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/NCRC /S /D=%ApplicationDir%'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
            }
        }

        public static void DeployApplications(string executableFilePath, string fileName, string argumentList)
        {
            PowerShell powerShell = null;
            Console.WriteLine("Deploying application..." + executableFilePath);
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(@"$setup=Start-Process " + executableFilePath + @" -ArgumentList "+argumentList+" -Wait -PassThru");


                    Collection<PSObject> PSOutput = powerShell.Invoke(); foreach (PSObject outputItem in PSOutput)
                    {

                        if (outputItem != null)
                        {
                            Console.WriteLine(outputItem.BaseObject.GetType().FullName);
                            Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
                        }
                    }

                    if (powerShell.Streams.Error.Count > 0)
                    {
                        string temp = powerShell.Streams.Error.First().ToString();
                        Console.WriteLine("Error: {0}", temp);
                    }
                    else
                        Console.WriteLine("Installation has completed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: {0}", ex.InnerException);
                //throw;  
            }
            finally
            {
                if (powerShell != null)
                    powerShell.Dispose();
            }
        }
    }
}

