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
        string user = Environment.UserName;
        string userDir = @"C:\Users\" + Environment.UserName + @"\SAPSDITemp";
        string sevenZipInstaller = "7z1900-x64.exe";
        string nppInstaller = "npp.7.6.4.Installer.x64.exe";
        string jaspersoftInstaller = "TIB_js-studiocomm_6.6.0_windows_x86_64.exe";
        string filezillaInstaller = "FileZilla_3.41.1_win64-setup.exe";
        string greenshotInstaller = "Greenshot-INSTALLER-1.2.10.6-RELEASE.exe";
        string puttyInstaller = "putty-64bit-0.71-installer.msi";
        string winscpInstaller = "WinSCP-5.13.9-Setup.exe";
        string autoHotkeyInstaller = "AutoHotkey_1.1.30.01.zip";
        string beyondCompareInstaller = "BCompare-4.2.9.23626.exe";
        string evernoteInstaller = "Evernote_6.17.6.8292.exe";
        string lightshotInstaller = "setup-lightshot.exe";
        string mailbirdInstaller = "MailbirdInstaller.exe";
        string snagitInstaller = "snagit.exe";
        string postmanInstaller = "Postman-win64-7.0.6-Setup.exe";
        string screenpressoInstaller = "Screenpresso.exe";
        string slackInstaller = "SlackSetup.exe";
        string chromeInstaller = "ChromeSetup.exe";
        string oracleInstaller = "";
        string soapInstaller = "SoapUI-x32-5.5.0.exe";
        string sublimeInstaller = "Sublime Text Build 3200 x64 Setup.exe";
        string textpadInstaller = "txpeng812-64.zip";
        string toadInstaller = "";
        string tomcatInstaller = "";
        string trelloInstaller = "";
        string visioInstaller = "";
        string vscodeInstaller = "";
        string winmergeInstaller = "WinMerge-2.16.0-Setup.exe";





        private void installButton_Click(object sender, EventArgs e)
        {
            //check if any software is selected
            if (iReport451CheckBox.Checked == false && 
                sevenZipCheckBox.Checked == false && 
                nPlusPlusCheckBox.Checked == false && 
                virtualBoxCheckBox.Checked == false && 
                jaspersoftStudioCheckBox.Checked == false && 
                greenshotCheckBox.Checked == false && 
                filezillaCheckBox.Checked == false && 
                puttyCheckBox.Checked == false && 
                winSCPCheckBox.Checked == false &&
                autoHotkeyCheckBox.Checked == false &&
                beyondCompareCheckBox.Checked == false &&
                evernoteCheckBox.Checked == false &&
                lightshotCheckBox.Checked == false &&
                mailbirdCheckBox.Checked == false &&
                snagitCheckBox.Checked == false &&
                postmanCheckBox.Checked == false &&
                screenpressoCheckBox.Checked == false &&
                slackCheckBox.Checked == false &&
                chromeCheckBox.Checked == false &&
                oracleCheckBox.Checked == false &&
                soapCheckBox.Checked == false &&
                sublimeCheckBox.Checked == false &&
                textpadCheckBox.Checked == false &&
                toadCheckBox.Checked == false &&
                tomcatCheckBox.Checked == false &&
                trelloCheckBox.Checked == false &&
                visioCheckBox.Checked == false &&
                vscodeCheckBox.Checked == false &&
                winmergeCheckBox.Checked == false)
            {
                MessageBox.Show("Must select at least one program to install.", "SAP Software Deployment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (progressBar1.Value != 0 && progressBar1.Value != 100)
            {
                MessageBox.Show("Process is currently running!", "SAP Software Deployment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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

            /////////////////
            //WINSCP/////////
            /////////////////
            if (winSCPCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("WinSCP", Resources.filedownload);
            }

            /////////////////
            //AUTOHOTKEY/////
            /////////////////
            if (autoHotkeyCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("AutoHotkey", Resources.filedownload);
            }

            /////////////////
            //BEYONDCOMPARE//
            /////////////////
            if (beyondCompareCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Beyond Compare", Resources.filedownload);
            }

            /////////////////
            //EVERNOTE///////
            /////////////////
            if (evernoteCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Evernote", Resources.filedownload);
            }

            /////////////////
            //LIGHTSHOT//////
            /////////////////
            if (lightshotCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Lightshot", Resources.filedownload);
            }

            /////////////////
            //MAILBIRD///////
            /////////////////
            if (mailbirdCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Mail Bird", Resources.filedownload);
            }

            /////////////////
            //SNAGIT/////////
            /////////////////
            if (snagitCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Snag-It", Resources.filedownload);
            }

            /////////////////
            //POSTMAN////////
            /////////////////
            if (postmanCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Postman", Resources.filedownload);
            }

            /////////////////
            //SCREENPRESSO///
            /////////////////
            if (screenpressoCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("ScreenPresso", Resources.filedownload);
            }

            /////////////////
            //SLACK//////////
            /////////////////
            if (slackCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Slack", Resources.filedownload);
            }

            /////////////////
            //CHROME/////////
            /////////////////
            if (chromeCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Chrome", Resources.filedownload);
            }

            /////////////////
            //ORACLE/////////
            /////////////////
            if (oracleCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Oracle", Resources.filedownload);
            }

            /////////////////
            //SOAPUI/////////
            /////////////////
            if (soapCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Soap UI", Resources.filedownload);
            }

            /////////////////
            //SUBLIME////////
            /////////////////
            if (sublimeCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Sublime", Resources.filedownload);
            }

            /////////////////
            //TEXTPAD////////
            /////////////////
            if (textpadCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("TextPad", Resources.filedownload);
            }

            /////////////////
            //TOAD///////////
            /////////////////
            if (toadCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Toad", Resources.filedownload);
            }

            /////////////////
            //TOMCAT/////////
            /////////////////
            if (tomcatCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("TomCat", Resources.filedownload);
            }

            /////////////////
            //TRELLO/////////
            /////////////////
            if (trelloCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Trello", Resources.filedownload);
            }

            /////////////////
            //VISIO//////////
            /////////////////
            if (visioCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Visio", Resources.filedownload);
            }

            /////////////////
            //VSCODE/////////
            /////////////////
            if (vscodeCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("VS Code", Resources.filedownload);
            }

            /////////////////
            //WINMERGE///////
            /////////////////
            if (winmergeCheckBox.Checked == true)
            {
                dataGridView1.Rows.Add("Winmerge", Resources.filedownload);
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

            /////////////////
            //WINSCP/////////
            /////////////////
            if (winSCPCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/winscp/" + winscpInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + winscpInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted10;
                }
            }


            /////////////////
            //AUTOHOTKEY/////
            /////////////////
            if (autoHotkeyCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + autoHotkeyInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/autohotkey/" + autoHotkeyInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + autoHotkeyInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted11;
                }
            }

            /////////////////
            //BEYONDCOMPARE//
            /////////////////
            if (beyondCompareCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + beyondCompareInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/beyondcompare/" + beyondCompareInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + autoHotkeyInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted12;
                }
            }

            /////////////////
            //EVERNOTE///////
            /////////////////
            if (evernoteCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + evernoteInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/evernote/" + evernoteInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + evernoteInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted13;
                }
            }

            /////////////////
            //LIGHTSHOT//////
            /////////////////
            if (lightshotCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + lightshotInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/lightshot/" + lightshotInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + lightshotInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted14;
                }
            }

            /////////////////
            //MAILBIRD///////
            /////////////////
            if (mailbirdCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + mailbirdInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/mailbird/" + mailbirdInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + mailbirdInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted15;
                }
            }

            /////////////////
            //SNAGIT/////////
            /////////////////
            if (snagitCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + snagitInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/snagit/" + snagitInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + snagitInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted16;
                }
            }

            /////////////////
            //POSTMAN////////
            /////////////////
            if (postmanCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + postmanInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/postman/" + postmanInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + postmanInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted17;
                }
            }

            /////////////////
            //SCREENPRESSO///
            /////////////////
            if (screenpressoCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + screenpressoInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/screenpresso/" + screenpressoInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + screenpressoInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted18;
                }
            }

            /////////////////
            //SLACK//////////
            /////////////////
            if (slackCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + slackInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/slack/" + slackInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + slackInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted19;
                }
            }

            /////////////////
            //CHROME/////////
            /////////////////
            if (chromeCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + chromeInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/chrome/" + chromeInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + chromeInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted20;
                }
            }

            /////////////////
            //ORACLE/////////
            /////////////////
            if (oracleCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + oracleInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/oracle/" + oracleInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + oracleInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted21;
                }
            }

            /////////////////
            //SOAP///////////
            /////////////////
            if (soapCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + soapInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/soap/" + soapInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + soapInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted22;
                }
            }

            /////////////////
            //SUBLIME////////
            /////////////////
            if (sublimeCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + sublimeInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/sublime/" + sublimeInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + sublimeInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted23;
                }
            }

            /////////////////
            //TEXTPAD////////
            /////////////////
            if (textpadCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + textpadInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/textpad/" + textpadInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + textpadInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted24;
                }
            }

            /////////////////
            //TOAD///////////
            /////////////////
            if (toadCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + toadInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/toad/" + toadInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + toadInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted25;
                }
            }

            /////////////////
            //TOMCAT/////////
            /////////////////
            if (tomcatCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + tomcatInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/tomcat/" + tomcatInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + tomcatInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted26;
                }
            }

            /////////////////
            //TRELLO/////////
            /////////////////
            if (trelloCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + trelloInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/trello/" + trelloInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + trelloInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted27;
                }
            }

            /////////////////
            //VISIO//////////
            /////////////////
            if (visioCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + visioInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/visio/" + visioInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + visioInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted28;
                }
            }

            /////////////////
            //VSCODE/////////
            /////////////////
            if (vscodeCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + vscodeInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/vscode/" + vscodeInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + vscodeInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted29;
                }
            }

            /////////////////
            //WINMERGE///////
            /////////////////
            if (winmergeCheckBox.Checked == true)
            {
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winmergeInstaller + " ....");

                using (WebClient wc = new WebClient())
                {
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(
                        // Param1 = Link of file
                        new System.Uri("https://wardr.net/sapsdi/winmerge/" + winmergeInstaller),
                        // Param2 = Path to save
                        userDir + @"\" + winmergeInstaller
                    );
                    wc.DownloadFileCompleted += DownloadCompleted30;
                }
            }
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        /////////////////
        //IREPORT////////
        /////////////////
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

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted10(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder10();
                }
            }
        }
        private void ProcessFolder10()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted11(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder11();
                }
            }
        }
        private void ProcessFolder11()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted12(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder12();
                }
            }
        }
        private void ProcessFolder12()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted13(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder13();
                }
            }
        }
        private void ProcessFolder13()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted14(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder14();
                }
            }
        }
        private void ProcessFolder14()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted15(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder15();
                }
            }
        }
        private void ProcessFolder15()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted16(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder16();
                }
            }
        }
        private void ProcessFolder16()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted17(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder17();
                }
            }
        }
        private void ProcessFolder17()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted18(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder18();
                }
            }
        }
        private void ProcessFolder18()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted19(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder19();
                }
            }
        }
        private void ProcessFolder19()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted20(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder20();
                }
            }
        }
        private void ProcessFolder20()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted21(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder21();
                }
            }
        }
        private void ProcessFolder21()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted22(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder22();
                }
            }
        }
        private void ProcessFolder22()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted23(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder23();
                }
            }
        }
        private void ProcessFolder23()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted24(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder24();
                }
            }
        }
        private void ProcessFolder24()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted25(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder25();
                }
            }
        }
        private void ProcessFolder25()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted26(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder26();
                }
            }
        }
        private void ProcessFolder26()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted27(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder27();
                }
            }
        }
        private void ProcessFolder27()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted28(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder28();
                }
            }
        }
        private void ProcessFolder28()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted29(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder29();
                }
            }
        }
        private void ProcessFolder29()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //WINSCP/////////
        /////////////////
        private void DownloadCompleted30(object sender, AsyncCompletedEventArgs e)
        {
            installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Downloading " + winscpInstaller + " ....Done.");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == "WinSCP")
                {
                    row.Cells[1].Value = Resources.checkgreen;
                    ProcessFolder30();
                }
            }
        }
        private void ProcessFolder30()
        {
            //install temp user directory
            var user = Environment.UserName;
            var userDir = @"C:\Users\" + user + @"\SAPSDITemp";

            if (Directory.GetFiles(userDir, "WinSCP*.exe").Length > 0)
            {
                //int count = Directory.GetFiles(userDir, "*.*").Length;
                string[] files = Directory.GetFiles(userDir, "WinSCP*.exe*");

                foreach (var file in files)
                {
                    var fileName = System.IO.Path.GetFileName(file);
                    var fileNameWithPath = userDir + "\\" + fileName;
                    var argumentList = @"'/VERYSILENT /NOREBOOT'";
                    //Deploy application  
                    DeployApplications(fileNameWithPath, fileName, argumentList);
                }
                installLogRichTextBox.Text = installLogRichTextBox.Text.Insert(0, Environment.NewLine + DateTime.Now + ">>>   Installing " + winscpInstaller + " ....Done.");
            }
        }

        /////////////////
        //DEPLOYAPPS/////
        /////////////////
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

        ///////////////////////////////////
        //END OF DOWNLOADINSTALL LOGIC/////
        ///////////////////////////////////
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
                    try
                    {
                        Directory.Delete(userDir, true);
                        Environment.Exit(0);
                    }
                    catch
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    e.Cancel = true;
                }
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
            autoHotkeyCheckBox.Checked = true;
            beyondCompareCheckBox.Checked = true;
            evernoteCheckBox.Checked = true;
            lightshotCheckBox.Checked = true;
            mailbirdCheckBox.Checked = true;
            snagitCheckBox.Checked = true;
            postmanCheckBox.Checked = true;
            screenpressoCheckBox.Checked = true;
            slackCheckBox.Checked = true;
            chromeCheckBox.Checked = true;
            oracleCheckBox.Checked = true;
            soapCheckBox.Checked = true;
            sublimeCheckBox.Checked = true;
            textpadCheckBox.Checked = true;
            toadCheckBox.Checked = true;
            tomcatCheckBox.Checked = true;
            trelloCheckBox.Checked = true;
            visioCheckBox.Checked = true;
            vscodeCheckBox.Checked = true;
            winmergeCheckBox.Checked = true;
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
            autoHotkeyCheckBox.Checked = false;
            beyondCompareCheckBox.Checked = false;
            evernoteCheckBox.Checked = false;
            lightshotCheckBox.Checked = false;
            mailbirdCheckBox.Checked = false;
            snagitCheckBox.Checked = false;
            postmanCheckBox.Checked = false;
            screenpressoCheckBox.Checked = false;
            slackCheckBox.Checked = false;
            chromeCheckBox.Checked = false;
            oracleCheckBox.Checked = false;
            soapCheckBox.Checked = false;
            sublimeCheckBox.Checked = false;
            textpadCheckBox.Checked = false;
            toadCheckBox.Checked = false;
            tomcatCheckBox.Checked = false;
            trelloCheckBox.Checked = false;
            visioCheckBox.Checked = false;
            vscodeCheckBox.Checked = false;
            winmergeCheckBox.Checked = false;
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

        private void winSCPCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.winSCPCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void winSCPCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.winSCPCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void winSCPCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.winSCPCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void winSCPCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.winSCPCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void autoHotkeyCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.autoHotkeyCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void autoHotkeyCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.autoHotkeyCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void autoHotkeyCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.autoHotkeyCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void autoHotkeyCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.autoHotkeyCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void beyondCompareCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.beyondCompareCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void beyondCompareCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.beyondCompareCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void beyondCompareCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.beyondCompareCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void beyondCompareCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.beyondCompareCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void evernoteCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.evernoteCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void evernoteCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.evernoteCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void evernoteCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.evernoteCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void evernoteCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.evernoteCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void lightshotCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.lightshotCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void lightshotCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.lightshotCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void lightshotCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.lightshotCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void lightshotCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.lightshotCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void mailbirdCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.mailbirdCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void mailbirdCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.mailbirdCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void mailbirdCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.mailbirdCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void mailbirdCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.mailbirdCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void snagitCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.snagitCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void snagitCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.snagitCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void snagitCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.snagitCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void snagitCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.snagitCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void postmanCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.postmanCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void postmanCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.postmanCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void postmanCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.postmanCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void postmanCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.postmanCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void screenpressoCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.screenpressoCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void screenpressoCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.screenpressoCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void screenpressoCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.screenpressoCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void screenpressoCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.screenpressoCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void slackCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.slackCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void slackCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.slackCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void slackCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.slackCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void slackCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.slackCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void chromeCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.chromeCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void chromeCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.chromeCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void chromeCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.chromeCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void chromeCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.chromeCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void oracleCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.oracleCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void oracleCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.oracleCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void oracleCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.oracleCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void oracleCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.oracleCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void soapCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.soapCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void soapCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.soapCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void soapCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.soapCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void soapCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.soapCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void sublimeCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.sublimeCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void sublimeCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.sublimeCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void sublimeCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.sublimeCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void sublimeCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.sublimeCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void textpadCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.textpadCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void textpadCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.textpadCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void textpadCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.textpadCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void textpadCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.textpadCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void toadCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.toadCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void toadCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.toadCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void toadCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.toadCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void toadCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.toadCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void tomcatCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.tomcatCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void tomcatCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.tomcatCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void tomcatCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.tomcatCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void tomcatCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.tomcatCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void trelloCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.trelloCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void trelloCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.trelloCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void trelloCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.trelloCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void trelloCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.trelloCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void visioCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.visioCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void visioCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.visioCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void visioCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.visioCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void visioCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.visioCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void vscodeCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.vscodeCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void vscodeCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.vscodeCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void vscodeCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.vscodeCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void vscodeCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.vscodeCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void winmergeCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.winmergeCheckBox.Font = new Font("Calibri", 8, FontStyle.Bold);
        }

        private void winmergeCheckBox_MouseEnter(object sender, EventArgs e)
        {
            this.winmergeCheckBox.Font = new Font("Calibri", 11, FontStyle.Bold);
        }

        private void winmergeCheckBox_MouseLeave(object sender, EventArgs e)
        {
            this.winmergeCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }

        private void winmergeCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.winmergeCheckBox.Font = new Font("Calibri", 9, FontStyle.Bold);
        }
    }
}