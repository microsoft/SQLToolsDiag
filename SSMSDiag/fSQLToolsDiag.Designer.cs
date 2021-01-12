namespace SQLToolsDiag
{
    partial class fSQLToolsDiag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSQLToolsDiag));
            this.btnStartSSSMSLogging = new System.Windows.Forms.Button();
            this.btnCollectSSMSInstallLogs = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnZipCapture = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn2015SetupLogs = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSSDTSetupLogs = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnVSIXSetupLogs = new System.Windows.Forms.Button();
            this.btnSSISSetupLogs = new System.Windows.Forms.Button();
            this.btnStopSSDTLogging = new System.Windows.Forms.Button();
            this.btnStartSSDTLogging = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnDEALogs = new System.Windows.Forms.Button();
            this.btnDEASetup = new System.Windows.Forms.Button();
            this.bwStartSSMS = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tspbProcess = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.bwCopyFiles = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sSMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSSMSWithLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectSSMSInstallLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startSSDTLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.collectISSetupLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectASRSSetupLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectSetupLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectDEALogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipEverythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSSDTLog = new System.Windows.Forms.Label();
            this.txSSDTLogMan = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.startLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartSSSMSLogging
            // 
            this.btnStartSSSMSLogging.Location = new System.Drawing.Point(22, 66);
            this.btnStartSSSMSLogging.Name = "btnStartSSSMSLogging";
            this.btnStartSSSMSLogging.Size = new System.Drawing.Size(216, 43);
            this.btnStartSSSMSLogging.TabIndex = 0;
            this.btnStartSSSMSLogging.Text = "Start SSMS with Logging ";
            this.btnStartSSSMSLogging.UseVisualStyleBackColor = true;
            // 
            // btnCollectSSMSInstallLogs
            // 
            this.btnCollectSSMSInstallLogs.Location = new System.Drawing.Point(247, 66);
            this.btnCollectSSMSInstallLogs.Name = "btnCollectSSMSInstallLogs";
            this.btnCollectSSMSInstallLogs.Size = new System.Drawing.Size(216, 43);
            this.btnCollectSSMSInstallLogs.TabIndex = 1;
            this.btnCollectSSMSInstallLogs.Text = "Collect SSMS Install Logs";
            this.btnCollectSSMSInstallLogs.UseVisualStyleBackColor = true;
            this.btnCollectSSMSInstallLogs.Click += new System.EventHandler(this.btnCollectSSMSInstallLogs_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(623, 138);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(115, 58);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnZipCapture);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnStartSSSMSLogging);
            this.tabPage1.Controls.Add(this.btnCollectSSMSInstallLogs);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(107, 29);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SSMS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnZipCapture
            // 
            this.btnZipCapture.Location = new System.Drawing.Point(304, 145);
            this.btnZipCapture.Name = "btnZipCapture";
            this.btnZipCapture.Size = new System.Drawing.Size(91, 37);
            this.btnZipCapture.TabIndex = 5;
            this.btnZipCapture.Text = "Zip capture";
            this.btnZipCapture.UseVisualStyleBackColor = true;
            this.btnZipCapture.Visible = false;
            this.btnZipCapture.Click += new System.EventHandler(this.btnZipCapture_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Collect SSMS config Logs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.btnStopSSDTLogging);
            this.tabPage2.Controls.Add(this.btnStartSSDTLogging);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(107, 29);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SSDT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(275, 14);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(468, 215);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn2015SetupLogs);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(460, 186);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "2015";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn2015SetupLogs
            // 
            this.btn2015SetupLogs.Location = new System.Drawing.Point(76, 26);
            this.btn2015SetupLogs.Name = "btn2015SetupLogs";
            this.btn2015SetupLogs.Size = new System.Drawing.Size(216, 43);
            this.btn2015SetupLogs.TabIndex = 6;
            this.btn2015SetupLogs.Text = "Collect SSDT 15 Setup Logs";
            this.btn2015SetupLogs.UseVisualStyleBackColor = true;
            this.btn2015SetupLogs.Click += new System.EventHandler(this.btn2015SetupLogs_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSSDTSetupLogs);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(460, 186);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "2017";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSSDTSetupLogs
            // 
            this.btnSSDTSetupLogs.Location = new System.Drawing.Point(76, 26);
            this.btnSSDTSetupLogs.Name = "btnSSDTSetupLogs";
            this.btnSSDTSetupLogs.Size = new System.Drawing.Size(216, 43);
            this.btnSSDTSetupLogs.TabIndex = 5;
            this.btnSSDTSetupLogs.Text = "Collect SSDT 17 Setup Logs";
            this.btnSSDTSetupLogs.UseVisualStyleBackColor = true;
            this.btnSSDTSetupLogs.Click += new System.EventHandler(this.btnSSDTSetupLogs_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnVSIXSetupLogs);
            this.tabPage4.Controls.Add(this.btnSSISSetupLogs);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(460, 186);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "2019";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnVSIXSetupLogs
            // 
            this.btnVSIXSetupLogs.Location = new System.Drawing.Point(219, 26);
            this.btnVSIXSetupLogs.Name = "btnVSIXSetupLogs";
            this.btnVSIXSetupLogs.Size = new System.Drawing.Size(183, 42);
            this.btnVSIXSetupLogs.TabIndex = 1;
            this.btnVSIXSetupLogs.Text = "Collect AS/RS Setup Logs";
            this.btnVSIXSetupLogs.UseVisualStyleBackColor = true;
            this.btnVSIXSetupLogs.Click += new System.EventHandler(this.btnVSIXSetupLogs_Click);
            // 
            // btnSSISSetupLogs
            // 
            this.btnSSISSetupLogs.Location = new System.Drawing.Point(19, 26);
            this.btnSSISSetupLogs.Name = "btnSSISSetupLogs";
            this.btnSSISSetupLogs.Size = new System.Drawing.Size(183, 42);
            this.btnSSISSetupLogs.TabIndex = 0;
            this.btnSSISSetupLogs.Text = "Collect IS Setup Logs";
            this.btnSSISSetupLogs.UseVisualStyleBackColor = true;
            this.btnSSISSetupLogs.Click += new System.EventHandler(this.btnSSISSetupLogs_Click);
            // 
            // btnStopSSDTLogging
            // 
            this.btnStopSSDTLogging.Location = new System.Drawing.Point(6, 77);
            this.btnStopSSDTLogging.Name = "btnStopSSDTLogging";
            this.btnStopSSDTLogging.Size = new System.Drawing.Size(216, 43);
            this.btnStopSSDTLogging.TabIndex = 4;
            this.btnStopSSDTLogging.Text = "Stop SSDT Logging";
            this.btnStopSSDTLogging.UseVisualStyleBackColor = true;
            this.btnStopSSDTLogging.Click += new System.EventHandler(this.btnStopSSDTLogging_Click);
            // 
            // btnStartSSDTLogging
            // 
            this.btnStartSSDTLogging.Location = new System.Drawing.Point(6, 14);
            this.btnStartSSDTLogging.Name = "btnStartSSDTLogging";
            this.btnStartSSDTLogging.Size = new System.Drawing.Size(216, 43);
            this.btnStartSSDTLogging.TabIndex = 2;
            this.btnStartSSDTLogging.Text = "Start SSDT Logging ";
            this.btnStartSSDTLogging.UseVisualStyleBackColor = true;
            this.btnStartSSDTLogging.Click += new System.EventHandler(this.btnStartSSDTLogging_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnDEALogs);
            this.tabPage6.Controls.Add(this.btnDEASetup);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(107, 29);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "DEA";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnDEALogs
            // 
            this.btnDEALogs.Location = new System.Drawing.Point(6, 77);
            this.btnDEALogs.Name = "btnDEALogs";
            this.btnDEALogs.Size = new System.Drawing.Size(216, 43);
            this.btnDEALogs.TabIndex = 6;
            this.btnDEALogs.Text = "DEA Logs";
            this.btnDEALogs.UseVisualStyleBackColor = true;
            this.btnDEALogs.Click += new System.EventHandler(this.btnDEALogs_Click);
            // 
            // btnDEASetup
            // 
            this.btnDEASetup.Location = new System.Drawing.Point(6, 14);
            this.btnDEASetup.Name = "btnDEASetup";
            this.btnDEASetup.Size = new System.Drawing.Size(216, 43);
            this.btnDEASetup.TabIndex = 5;
            this.btnDEASetup.Text = "Setup Logs";
            this.btnDEASetup.UseVisualStyleBackColor = true;
            this.btnDEASetup.Click += new System.EventHandler(this.btnDEASetup_Click);
            // 
            // bwStartSSMS
            // 
            this.bwStartSSMS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwStartSSMS_DoWork);
            this.bwStartSSMS.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwStartSSMS_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspbProcess,
            this.tsslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 238);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(588, 27);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tspbProcess
            // 
            this.tspbProcess.MarqueeAnimationSpeed = 0;
            this.tspbProcess.Name = "tspbProcess";
            this.tspbProcess.Size = new System.Drawing.Size(100, 19);
            this.tspbProcess.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(50, 21);
            this.tsslStatus.Text = "Ready";
            // 
            // bwCopyFiles
            // 
            this.bwCopyFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCopyFiles_DoWork);
            this.bwCopyFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwCopyFiles_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sSMSToolStripMenuItem,
            this.sSDTToolStripMenuItem,
            this.dEAToolStripMenuItem,
            this.zipEverythingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sSMSToolStripMenuItem
            // 
            this.sSMSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSSMSWithLoggingToolStripMenuItem,
            this.collectSSMSInstallLogsToolStripMenuItem});
            this.sSMSToolStripMenuItem.Name = "sSMSToolStripMenuItem";
            this.sSMSToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.sSMSToolStripMenuItem.Text = "SSMS";
            // 
            // startSSMSWithLoggingToolStripMenuItem
            // 
            this.startSSMSWithLoggingToolStripMenuItem.Name = "startSSMSWithLoggingToolStripMenuItem";
            this.startSSMSWithLoggingToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.startSSMSWithLoggingToolStripMenuItem.Text = "Start SSMS with Logging";
            this.startSSMSWithLoggingToolStripMenuItem.ToolTipText = "Starts SSMS with logging";
            this.startSSMSWithLoggingToolStripMenuItem.Click += new System.EventHandler(this.startSSMSWithLoggingToolStripMenuItem_Click);
            // 
            // collectSSMSInstallLogsToolStripMenuItem
            // 
            this.collectSSMSInstallLogsToolStripMenuItem.Name = "collectSSMSInstallLogsToolStripMenuItem";
            this.collectSSMSInstallLogsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.collectSSMSInstallLogsToolStripMenuItem.Text = "Collect SSMS Install Logs";
            this.collectSSMSInstallLogsToolStripMenuItem.ToolTipText = "Collects setup logs for SSMS";
            this.collectSSMSInstallLogsToolStripMenuItem.Click += new System.EventHandler(this.collectSSMSInstallLogsToolStripMenuItem_Click);
            // 
            // sSDTToolStripMenuItem
            // 
            this.sSDTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startSSDTLoggingToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.sSDTToolStripMenuItem.Name = "sSDTToolStripMenuItem";
            this.sSDTToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.sSDTToolStripMenuItem.Text = "SSDT";
            // 
            // startSSDTLoggingToolStripMenuItem
            // 
            this.startSSDTLoggingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startLoggingToolStripMenuItem,
            this.stopLoggingToolStripMenuItem});
            this.startSSDTLoggingToolStripMenuItem.Name = "startSSDTLoggingToolStripMenuItem";
            this.startSSDTLoggingToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.startSSDTLoggingToolStripMenuItem.Text = "Logging Command";
            this.startSSDTLoggingToolStripMenuItem.Click += new System.EventHandler(this.startSSDTLoggingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItem3.Text = "Collect 2015 Setup Logs";
            this.toolStripMenuItem3.ToolTipText = "Collects SSDT Setup logs for SSDT 2015";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItem4.Text = "Collect 2017 Setup Logs";
            this.toolStripMenuItem4.ToolTipText = "Collects SSDT Setup logs for SSDT ";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectISSetupLogsToolStripMenuItem,
            this.collectASRSSetupLogsToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(251, 26);
            this.toolStripMenuItem5.Text = "SSDT 2019 ";
            // 
            // collectISSetupLogsToolStripMenuItem
            // 
            this.collectISSetupLogsToolStripMenuItem.Name = "collectISSetupLogsToolStripMenuItem";
            this.collectISSetupLogsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.collectISSetupLogsToolStripMenuItem.Text = "Collect IS Setup Logs";
            this.collectISSetupLogsToolStripMenuItem.ToolTipText = "Collects SSDT Setup logs for Integration Services";
            this.collectISSetupLogsToolStripMenuItem.Click += new System.EventHandler(this.collectISSetupLogsToolStripMenuItem_Click);
            // 
            // collectASRSSetupLogsToolStripMenuItem
            // 
            this.collectASRSSetupLogsToolStripMenuItem.Name = "collectASRSSetupLogsToolStripMenuItem";
            this.collectASRSSetupLogsToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.collectASRSSetupLogsToolStripMenuItem.Text = "Collect AS/RS Setup Logs";
            this.collectASRSSetupLogsToolStripMenuItem.ToolTipText = "Collects SSDT Setup logs for Reporting or Analysis Services ";
            this.collectASRSSetupLogsToolStripMenuItem.Click += new System.EventHandler(this.collectASRSSetupLogsToolStripMenuItem_Click);
            // 
            // dEAToolStripMenuItem
            // 
            this.dEAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectSetupLogsToolStripMenuItem,
            this.collectDEALogsToolStripMenuItem});
            this.dEAToolStripMenuItem.Name = "dEAToolStripMenuItem";
            this.dEAToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.dEAToolStripMenuItem.Text = "DEA";
            // 
            // collectSetupLogsToolStripMenuItem
            // 
            this.collectSetupLogsToolStripMenuItem.Name = "collectSetupLogsToolStripMenuItem";
            this.collectSetupLogsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.collectSetupLogsToolStripMenuItem.Text = "Collect Setup Logs";
            this.collectSetupLogsToolStripMenuItem.ToolTipText = "Collects DEA setup logs";
            this.collectSetupLogsToolStripMenuItem.Click += new System.EventHandler(this.collectSetupLogsToolStripMenuItem_Click);
            // 
            // collectDEALogsToolStripMenuItem
            // 
            this.collectDEALogsToolStripMenuItem.Name = "collectDEALogsToolStripMenuItem";
            this.collectDEALogsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.collectDEALogsToolStripMenuItem.Text = "Collect DEA Logs";
            this.collectDEALogsToolStripMenuItem.ToolTipText = "Collects DEA use logs";
            this.collectDEALogsToolStripMenuItem.Click += new System.EventHandler(this.collectDEALogsToolStripMenuItem_Click);
            // 
            // zipEverythingToolStripMenuItem
            // 
            this.zipEverythingToolStripMenuItem.Name = "zipEverythingToolStripMenuItem";
            this.zipEverythingToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.zipEverythingToolStripMenuItem.Text = "Zip Everything";
            this.zipEverythingToolStripMenuItem.Click += new System.EventHandler(this.zipEverythingToolStripMenuItem_Click);
            // 
            // lblSSDTLog
            // 
            this.lblSSDTLog.AutoSize = true;
            this.lblSSDTLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSDTLog.Location = new System.Drawing.Point(10, 42);
            this.lblSSDTLog.Name = "lblSSDTLog";
            this.lblSSDTLog.Size = new System.Drawing.Size(503, 150);
            this.lblSSDTLog.TabIndex = 7;
            this.lblSSDTLog.Text = resources.GetString("lblSSDTLog.Text");
            // 
            // txSSDTLogMan
            // 
            this.txSSDTLogMan.Location = new System.Drawing.Point(15, 239);
            this.txSSDTLogMan.Multiline = true;
            this.txSSDTLogMan.Name = "txSSDTLogMan";
            this.txSSDTLogMan.Size = new System.Drawing.Size(380, 174);
            this.txSSDTLogMan.TabIndex = 8;
            this.txSSDTLogMan.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(401, 239);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(157, 174);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // startLoggingToolStripMenuItem
            // 
            this.startLoggingToolStripMenuItem.Name = "startLoggingToolStripMenuItem";
            this.startLoggingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.startLoggingToolStripMenuItem.Text = "Start Logging";
            this.startLoggingToolStripMenuItem.ToolTipText = "Creates the command to start SSDT captures";
            this.startLoggingToolStripMenuItem.Click += new System.EventHandler(this.startLoggingToolStripMenuItem_Click);
            // 
            // stopLoggingToolStripMenuItem
            // 
            this.stopLoggingToolStripMenuItem.Enabled = false;
            this.stopLoggingToolStripMenuItem.Name = "stopLoggingToolStripMenuItem";
            this.stopLoggingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stopLoggingToolStripMenuItem.Text = "Stop Logging";
            this.stopLoggingToolStripMenuItem.ToolTipText = "Creates the command to stop SSDT captures";
            this.stopLoggingToolStripMenuItem.Click += new System.EventHandler(this.stopLoggingToolStripMenuItem_Click);
            // 
            // fSQLToolsDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 265);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txSSDTLogMan);
            this.Controls.Add(this.lblSSDTLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fSQLToolsDiag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLToolsDiag ";
            this.Load += new System.EventHandler(this.fSQLToolsDiag_Load);
            this.Shown += new System.EventHandler(this.fSQLToolsDiag_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartSSSMSLogging;
        private System.Windows.Forms.Button btnCollectSSMSInstallLogs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStartSSDTLogging;
        private System.Windows.Forms.Button btnStopSSDTLogging;
        private System.ComponentModel.BackgroundWorker bwStartSSMS;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tspbProcess;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.ComponentModel.BackgroundWorker bwCopyFiles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSSDTSetupLogs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnVSIXSetupLogs;
        private System.Windows.Forms.Button btnSSISSetupLogs;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn2015SetupLogs;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnDEALogs;
        private System.Windows.Forms.Button btnDEASetup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnZipCapture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sSMSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSSMSWithLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectSSMSInstallLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSDTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startSSDTLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem collectISSetupLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectASRSSetupLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dEAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectSetupLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectDEALogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipEverythingToolStripMenuItem;
        private System.Windows.Forms.Label lblSSDTLog;
        private System.Windows.Forms.TextBox txSSDTLogMan;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ToolStripMenuItem startLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopLoggingToolStripMenuItem;
    }
}

