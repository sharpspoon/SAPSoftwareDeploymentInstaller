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
        private void iReport451CheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.iReport451CheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void iReport451CheckBox_MouseUp(object sender, MouseEventArgs e)
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

        private void jaspersoftStudioCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.jaspersoftStudioCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void jaspersoftStudioCheckBox_MouseUp(object sender, MouseEventArgs e)
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

        private void nPlusPlusCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.nPlusPlusCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void nPlusPlusCheckBox_MouseUp(object sender, MouseEventArgs e)
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

        private void virtualBoxCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.virtualBoxCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void virtualBoxCheckBox_MouseUp(object sender, MouseEventArgs e)
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

        private void sevenZipCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.sevenZipCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void sevenZipCheckBox_MouseUp(object sender, MouseEventArgs e)
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

        private void greenshotCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.greenshotCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void greenshotCheckBox_MouseUp(object sender, MouseEventArgs e)
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

        private void filezillaCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.filezillaCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void filezillaCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.filezillaCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void puttyCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.puttyCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void puttyCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.puttyCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void puttyCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.puttyCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void puttyCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.puttyCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        string user = Environment.UserName;
        string userDir = @"C:\Users\" + Environment.UserName + @"\SAPSDITemp";
        string sevenZipInstaller = "7z1900-x64.exe";
        string nppInstaller = "npp.7.6.4.Installer.x64.exe";
        string jaspersoftInstaller = "TIB_js-studiocomm_6.6.0_windows_x86_64.exe";
        string filezillaInstaller = "FileZilla_3.41.1_win64-setup.exe";
        string greenshotInstaller = "Greenshot-INSTALLER-1.2.10.6-RELEASE.exe";
        string puttyInstaller = "putty-64bit-0.71-installer.msi";
        string winscpInstaller = "WinSCP-5.13.9-Setup.exe";
        

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
            if (iReport451CheckBox.Checked == false && sevenZipCheckBox.Checked == false && nPlusPlusCheckBox.Checked == false && virtualBoxCheckBox.Checked == false && jaspersoftStudioCheckBox.Checked == false && greenshotCheckBox.Checked == false && filezillaCheckBox.Checked == false && puttyCheckBox.Checked == false)
            {
                MessageBox.Show("Must select at least one program to install.", "SAP Software Deployment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (progressBar1.Value != 0 && progressBar1.Value != 100)
            {
                MessageBox.Show("Process is currently running!", "SAP Software Deployment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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

            /////////////////
            //PUTTY//////////
            /////////////////
            if (puttyCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("PuTTY", Resources.filedownload);
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
                        new System.Uri("https://wardr.net/sapsdi/ireport451/iReport-4.5.1.zip"),
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
                            new System.Uri("https://wardr.net/sapsdi/ireport451/Java.zip"),
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
                        new System.Uri("https://wardr.net/sapsdi/7zip/" + sevenZipInstaller),
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
                        new System.Uri("https://wardr.net/sapsdi/npp/" + nppInstaller),
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
                        new System.Uri("https://wardr.net/sapsdi/virtualbox//VirtualBox-6.0.4-r128413-MultiArch_amd64.msi"),
                        // Param2 = Path to save
                        userDir + @"\VirtualBox-6.0.4-r128413-MultiArch_amd64.msi"
                    );
                }

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/virtualbox//common.cab"),
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
                        new System.Uri("https://wardr.net/sapsdi/jaspersoftstudio/" + jaspersoftInstaller),
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
                        new System.Uri("https://wardr.net/sapsdi/greenshot/" + greenshotInstaller),
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
                        new System.Uri("https://wardr.net/sapsdi/filezilla/" + filezillaInstaller),
                        // Param2 = Path to save
                        userDir + @"\"+filezillaInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted8;
                }
            }

            /////////////////
            //PUTTY//////////
            /////////////////
            if (puttyCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + puttyInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/putty/" + puttyInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + puttyInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted9;
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

            if (Directory.Exists(extractPath))
            {
                Directory.Delete(extractPath, true);
                System.IO.Directory.CreateDirectory(extractPath);
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Recreating Directory " + extractPath + "...Done.");
            }
            else
            {
                System.IO.Directory.CreateDirectory(extractPath);
            }
            
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
            }
        }

        /////////////////
        //7ZIP///////////
        /////////////////
        private void DownloadCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + sevenZipInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "7zip")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder3(user, userDir, sevenZipInstaller);
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
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + sevenZipInstaller + " ....Done.");
            }
        }

        /////////////////
        //N++////////////
        /////////////////
        private void DownloadCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + nppInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "N++")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder4(user, userDir, nppInstaller);
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
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + nppInstaller + " ....Done.");
            }
        }

        /////////////////
        //VIRTUALBOX/////
        /////////////////
        private void DownloadCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading VirtualBox 64-bit ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "VirtualBox")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder5();
                }
            }
        }
        private void ProcessFolder5()
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
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing VirtualBox 64-bit  ....Done.");
            }
        }

        /////////////////
        //JASPERSOFT/////
        /////////////////
        private void DownloadCompleted6(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + jaspersoftInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Jaspersoft Studio")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder6();
                }
            }
        }
        private void ProcessFolder6()
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
                    var argumentList = @"'/S /D=""C:\Program Files\Jaspersoft""'";
                    //Deploy application  
                    Console.Read(); DeployApplications(fileNameWithPath, fileName, argumentList); Console.ReadLine();
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + jaspersoftInstaller + " ....Done.");
            }
        }

        /////////////////
        //GREENSHOT//////
        /////////////////
        private void DownloadCompleted7(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + greenshotInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Greenshot")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder7();
                }
            }
        }
        private void ProcessFolder7()
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
                    var argumentList = @"'/verysilent'";
                    //Deploy application  
                    Console.Read(); DeployApplications(fileNameWithPath, fileName, argumentList); Console.ReadLine();
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + greenshotInstaller + " ....Done.");
            }
        }

        /////////////////
        //FILEZILLA//////
        /////////////////
        private void DownloadCompleted8(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + filezillaInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "FileZilla")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder8();
                }
            }
        }
        private void ProcessFolder8()
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
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + filezillaInstaller + " ....Done.");
            }
        }

        /////////////////
        //PUTTY//////////
        /////////////////
        private void DownloadCompleted9(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + puttyInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "PuTTY")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder9();
                }
            }
        }
        private void ProcessFolder9()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "putty*.msi").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "putty*.msi*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"/qn";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + puttyInstaller + " ....Done.");
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.checkAllPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttoncheckall1));
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.checkAllPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttoncheckall));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.checkAllPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttoncheckall2));
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.checkAllPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttoncheckall1));
        }

        private void checkAllPictureBox_Click(object sender, EventArgs e)
        {
            iReport451CheckBox.Checked = true;
            sevenZipCheckBox.Checked = true;
            nPlusPlusCheckBox.Checked = true;
            virtualBoxCheckBox.Checked = true;
            jaspersoftStudioCheckBox.Checked = true;
            greenshotCheckBox.Checked = true;
            filezillaCheckBox.Checked = true;
            puttyCheckBox.Checked = true;
            winSCPCheckBox.Checked = true;
        }

        private void installPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.installPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttoninstall2));
        }

        private void installPictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.installPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttoninstall1));
        }

        private void installPictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.installPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttoninstall));
        }

        private void installPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.installPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttoninstall1));
        }

        private void uncheckAllPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.uncheckAllPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttonuncheckall2));
        }

        private void uncheckAllPictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.uncheckAllPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttonuncheckall1));
        }

        private void uncheckAllPictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.uncheckAllPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttonuncheckall));
        }

        private void uncheckAllPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.uncheckAllPictureBox.Image = ((System.Drawing.Image)(Properties.Resources.buttonuncheckall1));
        }

        private void uncheckAllPictureBox_Click(object sender, EventArgs e)
        {
            iReport451CheckBox.Checked = false;
            sevenZipCheckBox.Checked = false;
            nPlusPlusCheckBox.Checked = false;
            virtualBoxCheckBox.Checked = false;
            jaspersoftStudioCheckBox.Checked = false;
            greenshotCheckBox.Checked = false;
            filezillaCheckBox.Checked = false;
            puttyCheckBox.Checked = false;
            winSCPCheckBox.Checked = false;
        }
    }
}

