using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SAPSoftwareDeploymentInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void installButton_Click(object sender, EventArgs e)
        {
            var processdir = Environment.SystemDirectory;
            System.IO.Directory.CreateDirectory(processdir + @"\ACTEKSOFT");
            string path = processdir + @"\ACTEKSOFT\LaunchWithACTEKSOFT.cmd";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    //tw.WriteLine(@"md C:\Program Files(x86)\CCDataTool\Data");
                    //tw.WriteLine("robocopy "+processdir+" "+@"""C:\Program Files (x86)\CCDataTool\Data"""+@" /MIR");
                    tw.WriteLine("taskkill /IM DataAnalysisTool.exe /F");
                    tw.WriteLine("cls");
                    tw.WriteLine(@"C:\Windows\System32\runas.exe /user:ACTEKSOFT\" + cmdBuilderRichTextBox.Text + @" /netonly " + @"""" + processdir + @"\DataAnalysisTool.exe""");
                    tw.WriteLine("exit");
                }
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
