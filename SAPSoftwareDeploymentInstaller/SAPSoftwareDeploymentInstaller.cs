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

        private void installButton_Click(object sender, EventArgs e)
        {
            if(progressBar.Value >0 && progressBar.Value < 100)
            {
                MessageBox.Show("Process is running, please wait.");
                return;
            }
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";
            System.IO.Directory.CreateDirectory(userDir);
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Creating temp directory: " + userDir + " ...Done.");

            string installerFilePath = userDir + @"\SAPSDI.cmd";

            if (iReport451CheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading iReport 4.5.1 ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://sapsoftwaredeployment.blob.core.windows.net/sapsdblob/iReport-4.5.1.zip"),
                        // Param2 = Path to save
                        userDir + @"\iReport-4.5.1.zip"
                    );
                }

                //using (FileStream fs = new FileStream(installerFilePath, FileMode.OpenOrCreate))
                //{
                //    using (TextWriter tw = new StreamWriter(fs))
                //    {
                //        tw.WriteLine("taskkill /IM DataAnalysisTool.exe /F");
                //        tw.WriteLine("cls");
                //        tw.WriteLine(@"C:\Windows\System32\runas.exe /user:ACTEKSOFT\" + cmdBuilderRichTextBox.Text + @" /netonly " + @"""" + user + @"\DataAnalysisTool.exe""");
                //        tw.WriteLine("exit");
                //    }
                //    System.Diagnostics.Process.Start(installerFilePath);
                //}
            }
            //System.IO.Directory.Delete(userDir);
        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    }
}
