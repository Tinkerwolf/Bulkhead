namespace Bulkhead
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InfoBox = new System.Windows.Forms.ToolTip(this.components);
            this.FilePattern = new System.Windows.Forms.TextBox();
            this.Generator = new System.ComponentModel.BackgroundWorker();
            this.Downloader = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.QI16 = new System.Windows.Forms.Button();
            this.QI15 = new System.Windows.Forms.Button();
            this.QI14 = new System.Windows.Forms.Button();
            this.QI13 = new System.Windows.Forms.Button();
            this.QI12 = new System.Windows.Forms.Button();
            this.QI11 = new System.Windows.Forms.Button();
            this.QI10 = new System.Windows.Forms.Button();
            this.QI09 = new System.Windows.Forms.Button();
            this.QI08 = new System.Windows.Forms.Button();
            this.QI07 = new System.Windows.Forms.Button();
            this.QI06 = new System.Windows.Forms.Button();
            this.QI03 = new System.Windows.Forms.Button();
            this.QI04 = new System.Windows.Forms.Button();
            this.QI02 = new System.Windows.Forms.Button();
            this.QI05 = new System.Windows.Forms.Button();
            this.QI01 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.NR_End = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NR_Start = new System.Windows.Forms.NumericUpDown();
            this.NR_Pad = new System.Windows.Forms.CheckBox();
            this.Insert_NR = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.PercentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.TextStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Action = new System.Windows.Forms.Button();
            this.AutoContinue = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FileList = new System.Windows.Forms.ListView();
            this.CodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URLColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NR_End)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NR_Start)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.InfoBox.ToolTipTitle = "Hint";
            // 
            // FilePattern
            // 
            this.FilePattern.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilePattern.Location = new System.Drawing.Point(3, 16);
            this.FilePattern.Name = "FilePattern";
            this.FilePattern.Size = new System.Drawing.Size(394, 20);
            this.FilePattern.TabIndex = 0;
            this.InfoBox.SetToolTip(this.FilePattern, resources.GetString("FilePattern.ToolTip"));
            this.FilePattern.TextChanged += new System.EventHandler(this.PatternChanged);
            // 
            // Generator
            // 
            this.Generator.WorkerReportsProgress = true;
            this.Generator.WorkerSupportsCancellation = true;
            this.Generator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Generate);
            this.Generator.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.GeneratedItem);
            this.Generator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Generated);
            // 
            // Downloader
            // 
            this.Downloader.WorkerReportsProgress = true;
            this.Downloader.WorkerSupportsCancellation = true;
            this.Downloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Download);
            this.Downloader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DownloadProgressed);
            this.Downloader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DownloadComplete);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.StatusBar);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FileList);
            this.splitContainer1.Size = new System.Drawing.Size(843, 446);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 346);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Patterns";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.QI16, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.QI15, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.QI14, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.QI13, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.QI12, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.QI11, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.QI10, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.QI09, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.QI08, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.QI07, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.QI06, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.QI03, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.QI04, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.QI02, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.QI05, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.QI01, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 262);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // QI16
            // 
            this.QI16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI16.Location = new System.Drawing.Point(297, 198);
            this.QI16.Name = "QI16";
            this.QI16.Size = new System.Drawing.Size(94, 61);
            this.QI16.TabIndex = 15;
            this.QI16.Tag = "";
            this.QI16.UseVisualStyleBackColor = true;
            this.QI16.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI15
            // 
            this.QI15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI15.Location = new System.Drawing.Point(199, 198);
            this.QI15.Name = "QI15";
            this.QI15.Size = new System.Drawing.Size(92, 61);
            this.QI15.TabIndex = 14;
            this.QI15.Tag = "";
            this.QI15.UseVisualStyleBackColor = true;
            this.QI15.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI14
            // 
            this.QI14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI14.Location = new System.Drawing.Point(101, 198);
            this.QI14.Name = "QI14";
            this.QI14.Size = new System.Drawing.Size(92, 61);
            this.QI14.TabIndex = 13;
            this.QI14.Tag = "";
            this.QI14.UseVisualStyleBackColor = true;
            this.QI14.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI13
            // 
            this.QI13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI13.Location = new System.Drawing.Point(3, 198);
            this.QI13.Name = "QI13";
            this.QI13.Size = new System.Drawing.Size(92, 61);
            this.QI13.TabIndex = 12;
            this.QI13.Tag = "";
            this.QI13.UseVisualStyleBackColor = true;
            this.QI13.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI12
            // 
            this.QI12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI12.Location = new System.Drawing.Point(297, 133);
            this.QI12.Name = "QI12";
            this.QI12.Size = new System.Drawing.Size(94, 59);
            this.QI12.TabIndex = 11;
            this.QI12.Tag = ".{png|PNG}";
            this.QI12.Text = "PNG";
            this.QI12.UseVisualStyleBackColor = true;
            this.QI12.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI11
            // 
            this.QI11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI11.Location = new System.Drawing.Point(199, 133);
            this.QI11.Name = "QI11";
            this.QI11.Size = new System.Drawing.Size(92, 59);
            this.QI11.TabIndex = 10;
            this.QI11.Tag = "";
            this.QI11.UseVisualStyleBackColor = true;
            this.QI11.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI10
            // 
            this.QI10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI10.Location = new System.Drawing.Point(101, 133);
            this.QI10.Name = "QI10";
            this.QI10.Size = new System.Drawing.Size(92, 59);
            this.QI10.TabIndex = 9;
            this.QI10.Tag = "";
            this.QI10.UseVisualStyleBackColor = true;
            this.QI10.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI09
            // 
            this.QI09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI09.Location = new System.Drawing.Point(3, 133);
            this.QI09.Name = "QI09";
            this.QI09.Size = new System.Drawing.Size(92, 59);
            this.QI09.TabIndex = 8;
            this.QI09.Tag = "";
            this.QI09.UseVisualStyleBackColor = true;
            this.QI09.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI08
            // 
            this.QI08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI08.Location = new System.Drawing.Point(297, 68);
            this.QI08.Name = "QI08";
            this.QI08.Size = new System.Drawing.Size(94, 59);
            this.QI08.TabIndex = 7;
            this.QI08.Tag = ".{jpg|JPG|jpeg|JPEG}";
            this.QI08.Text = "JPEG";
            this.QI08.UseVisualStyleBackColor = true;
            this.QI08.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI07
            // 
            this.QI07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI07.Location = new System.Drawing.Point(199, 68);
            this.QI07.Name = "QI07";
            this.QI07.Size = new System.Drawing.Size(92, 59);
            this.QI07.TabIndex = 6;
            this.QI07.Tag = "";
            this.QI07.UseVisualStyleBackColor = true;
            this.QI07.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI06
            // 
            this.QI06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI06.Location = new System.Drawing.Point(101, 68);
            this.QI06.Name = "QI06";
            this.QI06.Size = new System.Drawing.Size(92, 59);
            this.QI06.TabIndex = 5;
            this.QI06.Tag = "";
            this.QI06.UseVisualStyleBackColor = true;
            this.QI06.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI03
            // 
            this.QI03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI03.Location = new System.Drawing.Point(199, 3);
            this.QI03.Name = "QI03";
            this.QI03.Size = new System.Drawing.Size(92, 59);
            this.QI03.TabIndex = 4;
            this.QI03.Tag = "";
            this.QI03.UseVisualStyleBackColor = true;
            this.QI03.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI04
            // 
            this.QI04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI04.Location = new System.Drawing.Point(297, 3);
            this.QI04.Name = "QI04";
            this.QI04.Size = new System.Drawing.Size(94, 59);
            this.QI04.TabIndex = 3;
            this.QI04.Tag = ".{jpg|JPG|jpeg|JPEG|png|PNG}";
            this.QI04.Text = "JPEG or PNG";
            this.QI04.UseVisualStyleBackColor = true;
            this.QI04.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI02
            // 
            this.QI02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI02.Location = new System.Drawing.Point(101, 3);
            this.QI02.Name = "QI02";
            this.QI02.Size = new System.Drawing.Size(92, 59);
            this.QI02.TabIndex = 2;
            this.QI02.Tag = "{0-9}";
            this.QI02.Text = "0-9";
            this.QI02.UseVisualStyleBackColor = true;
            this.QI02.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI05
            // 
            this.QI05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI05.Location = new System.Drawing.Point(3, 68);
            this.QI05.Name = "QI05";
            this.QI05.Size = new System.Drawing.Size(92, 59);
            this.QI05.TabIndex = 1;
            this.QI05.Tag = "{a-z}";
            this.QI05.Text = "a-z";
            this.QI05.UseVisualStyleBackColor = true;
            this.QI05.Click += new System.EventHandler(this.QuickInsert);
            // 
            // QI01
            // 
            this.QI01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QI01.Location = new System.Drawing.Point(3, 3);
            this.QI01.Name = "QI01";
            this.QI01.Size = new System.Drawing.Size(92, 59);
            this.QI01.TabIndex = 0;
            this.QI01.Tag = "{A-Z}";
            this.QI01.Text = "A-Z";
            this.QI01.UseVisualStyleBackColor = true;
            this.QI01.Click += new System.EventHandler(this.QuickInsert);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this.NR_Pad);
            this.groupBox3.Controls.Add(this.Insert_NR);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 65);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number Range";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(268, 46);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.NR_End);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(137, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 40);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "End";
            // 
            // NR_End
            // 
            this.NR_End.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NR_End.Location = new System.Drawing.Point(3, 16);
            this.NR_End.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NR_End.Name = "NR_End";
            this.NR_End.Size = new System.Drawing.Size(122, 20);
            this.NR_End.TabIndex = 1;
            this.NR_End.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NR_Start);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 40);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Start";
            // 
            // NR_Start
            // 
            this.NR_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NR_Start.Location = new System.Drawing.Point(3, 16);
            this.NR_Start.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NR_Start.Name = "NR_Start";
            this.NR_Start.Size = new System.Drawing.Size(122, 20);
            this.NR_Start.TabIndex = 0;
            // 
            // NR_Pad
            // 
            this.NR_Pad.AutoSize = true;
            this.NR_Pad.Checked = true;
            this.NR_Pad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NR_Pad.Dock = System.Windows.Forms.DockStyle.Right;
            this.NR_Pad.Location = new System.Drawing.Point(271, 16);
            this.NR_Pad.Name = "NR_Pad";
            this.NR_Pad.Size = new System.Drawing.Size(45, 46);
            this.NR_Pad.TabIndex = 3;
            this.NR_Pad.Text = "Pad";
            this.NR_Pad.UseVisualStyleBackColor = true;
            // 
            // Insert_NR
            // 
            this.Insert_NR.Dock = System.Windows.Forms.DockStyle.Right;
            this.Insert_NR.Location = new System.Drawing.Point(316, 16);
            this.Insert_NR.Name = "Insert_NR";
            this.Insert_NR.Size = new System.Drawing.Size(75, 46);
            this.Insert_NR.TabIndex = 2;
            this.Insert_NR.Text = "Insert";
            this.Insert_NR.UseVisualStyleBackColor = true;
            this.Insert_NR.Click += new System.EventHandler(this.InsertNumberRange);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PercentStatus,
            this.ProgStatus,
            this.TextStatus});
            this.StatusBar.Location = new System.Drawing.Point(0, 416);
            this.StatusBar.MinimumSize = new System.Drawing.Size(0, 30);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(400, 30);
            this.StatusBar.TabIndex = 8;
            this.StatusBar.Text = "statusStrip1";
            // 
            // PercentStatus
            // 
            this.PercentStatus.Name = "PercentStatus";
            this.PercentStatus.Size = new System.Drawing.Size(0, 25);
            // 
            // ProgStatus
            // 
            this.ProgStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProgStatus.AutoSize = false;
            this.ProgStatus.Name = "ProgStatus";
            this.ProgStatus.Size = new System.Drawing.Size(150, 24);
            // 
            // TextStatus
            // 
            this.TextStatus.Name = "TextStatus";
            this.TextStatus.Size = new System.Drawing.Size(233, 25);
            this.TextStatus.Spring = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Action, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AutoContinue, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 31);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Action
            // 
            this.Action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Action.Location = new System.Drawing.Point(203, 3);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(194, 25);
            this.Action.TabIndex = 0;
            this.Action.Text = "Generate List";
            this.Action.UseVisualStyleBackColor = true;
            this.Action.Click += new System.EventHandler(this.Action_Click);
            // 
            // AutoContinue
            // 
            this.AutoContinue.AutoSize = true;
            this.AutoContinue.Checked = true;
            this.AutoContinue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoContinue.Location = new System.Drawing.Point(3, 3);
            this.AutoContinue.Name = "AutoContinue";
            this.AutoContinue.Size = new System.Drawing.Size(194, 25);
            this.AutoContinue.TabIndex = 1;
            this.AutoContinue.Text = "Automatic";
            this.AutoContinue.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FilePattern);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 39);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "URL Pattern";
            // 
            // FileList
            // 
            this.FileList.BackColor = System.Drawing.SystemColors.Control;
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeColumn,
            this.URLColumn});
            this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileList.FullRowSelect = true;
            this.FileList.Location = new System.Drawing.Point(0, 0);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(439, 446);
            this.FileList.TabIndex = 0;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            this.FileList.Resize += new System.EventHandler(this.ResizeColumns);
            // 
            // CodeColumn
            // 
            this.CodeColumn.Text = "";
            // 
            // URLColumn
            // 
            this.URLColumn.Text = "URLs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 446);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bulkhead";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NR_End)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NR_Start)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip InfoBox;
        private System.ComponentModel.BackgroundWorker Generator;
        private System.ComponentModel.BackgroundWorker Downloader;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel PercentStatus;
        private System.Windows.Forms.ToolStripProgressBar ProgStatus;
        private System.Windows.Forms.Button Action;
        private System.Windows.Forms.CheckBox AutoContinue;
        private System.Windows.Forms.TextBox FilePattern;
        private System.Windows.Forms.ToolStripStatusLabel TextStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Insert_NR;
        private System.Windows.Forms.NumericUpDown NR_Start;
        private System.Windows.Forms.NumericUpDown NR_End;
        private System.Windows.Forms.CheckBox NR_Pad;
        private System.Windows.Forms.Button QI01;
        private System.Windows.Forms.Button QI02;
        private System.Windows.Forms.Button QI03;
        private System.Windows.Forms.Button QI04;
        private System.Windows.Forms.Button QI05;
        private System.Windows.Forms.Button QI06;
        private System.Windows.Forms.Button QI07;
        private System.Windows.Forms.Button QI08;
        private System.Windows.Forms.Button QI09;
        private System.Windows.Forms.Button QI10;
        private System.Windows.Forms.Button QI11;
        private System.Windows.Forms.Button QI12;
        private System.Windows.Forms.Button QI13;
        private System.Windows.Forms.Button QI14;
        private System.Windows.Forms.Button QI15;
        private System.Windows.Forms.Button QI16;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.ColumnHeader CodeColumn;
        private System.Windows.Forms.ColumnHeader URLColumn;
    }
}

