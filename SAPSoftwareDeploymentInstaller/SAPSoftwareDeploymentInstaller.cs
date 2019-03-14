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

namespace SAPSoftwareDeploymentInstaller
{
    public partial class SAPSoftwareDeploymentInstaller : Form
    {
        public SAPSoftwareDeploymentInstaller()
        {
            InitializeComponent();
        }

        //global stuff

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
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
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
                dataGridView1.Rows.Add("iReport 4.5.1", "working...", "working...");
                //check if jre is installed
                string javaFile = @"C:\Program Files (x86)\Java\jre1.7.0_25\bin\java.exe";
                if (!System.IO.File.Exists(javaFile))
                {
                    dataGridView1.Rows.Add("jre1.7.0_25", "working...", "working...");
                }
            }

            /////////////////
            //7zip///////////
            /////////////////
            if (sevenZipCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("7zip", "working...", "working...");
            }

            /////////////////
            //N++////////////
            /////////////////
            if (nPlusPlusCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("N++", "working...", "working...");
            }

            /////////////////
            //VIRTUALBOX/////
            /////////////////
            if (virtualBoxCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("VirtualBox", "working...", "working...");
            }

            /////////////////
            //JASPERSOFT/////
            /////////////////
            if (jaspersoftStudioCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Jaspersoft Studio", "working...", "working...");
            }

            /////////////////
            //GREENSHOT//////
            /////////////////
            if (greenshotCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Greenshot", "working...", "working...");
            }

            /////////////////
            //FILEZILLA//////
            /////////////////
            if (filezillaCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("FileZilla", "working...", "working...");
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
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/ireport451/iReport-4.5.1.zip"),
                        // Param2 = Path to save
                        userDir + @"\iReport-4.5.1.zip"
                    );
                }

                string javaFile = @"C:\Program Files (x86)\Java\jre1.7.0_25\bin\java.exe";
                if (!System.IO.File.Exists(javaFile))
                {
                    installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading jre1.7.0_25 ....");
                    using (WebClient wc2 = new WebClient())
                    {
                        wc2.DownloadProgressChanged += wc2_DownloadProgressChanged;

                        wc2.DownloadFileAsync(
                            // Param1 = Link of file
                            new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/jre17025/Java.zip"),
                            // Param2 = Path to save
                            userDir + @"\Java.zip"
                        );
                    }
                }
            }

            /////////////////
            //7ZIP///////////
            /////////////////
            if (sevenZipCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading 7zip 64-bit ....");

                using (WebClient wc3 = new WebClient())
                {
                    wc3.DownloadProgressChanged += wc3_DownloadProgressChanged;
                    wc3.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/7zip/7z1900-x64.exe"),
                        // Param2 = Path to save
                        userDir + @"\7z1900-x64.exe"
                    );
                    wc3.DownloadFileCompleted += DownloadCompleted3;
                }
            }

            /////////////////
            //N++////////////
            /////////////////
            if (nPlusPlusCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading Notepad++ 64-bit ....");

                using (WebClient wc4 = new WebClient())
                {
                    wc4.DownloadProgressChanged += wc4_DownloadProgressChanged;
                    wc4.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/npp/npp.7.6.4.Installer.x64.exe"),
                        // Param2 = Path to save
                        userDir + @"\npp.7.6.4.Installer.x64.exe"
                    );
                    wc4.DownloadFileCompleted += DownloadCompleted4;
                }
            }

            /////////////////
            //VIRTUALBOX/////
            /////////////////
            if (virtualBoxCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading VirtualBox 64-bit ....");

                using (WebClient wc5 = new WebClient())
                {
                    wc5.DownloadProgressChanged += wc5_DownloadProgressChanged;
                    wc5.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/virtualbox/VirtualBox-6.0.4-r128413-MultiArch_amd64.msi"),
                        // Param2 = Path to save
                        userDir + @"\VirtualBox-6.0.4-r128413-MultiArch_amd64.msi"
                    );
                }

                using (WebClient wc5 = new WebClient())
                {
                    wc5.DownloadProgressChanged += wc5_DownloadProgressChanged;
                    wc5.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/virtualbox/common.cab"),
                        // Param2 = Path to save
                        userDir + @"\common.cab"
                    );
                    wc5.DownloadFileCompleted += DownloadCompleted5;
                }
            }

            /////////////////
            //JASPERSOFT/////
            /////////////////
            if (jaspersoftStudioCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading Jaspersoft Studio ....");

                using (WebClient wc6 = new WebClient())
                {
                    wc6.DownloadProgressChanged += wc6_DownloadProgressChanged;
                    wc6.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/jaspersoftstudio/TIB_js-studiocomm_6.6.0_windows_x86_64.exe"),
                        // Param2 = Path to save
                        userDir + @"\TIB_js-studiocomm_6.6.0_windows_x86_64.exe"
                    );
                    wc6.DownloadFileCompleted += DownloadCompleted6;
                }
            }

            /////////////////
            //GREENSHOT//////
            /////////////////
            if (greenshotCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading Greenshot ....");

                using (WebClient wc7 = new WebClient())
                {
                    wc7.DownloadProgressChanged += wc7_DownloadProgressChanged;
                    wc7.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/greenshot/Greenshot-INSTALLER-1.2.10.6-RELEASE.exe"),
                        // Param2 = Path to save
                        userDir + @"\Greenshot-INSTALLER-1.2.10.6-RELEASE.exe"
                    );
                    wc7.DownloadFileCompleted += DownloadCompleted7;
                }
            }

            /////////////////
            //FILEZILLA//////
            /////////////////
            if (filezillaCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading FileZilla ....");

                using (WebClient wc8 = new WebClient())
                {
                    wc8.DownloadProgressChanged += wc8_DownloadProgressChanged;
                    wc8.DownloadFileAsync(
                        // Param1 = Link of file
                        //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/filezilla/FileZilla_3.41.1_win64-setup.exe"),
                        // Param2 = Path to save
                        userDir + @"\FileZilla_3.41.1_win64-setup.exe"
                    );
                    wc8.DownloadFileCompleted += DownloadCompleted8;
                }
            }
            //System.IO.Directory.Delete(userDir);
        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "iReport 4.5.1")
                    row.Cells[1].Value = e.ProgressPercentage + @"%";
            }

            if (e.ProgressPercentage == 100)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == "iReport 4.5.1")
                        row.Cells[1].Value = "complete!";
                    if (row.Cells[1].Value.ToString() != "complete!")
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

                string startPath = userDir + @"/zip";
                string zipPath = userDir + @"\iReport-4.5.1.zip";
                string extractPath = @"C:\Program Files (x86)\Jaspersoft";
                System.IO.Directory.CreateDirectory(extractPath);


                try
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                }
                catch
                {
                    //create desktop shortcut
                    object shDesktop = (object)"Desktop";
                    WshShell shell = new WshShell();
                    string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\iReport 4.5.1.lnk";
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                    shortcut.Description = "Shortcut for iReport 4.5.1";
                    //shortcut.Hotkey = "Ctrl+Shift+N";
                    shortcut.TargetPath = @"C:\Program Files (x86)\Jaspersoft\iReport-4.5.1\bin\ireport.exe";
                    shortcut.Save();

                    //update install table
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == "iReport 4.5.1")
                            row.Cells[2].Value = "complete!";
                    }
                    installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing iReport 4.5.1 ....Done.");
                }
            }
        }

        void wc2_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e2)
        {
            
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "jre1.7.0_25")
                    row.Cells[1].Value = e2.ProgressPercentage + @"%";
            }

            if (e2.ProgressPercentage == 100)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == "jre1.7.0_25")
                        row.Cells[1].Value = "complete!";
                    if (row.Cells[1].Value.ToString() != "complete!")
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

                string startPath = userDir + @"/zip";
                string zipPath = userDir + @"\Java.zip";
                string extractPath = @"C:\Program Files (x86)";
                System.IO.File.SetAttributes(extractPath, FileAttributes.Normal);
                try
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, extractPath);
                }
                catch
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == "jre1.7.0_25")
                            row.Cells[2].Value = "complete!";
                    }
                    installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing jre1.7.0_25 ....Done.");
                }
            }
        }

        /////////////////
        //7ZIP///////////
        /////////////////
        void wc3_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e3)
        {
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "7zip")
                    row.Cells[1].Value = e3.ProgressPercentage + @"%";
            }
        }

        private void DownloadCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "7zip")
                {
                    row.Cells[1].Value = "complete!";
                    ProcessFolder3();
                }
                if (row.Cells[1].Value.ToString() != "complete!")
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
        private static void ProcessFolder3()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "7z*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "7z*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    //Deploy application  
                    Console.Read(); DeployApplications3(fileNameWithPath, fileName); Console.ReadLine();
                }
            }
        }

        public static void DeployApplications3(string executableFilePath, string fileName)
        {
            PowerShell powerShell = null;
            Console.WriteLine("Deploying application..." + executableFilePath);
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(@"$setup=Start-Process " + executableFilePath + @" -ArgumentList '/S /D=""C:\Program Files\7-Zip""' -Wait -PassThru");


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
        //N++////////////
        /////////////////
        void wc4_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e4)
        {
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "N++")
                    row.Cells[1].Value = e4.ProgressPercentage + @"%";
            }
        }

        private void DownloadCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "N++")
                {
                    row.Cells[1].Value = "complete!";
                    ProcessFolder4();
                }
                if (row.Cells[1].Value.ToString() != "complete!")
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
        private static void ProcessFolder4()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "npp*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "npp*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    //Deploy application  
                    Console.Read(); DeployApplications4(fileNameWithPath, fileName); Console.ReadLine();
                }
            }
        }

        public static void DeployApplications4(string executableFilePath, string fileName)
        {
            PowerShell powerShell = null;
            Console.WriteLine("Deploying application..." + executableFilePath);
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(@"$setup=Start-Process " + executableFilePath + @" -ArgumentList '/S /D=""C:\Program Files\7-Zip""' -Wait -PassThru");


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
        //VIRTUALBOX/////
        /////////////////
        void wc5_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e5)
        {
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "VirtualBox")
                    row.Cells[1].Value = e5.ProgressPercentage + @"%";
            }
        }

        private void DownloadCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "VirtualBox")
                {
                    row.Cells[1].Value = "complete!";
                    ProcessFolder5();
                }
                if (row.Cells[1].Value.ToString() != "complete!")
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
                    //Deploy application  
                    Console.Read(); DeployApplications5(fileNameWithPath, fileName); Console.ReadLine();
                }
            }
        }

        public static void DeployApplications5(string executableFilePath, string fileName)
        {
            PowerShell powerShell = null;
            Console.WriteLine("Deploying application..." + executableFilePath);
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(@"$setup=Start-Process " + executableFilePath + @" -ArgumentList '/quiet /qn /norestart ALLUSERS=2' -Wait -PassThru");


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
        //JASPERSOFT/////
        /////////////////
        void wc6_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e6)
        {
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Jaspersoft Studio")
                    row.Cells[1].Value = e6.ProgressPercentage + @"%";
            }
        }

        private void DownloadCompleted6(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Jaspersoft Studio")
                {
                    row.Cells[1].Value = "complete!";
                    ProcessFolder6();
                }
                if (row.Cells[1].Value.ToString() != "complete!")
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
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
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
                    row.Cells[1].Value = "complete!";
                    ProcessFolder7();
                }
                if (row.Cells[1].Value.ToString() != "complete!")
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
        void wc8_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e8)
        {
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "FileZilla")
                    row.Cells[1].Value = e8.ProgressPercentage + @"%";
            }
        }

        private void DownloadCompleted8(object sender, AsyncCompletedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "FileZilla")
                {
                    row.Cells[1].Value = "complete!";
                    ProcessFolder8();
                }
                if (row.Cells[1].Value.ToString() != "complete!")
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
                    //Deploy application  
                    Console.Read(); DeployApplications8(fileNameWithPath, fileName); Console.ReadLine();
                }
            }
        }

        public static void DeployApplications8(string executableFilePath, string fileName)
        {
            PowerShell powerShell = null;
            Console.WriteLine("Deploying application..." + executableFilePath);
            try
            {
                using (powerShell = PowerShell.Create())
                {
                    powerShell.AddScript(@"$setup=Start-Process " + executableFilePath + @" -ArgumentList '/NCRC /S /D=%ApplicationDir%' -Wait -PassThru");


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

