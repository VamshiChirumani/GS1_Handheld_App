
namespace GS1_Handheld_App
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
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.cbStart = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHomeOffset = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbAtHome = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVacuum = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoveToLoc = new System.Windows.Forms.TextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.MotionSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.ValveSerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lboxStatus = new System.Windows.Forms.ListBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxConnected = new System.Windows.Forms.CheckBox();
            this.txtPLC_IP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCycles = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCards = new System.Windows.Forms.NumericUpDown();
            this.btnRun = new System.Windows.Forms.Button();
            this.backgroundRunTest = new System.ComponentModel.BackgroundWorker();
            this.progressRun = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnHaltAir = new System.Windows.Forms.Button();
            this.tmrCheckHome = new System.Windows.Forms.Timer(this.components);
            this.ethernetIPforSLCMicroCom1 = new AdvancedHMIDrivers.EthernetIPforSLCMicroCom(this.components);
            this.btnOCR = new System.Windows.Forms.Button();
            this.Repeat10Times = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforSLCMicroCom1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(85, 37);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(99, 32);
            this.cbPort.TabIndex = 0;
            // 
            // cbStart
            // 
            this.cbStart.FormattingEnabled = true;
            this.cbStart.Items.AddRange(new object[] {
            "8",
            "7"});
            this.cbStart.Location = new System.Drawing.Point(85, 133);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(60, 32);
            this.cbStart.TabIndex = 1;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(85, 85);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(99, 32);
            this.cbBaud.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "BAUD:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(85, 181);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(60, 32);
            this.cbStop.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbStop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.cbStart);
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 288);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slide Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(17, 230);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(167, 42);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHomeOffset);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.rbAtHome);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btnVacuum);
            this.groupBox2.Controls.Add(this.btnLeft);
            this.groupBox2.Controls.Add(this.btnRight);
            this.groupBox2.Controls.Add(this.btnDown);
            this.groupBox2.Controls.Add(this.btnUp);
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMoveToLoc);
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnFwd);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 288);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual Control";
            // 
            // txtHomeOffset
            // 
            this.txtHomeOffset.Location = new System.Drawing.Point(283, 93);
            this.txtHomeOffset.Name = "txtHomeOffset";
            this.txtHomeOffset.Size = new System.Drawing.Size(49, 29);
            this.txtHomeOffset.TabIndex = 22;
            this.txtHomeOffset.Text = "27";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Home Offset";
            // 
            // rbAtHome
            // 
            this.rbAtHome.AutoSize = true;
            this.rbAtHome.Location = new System.Drawing.Point(465, 18);
            this.rbAtHome.Name = "rbAtHome";
            this.rbAtHome.Size = new System.Drawing.Size(102, 28);
            this.rbAtHome.TabIndex = 20;
            this.rbAtHome.TabStop = true;
            this.rbAtHome.Text = "At Home";
            this.rbAtHome.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "X position";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(138, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 76);
            this.listBox1.TabIndex = 17;
            // 
            // btnVacuum
            // 
            this.btnVacuum.Location = new System.Drawing.Point(408, 231);
            this.btnVacuum.Name = "btnVacuum";
            this.btnVacuum.Size = new System.Drawing.Size(94, 50);
            this.btnVacuum.TabIndex = 16;
            this.btnVacuum.Text = "Vacuum";
            this.btnVacuum.UseVisualStyleBackColor = true;
            this.btnVacuum.Click += new System.EventHandler(this.btnVacuum_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(355, 167);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(94, 50);
            this.btnLeft.TabIndex = 15;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(472, 167);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(94, 50);
            this.btnRight.TabIndex = 14;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(408, 105);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(94, 50);
            this.btnDown.TabIndex = 13;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(408, 49);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(94, 50);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnMove
            // 
            this.btnMove.Enabled = false;
            this.btnMove.Location = new System.Drawing.Point(138, 145);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(94, 50);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Move by:";
            // 
            // txtMoveToLoc
            // 
            this.txtMoveToLoc.Location = new System.Drawing.Point(138, 93);
            this.txtMoveToLoc.Name = "txtMoveToLoc";
            this.txtMoveToLoc.Size = new System.Drawing.Size(100, 29);
            this.txtMoveToLoc.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.Enabled = false;
            this.btnHome.Location = new System.Drawing.Point(18, 222);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(18, 115);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFwd
            // 
            this.btnFwd.Enabled = false;
            this.btnFwd.Location = new System.Drawing.Point(18, 40);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(94, 50);
            this.btnFwd.TabIndex = 0;
            this.btnFwd.Text = "Fwd";
            this.btnFwd.UseVisualStyleBackColor = true;
            this.btnFwd.Click += new System.EventHandler(this.btnFwd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // lboxStatus
            // 
            this.lboxStatus.FormattingEnabled = true;
            this.lboxStatus.ItemHeight = 24;
            this.lboxStatus.Location = new System.Drawing.Point(90, 309);
            this.lboxStatus.Name = "lboxStatus";
            this.lboxStatus.Size = new System.Drawing.Size(830, 76);
            this.lboxStatus.TabIndex = 11;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BackColor = System.Drawing.Color.Black;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(966, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(234, 33);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 70;
            this.PictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxConnected);
            this.groupBox3.Controls.Add(this.txtPLC_IP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(1002, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 159);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PLC Connection";
            // 
            // cboxConnected
            // 
            this.cboxConnected.AutoSize = true;
            this.cboxConnected.Location = new System.Drawing.Point(19, 118);
            this.cboxConnected.Name = "cboxConnected";
            this.cboxConnected.Size = new System.Drawing.Size(122, 28);
            this.cboxConnected.TabIndex = 2;
            this.cboxConnected.Text = "Connected";
            this.cboxConnected.UseVisualStyleBackColor = true;
            // 
            // txtPLC_IP
            // 
            this.txtPLC_IP.Location = new System.Drawing.Point(13, 66);
            this.txtPLC_IP.Name = "txtPLC_IP";
            this.txtPLC_IP.Size = new System.Drawing.Size(169, 29);
            this.txtPLC_IP.TabIndex = 1;
            this.txtPLC_IP.Text = "172.16.160.33";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "IP Address:";
            // 
            // nudCycles
            // 
            this.nudCycles.Location = new System.Drawing.Point(857, 57);
            this.nudCycles.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCycles.Name = "nudCycles";
            this.nudCycles.Size = new System.Drawing.Size(76, 29);
            this.nudCycles.TabIndex = 72;
            this.nudCycles.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(853, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 24);
            this.label8.TabIndex = 73;
            this.label8.Text = "Cycles:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(853, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 75;
            this.label9.Text = "Cards:";
            // 
            // nudCards
            // 
            this.nudCards.Location = new System.Drawing.Point(857, 132);
            this.nudCards.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCards.Name = "nudCards";
            this.nudCards.Size = new System.Drawing.Size(76, 29);
            this.nudCards.TabIndex = 74;
            this.nudCards.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(857, 177);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(119, 41);
            this.btnRun.TabIndex = 76;
            this.btnRun.Text = "Run Test";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // backgroundRunTest
            // 
            this.backgroundRunTest.WorkerSupportsCancellation = true;
            this.backgroundRunTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundRunTest_DoWork);
            this.backgroundRunTest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundRunTest_RunWorkerCompleted);
            // 
            // progressRun
            // 
            this.progressRun.ForeColor = System.Drawing.Color.MediumBlue;
            this.progressRun.Location = new System.Drawing.Point(867, 234);
            this.progressRun.Name = "progressRun";
            this.progressRun.Size = new System.Drawing.Size(330, 24);
            this.progressRun.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressRun.TabIndex = 77;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(857, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 31);
            this.button1.TabIndex = 78;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(935, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 31);
            this.button2.TabIndex = 79;
            this.button2.Text = "Index";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHaltAir
            // 
            this.btnHaltAir.BackColor = System.Drawing.SystemColors.Control;
            this.btnHaltAir.Location = new System.Drawing.Point(1050, 285);
            this.btnHaltAir.Name = "btnHaltAir";
            this.btnHaltAir.Size = new System.Drawing.Size(133, 99);
            this.btnHaltAir.TabIndex = 80;
            this.btnHaltAir.Text = "Enable Pnuematics";
            this.btnHaltAir.UseVisualStyleBackColor = false;
            this.btnHaltAir.Click += new System.EventHandler(this.button3_Click);
            // 
            // tmrCheckHome
            // 
            this.tmrCheckHome.Interval = 500;
            this.tmrCheckHome.Tick += new System.EventHandler(this.tmrCheckHome_Tick);
            // 
            // ethernetIPforSLCMicroCom1
            // 
            this.ethernetIPforSLCMicroCom1.CIPConnectionSize = 508;
            this.ethernetIPforSLCMicroCom1.DisableSubscriptions = false;
            this.ethernetIPforSLCMicroCom1.IniFileName = "";
            this.ethernetIPforSLCMicroCom1.IniFileSection = null;
            this.ethernetIPforSLCMicroCom1.IPAddress = global::GS1_Handheld_App.Properties.Settings.Default.PLC_IP;
            this.ethernetIPforSLCMicroCom1.IsPLC5 = false;
            this.ethernetIPforSLCMicroCom1.MaxPCCCPacketSize = 236;
            this.ethernetIPforSLCMicroCom1.PollRateOverride = 10;
            this.ethernetIPforSLCMicroCom1.Port = 44818;
            this.ethernetIPforSLCMicroCom1.RoutePath = null;
            this.ethernetIPforSLCMicroCom1.Timeout = 5000;
            // 
            // btnOCR
            // 
            this.btnOCR.Location = new System.Drawing.Point(935, 309);
            this.btnOCR.Name = "btnOCR";
            this.btnOCR.Size = new System.Drawing.Size(89, 66);
            this.btnOCR.TabIndex = 81;
            this.btnOCR.Text = "OCR Trigger";
            this.btnOCR.UseVisualStyleBackColor = true;
            this.btnOCR.Click += new System.EventHandler(this.btnOCR_Click);
            // 
            // Repeat10Times
            // 
            this.Repeat10Times.Location = new System.Drawing.Point(12, 329);
            this.Repeat10Times.Name = "Repeat10Times";
            this.Repeat10Times.Size = new System.Drawing.Size(72, 56);
            this.Repeat10Times.TabIndex = 82;
            this.Repeat10Times.Text = "Repeat10Times";
            this.Repeat10Times.UseVisualStyleBackColor = true;
            this.Repeat10Times.Click += new System.EventHandler(this.Repeat10Times_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 398);
            this.Controls.Add(this.Repeat10Times);
            this.Controls.Add(this.btnOCR);
            this.Controls.Add(this.btnHaltAir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressRun);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudCards);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudCycles);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lboxStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GS1 Handheld Control Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforSLCMicroCom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.ComboBox cbStart;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFwd;
        private System.IO.Ports.SerialPort MotionSerialPort;
        private System.IO.Ports.SerialPort ValveSerialPort1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxStatus;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoveToLoc;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private AdvancedHMIDrivers.EthernetIPforSLCMicroCom ethernetIPforSLCMicroCom1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPLC_IP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVacuum;
        private System.Windows.Forms.NumericUpDown nudCycles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCards;
        private System.Windows.Forms.Button btnRun;
        private System.ComponentModel.BackgroundWorker backgroundRunTest;
        private System.Windows.Forms.ProgressBar progressRun;
        private System.Windows.Forms.CheckBox cboxConnected;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnHaltAir;
        private System.Windows.Forms.RadioButton rbAtHome;
        private System.Windows.Forms.Timer tmrCheckHome;
        private System.Windows.Forms.TextBox txtHomeOffset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOCR;
        private System.Windows.Forms.Button Repeat10Times;
    }
}

