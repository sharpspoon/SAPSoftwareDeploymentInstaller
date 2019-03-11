using IWshRuntimeLibrary;
using Microsoft.WindowsAzure.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPSoftwareDeploymentInstaller
{
    public partial class SAPSoftwareDeploymentInstaller : Form
    {
        public SAPSoftwareDeploymentInstaller()
        {
            InitializeComponent();
        }

        //global stuff


        private void installButton_Click(object sender, EventArgs e)
        {
            //check if any software is selected
            if (iReport451CheckBox.Checked == false && sevenZipCheckBox.Checked == false && nPlusPlusCheckBox.Checked == false && virtualBoxCheckBox.Checked == false)
            {
                MessageBox.Show("Please select a program from the list to the left.");
                return;
            }

            //disable the run abliity if running
            installButton.Enabled = false;

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

            //////////////////////////////////
            //CHECK WHICH ITEMS ARE SELECTED//
            //////////////////////////////////

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
                if (sixtyFourBitOperatingSystem == true)
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
                    }
                }
                else
                {
                    installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading 7zip 32-bit ....");

                    using (WebClient wc3 = new WebClient())
                    {
                        wc3.DownloadProgressChanged += wc_DownloadProgressChanged;
                        wc3.DownloadFileAsync(
                            // Param1 = Link of file
                            //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                            new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/7zip/7z1900.exe"),
                            // Param2 = Path to save
                            userDir + @"\7z1900.exe"
                        );
                    }
                }
            }

            /////////////////
            //N++////////////
            /////////////////
            if (nPlusPlusCheckBox.Checked == true)
            {
                if (sixtyFourBitOperatingSystem == true)
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
                    }
                }
                else
                {
                    installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading Notepad++ 32-bit ....");

                    using (WebClient wc4 = new WebClient())
                    {
                        wc4.DownloadProgressChanged += wc4_DownloadProgressChanged;
                        wc4.DownloadFileAsync(
                            // Param1 = Link of file
                            //new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/test.zip"),//testing
                            new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/npp/npp.7.6.4.Installer.exe"),
                            // Param2 = Path to save
                            userDir + @"\npp.7.6.4.Installer.exe"
                        );
                    }
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
                }

                string startPath = userDir+@"/zip";
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
                }
            }
        }

        void wc3_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e3)
        {

            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "7zip")
                    row.Cells[1].Value = e3.ProgressPercentage + @"%";
            }

            if (e3.ProgressPercentage == 100)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == "7zip")
                        row.Cells[1].Value = "complete!";
                }

                string installerFilePath = userDir + @"\7zip.cmd";
                bool sixtyFourBitOperatingSystem = System.Environment.Is64BitOperatingSystem;
                if (sixtyFourBitOperatingSystem == true)
                {
                    using (FileStream fs = new FileStream(installerFilePath, FileMode.OpenOrCreate))
                    {
                        using (TextWriter tw = new StreamWriter(fs))
                        {
                            tw.WriteLine(userDir+ @"\7z1900-x64.exe /S /D=""C:\Program Files\7-Zip""");
                            tw.WriteLine("exit");
                        }
                    }
                    System.Diagnostics.Process.Start(installerFilePath);
                }
                else
                {
                    using (FileStream fs = new FileStream(installerFilePath, FileMode.OpenOrCreate))
                    {
                        using (TextWriter tw = new StreamWriter(fs))
                        {
                            tw.WriteLine(userDir + @"\7z1900.exe /S /D=""C:\Program Files (x86)\7-Zip""");
                            tw.WriteLine("exit");
                            //tw.WriteLine("pause");
                        }
                    }
                    System.Diagnostics.Process.Start(installerFilePath);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == "7zip")
                        row.Cells[2].Value = "complete!";
                }


            }
        }

        void wc4_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e4)
        {

            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "N++")
                    row.Cells[1].Value = e4.ProgressPercentage + @"%";
            }

            if (e4.ProgressPercentage == 100)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == "N++")
                        row.Cells[1].Value = "complete!";
                }

                string installerFilePath = userDir + @"\Npp.cmd";
                bool sixtyFourBitOperatingSystem = System.Environment.Is64BitOperatingSystem;
                if (sixtyFourBitOperatingSystem == true)
                {
                    using (FileStream fs = new FileStream(installerFilePath, FileMode.OpenOrCreate))
                    {
                        using (TextWriter tw = new StreamWriter(fs))
                        {
                            tw.WriteLine(userDir + @"\npp.7.6.4.Installer.x64.exe /S");
                            tw.WriteLine("exit");
                        }
                    }
                    System.Diagnostics.Process.Start(installerFilePath);
                }
                else
                {
                    using (FileStream fs = new FileStream(installerFilePath, FileMode.OpenOrCreate))
                    {
                        using (TextWriter tw = new StreamWriter(fs))
                        {
                            tw.WriteLine(userDir + @"\npp.7.6.4.Installer.exe /S");
                            tw.WriteLine("exit");
                        }
                    }
                    System.Diagnostics.Process.Start(installerFilePath);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == "N++")
                        row.Cells[2].Value = "complete!";
                }


            }
        }

        void wc5_DownloadProgressChanged(object sender2, DownloadProgressChangedEventArgs e5)
        {

            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "VirtualBox")
                    row.Cells[1].Value = e5.ProgressPercentage + @"%";
            }

            if (e5.ProgressPercentage == 100)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == "VirtualBox")
                        row.Cells[1].Value = "complete!";
                }

                string installerFilePath = userDir + @"\VirtualBox.cmd";

                using (FileStream fs = new FileStream(installerFilePath, FileMode.OpenOrCreate))
                {
                    using (TextWriter tw = new StreamWriter(fs))
                    {
                        tw.WriteLine(@"msiexec /i "+userDir + @"\VirtualBox-6.0.4-r128413-MultiArch_amd64.msi /quiet /qn /norestart ALLUSERS=2");
                        tw.WriteLine("exit");
                    }
                }
                System.Diagnostics.Process.Start(installerFilePath);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == "VirtualBox")
                        row.Cells[2].Value = "complete!";
                }


            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sapLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sap.com");
        }
    }
}
