using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Security.Principal;
using System.Threading;

namespace SQLToolsDiag
{
    public partial class fSQLToolsDiag : Form
    {
        static string baseDirectory = @"c:\SQLToolsDiag";
        readonly string SQLToolsDiagDir = baseDirectory + @"\SQLToolsDiag";
        readonly string SQLToolsDiagZip = baseDirectory + @"\SQLToolsDiag.zip";
        readonly string TempFolder = Environment.CurrentDirectory = Environment.GetEnvironmentVariable("temp");
        private bool SSDTCapture = false;

        public static bool IsAdmin()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

        //public static bool CanRunLogman()
        //{
        //    return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
        //              .IsInRole(WindowsBuiltInRole);
        //}

        public fSQLToolsDiag()
        {
            InitializeComponent();
        }

        public void stopMarquee(string msg)
        {
            tsslStatus.Text = msg; // "SSMS Started";
            tspbProcess.Value = 100;
        }
        #region SSMS


        private void StartSSSMSLogging()
        {
            tsslStatus.Text = "Starting SSMS";
            
            bwStartSSMS.RunWorkerAsync();

        }

        /*
         * Background worker to start SSMS, so the main thread will be responsive 
         */
        private void bwStartSSMS_DoWork(object sender, DoWorkEventArgs e)
        {
            
            startSSMS();
        }

        /*
         * Invokes SSMS with logging options
         */
        private void startSSMS()
        {
            string location = getSSMSLocation();
            Process.Start(location, "-log " + SQLToolsDiagDir +@"\SSMSLog.xml");
        }

        /*
         * Read the registry to get the install folder for SSMS
         */
        private string getSSMSLocation()
        {
            string ret = "";
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\SQL Server Management Studio\18.0_IsoShell_Config");
                {
                    if (key != null)
                    {
                        Object o = key.GetValue("InstallDir");
                        if (o != null)
                        {
                            ret = (o as String);
                            ret += @"\Common7\IDE\ssms.exe";
                        }
                    }
                }
               
                key.Close();
            }
            catch (Exception ex)  
            {
                
            }
            return ret;
        }

        private void bwStartSSMS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopMarquee("SSMS Started");
        }

        private void btnCollectSSMSInstallLogs_Click(object sender, EventArgs e)
        {
            CollectSSMSInstallLogs();
        }

        private void CollectSSMSInstallLogs()
        {
            tsslStatus.Text = "Copying SSMS Setup files";
            //tspbProcess.MarqueeAnimationSpeed = 30;
            bwCopyFiles.RunWorkerAsync("SSMS");
        }


        #endregion


        private void fSQLToolsDiag_Shown(object sender, EventArgs e)
        {
            this.Text = this.Text + " - Version " + Application.ProductVersion;
            //checks if the folder exists, else it creates it
            bool createDir = true;
            try
            {
                if (Directory.Exists(SQLToolsDiagDir))
                {
                    if (MessageBox.Show("There is already a folder for the data collection, would you like to replace it?", "SQLToolsDiag", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Directory.Delete(SQLToolsDiagDir, true);
                    }
                    else
                    {
                        createDir = false;
                    }
                }
                if (createDir)
                {
                    Directory.CreateDirectory(SQLToolsDiagDir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error occurred while creating the collection folder. Check windows log for more details.", "SQLToolsDiag", MessageBoxButtons.OK, MessageBoxIcon.Error);
                WriteEventLog(ex.Message, EventLogEntryType.Error);
            }
        }

        private void WriteEventLog(string Message, EventLogEntryType type) {
            string destinationLog = "Application";
            /*
             If this fails with a message that says that it can't access all the logs and mentions the security log, 
             Run Visual Studio as Admin.
             */

            if (!System.Diagnostics.EventLog.SourceExists(Application.ProductName))
            {
                System.Diagnostics.EventLog.CreateEventSource(Application.ProductName, destinationLog);
            }
            EventLog el = new EventLog(destinationLog);
            el.Source = Application.ProductName;
            el.WriteEntry(Message,type);
        }

        private void resetProgressBar() {
            tspbProcess.Value = 0;
        }

     /*   private void //DisplaySSDTLog(bool visible) {
            txSSDTLogMan.Visible = visible;
            btnCopy.Visible = visible;
        }*/

        private void LabelSetupFiles() {
            lblSSDTLog.Text = Environment.NewLine + "1. If done, click on 'Zip Everything' and upload the " +
                                    Environment.NewLine + "zip file to the case's sharing space";
            //DisplaySSDTLog(false);
        }

        #region Copy Setup Files
        private void bwCopyFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            string folder = "";
            string fileStartsWith = "";
            switch (e.Argument)
            {
                case "SSMS":
                    folder = TempFolder + @"\ssmssetup";
                    break;
                case "SSDT":
                    folder = TempFolder + @"\SsdtSetup";
                    break;
                case "IS":
                    folder = TempFolder + @"\SsdtisSetup";
                    break;
                case "VSIX":
                    folder = TempFolder;
                    fileStartsWith = "dd_VSIXInstaller_";
                    break;
                case "SSDT15":
                    folder = TempFolder;
                    fileStartsWith = "sql_SSDT_";
                    break;
                case "DEA":
                    folder = TempFolder + @"\DEA";
                    break;
                case "DEASetup":
                    folder = TempFolder;
                    fileStartsWith = "Database_Experimentation_Assistant_";
                    break;
                case "DMA":
                    break;
                case "SSMA":
                    break;
            }
            CopySetupLogs(folder, fileStartsWith);
        }

        public void CopySetupLogs(string setupDir, string fileStartsWith)
        {
            if (fileStartsWith == "")
            {
                foreach (string dirPath in Directory.GetDirectories(setupDir, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(setupDir, SQLToolsDiagDir));
                }
                foreach (string newPath in Directory.GetFiles(setupDir, "*.*", SearchOption.TopDirectoryOnly))
                {
                    File.Copy(newPath, newPath.Replace(setupDir, SQLToolsDiagDir), true);
                }
            }
            else {
                foreach (string newPath in Directory.GetFiles(setupDir, fileStartsWith +"*.*", SearchOption.TopDirectoryOnly))
                {
                    File.Copy(newPath, newPath.Replace(setupDir, SQLToolsDiagDir), true);
                }
            }
            
        }

        private void bwCopyFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopMarquee("Files copied!");
        }

        #endregion
        #region SSDT
        private void btnCollectSSDTInstallLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("SSDT");
        }


        private void btnVSIXSetupLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("VSIX");
        }

        private void btnSSISSetupLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("IS");
        }

        private void btnSSDTSetupLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("SSDT");
        }

        private void btn2015SetupLogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("SSDT15");
        }

        private void btnStartSSDTLogging_Click(object sender, EventArgs e)
        {
            StartSSDTLogging();
        }
        private void StartSSDTLogging()
        {
            try
            {
                SSDTCapture = true;

                string createDacFxTrace = "logman.exe create trace -n DacFxDebug -p \"Microsoft-SQLServerDataTools\" 0x800 -o \"" + SQLToolsDiagDir + "\\DacFxDebug.etl\" -ets";
                string createSSDTTrace  = "logman.exe create trace -n SSDTDebug  -p \"Microsoft-SQLServerDataToolsVS\" 0x800 -o \"" + SQLToolsDiagDir + "\\SSDTDebug.etl\" -ets";
                txSSDTLogMan.Text = createDacFxTrace;
                txSSDTLogMan.Text += Environment.NewLine;
                txSSDTLogMan.Text += createSSDTTrace;
                txSSDTLogMan.Text += Environment.NewLine;
                //Thread.Sleep(250);
                // Process p1 = Process.Start("logman.exe", createDacFxTrace);
                //int pExit = p1.ExitCode;
                //Thread.Sleep(250);               
                //Process p2 = Process.Start("logman.exe", createSSDTTrace);
                //int pExit2 = p2.ExitCode;
            }
            catch (Exception ex) { 
            
            }
            
        }

        public bool IsSSDTTraceTaken()
        {
             return (Directory.EnumerateFileSystemEntries(SQLToolsDiagDir, "*.etl") != null);
        }

        private void StopSSDTLogging()
        {
            SSDTCapture = false;

            txSSDTLogMan.Text = "Logman.exe stop DacFxDebug -ets";
            txSSDTLogMan.Text += Environment.NewLine;
            txSSDTLogMan.Text += "Logman.exe stop SSDTDebug -ets";
            txSSDTLogMan.Text += Environment.NewLine;

            //Process.Start("cmd.exe", "/c Logman.exe stop DacFxDebug -ets");
            //Process.Start("cmd.exe", "/c Logman.exe stop SSDTDebug -ets");
            if (!IsSSDTTraceTaken()) {
                MessageBox.Show("The SSDT trace was not collected, please retart your machine and try again", "SQLToolsDiag", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStopSSDTLogging_Click(object sender, EventArgs e)
        {
            StopSSDTLogging();
        }

        #endregion

        #region DEA
        private void btnDEASetup_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("DEASetup");
        }

        private void btnDEALogs_Click(object sender, EventArgs e)
        {
            bwCopyFiles.RunWorkerAsync("DEA");
        }


        #endregion

        private void btnZipCapture_Click(object sender, EventArgs e)
        {
            ZipCapture();

        }

        private void ZipCapture()
        {
            if (!File.Exists(SQLToolsDiagZip))
            {
                ZipFile.CreateFromDirectory(SQLToolsDiagDir, SQLToolsDiagZip);
            }
            else
            {
                if (MessageBox.Show("There is already a zipped file generated, do you want to overwrite it?", "SQLToolsDiag", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    File.Delete(SQLToolsDiagZip);
                    ZipFile.CreateFromDirectory(SQLToolsDiagDir, SQLToolsDiagZip);
                }
            }
            Process.Start("Explorer.exe", baseDirectory);

        }

        private void startSSMSWithLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetProgressBar();
            //DisplaySSDTLog(false);
            StartSSSMSLogging();
            lblSSDTLog.Text = "1. Wait for SSMS to start";
            lblSSDTLog.Text += Environment.NewLine + "2. Reproduce your issue";
            lblSSDTLog.Text += Environment.NewLine + "3. Close SSMS";
            lblSSDTLog.Text += Environment.NewLine + "4. If done, click on 'Zip Everything' and upload the " + 
                                Environment.NewLine + "zip file to the case's sharing space";
        }

        private void collectSSMSInstallLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetProgressBar();
            LabelSetupFiles();
            CollectSSMSInstallLogs();
        }

        private void startSSDTLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopSSDTLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            resetProgressBar();
            LabelSetupFiles();
            bwCopyFiles.RunWorkerAsync("SSDT15");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            resetProgressBar();
            LabelSetupFiles();
            bwCopyFiles.RunWorkerAsync("SSDT");
        }

        private void collectISSetupLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetProgressBar();
            LabelSetupFiles();
            bwCopyFiles.RunWorkerAsync("IS");
        }

        private void collectASRSSetupLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetProgressBar();
            LabelSetupFiles();
            bwCopyFiles.RunWorkerAsync("VSIX");
        }

        private void collectSetupLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetProgressBar();
            LabelSetupFiles();
            bwCopyFiles.RunWorkerAsync("DEASetup");
        }

        private void collectDEALogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetProgressBar();
            LabelSetupFiles();
            bwCopyFiles.RunWorkerAsync("DEA");
        }

        private void zipEverythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblSSDTLog.Text = "1. Upload the zipped file to the case's share space";
            //DisplaySSDTLog(false);
            ZipCapture();
        }

        private void fSQLToolsDiag_Load(object sender, EventArgs e)
        {
            if (!IsAdmin()) {
                MessageBox.Show("SQLToolsDiag needs to run as administrator, in order to have access to run the diagnostics", "SQLToolsDiag", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //WriteEventLog("SQLToolsDiag was not run as administrator", EventLogEntryType.Error);
                Application.Exit();
            }
            //DisplaySSDTLog(false);
        }

        private void fSQLToolsDiag_Close(object sender, EventArgs e)
        {
            if (SSDTCapture) {
                StopSSDTLogging();
            }
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
             Clipboard.SetText(txSSDTLogMan.Text);
        }

        private void stopLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startLoggingToolStripMenuItem.Enabled = true;
            stopLoggingToolStripMenuItem.Enabled = false;
            resetProgressBar();
            lblSSDTLog.Text = "1. The command was copied to your clipboard!";
            lblSSDTLog.Text += Environment.NewLine + "2. Paste the command on an elevated command prompt";
            StopSSDTLogging();
            btnCopy_Click(new object(), new EventArgs());
            
        }

        private void startLoggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startLoggingToolStripMenuItem.Enabled = false;
            stopLoggingToolStripMenuItem.Enabled = true;
            lblSSDTLog.Text = "1. The command was copied to your clipboard!";
            lblSSDTLog.Text += Environment.NewLine + "2. Open a command prompt as administrator"+ 
                                Environment.NewLine + "and paste the command";
            lblSSDTLog.Text += Environment.NewLine + "3. Open SSDT";
            lblSSDTLog.Text += Environment.NewLine + "4. Reproduce your issue";
            lblSSDTLog.Text += Environment.NewLine + "5. Click on the menu option for 'Stop SSDT Logging'" + 
                                Environment.NewLine + "once the issue is reproduced";
            resetProgressBar();
            StartSSDTLogging();
            btnCopy_Click(new object(), new EventArgs());
        }
    }
}


