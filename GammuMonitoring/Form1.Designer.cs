namespace GammuMonitoring
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
            this.grpPull1 = new System.Windows.Forms.GroupBox();
            this.chkEnablePull1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProcessId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgPull1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnPull1Stop = new System.Windows.Forms.Button();
            this.btnPull1Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatusPull1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMonitPull1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picStatusPull1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picStatusPull2 = new System.Windows.Forms.PictureBox();
            this.labelJam = new System.Windows.Forms.Label();
            this.timerJam = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnablePull2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProcessId2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgPull2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnPull2Stop = new System.Windows.Forms.Button();
            this.btnPull2Start = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLocationPull2 = new System.Windows.Forms.Button();
            this.txtLocationPull2 = new System.Windows.Forms.TextBox();
            this.btnSchedulePull2 = new System.Windows.Forms.Button();
            this.timerMonitPull2 = new System.Windows.Forms.Timer(this.components);
            this.grpPull1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPull1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusPull1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusPull2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPull2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPull1
            // 
            this.grpPull1.Controls.Add(this.chkEnablePull1);
            this.grpPull1.Controls.Add(this.label5);
            this.grpPull1.Controls.Add(this.panel2);
            this.grpPull1.Controls.Add(this.dgPull1);
            this.grpPull1.Controls.Add(this.linkLabel1);
            this.grpPull1.Controls.Add(this.btnPull1Stop);
            this.grpPull1.Controls.Add(this.btnPull1Start);
            this.grpPull1.Controls.Add(this.label1);
            this.grpPull1.Controls.Add(this.button2);
            this.grpPull1.Controls.Add(this.textBox1);
            this.grpPull1.Controls.Add(this.button1);
            this.grpPull1.Location = new System.Drawing.Point(193, 27);
            this.grpPull1.Name = "grpPull1";
            this.grpPull1.Size = new System.Drawing.Size(222, 471);
            this.grpPull1.TabIndex = 0;
            this.grpPull1.TabStop = false;
            this.grpPull1.Text = "    Pull1";
            // 
            // chkEnablePull1
            // 
            this.chkEnablePull1.AutoSize = true;
            this.chkEnablePull1.Location = new System.Drawing.Point(6, 0);
            this.chkEnablePull1.Name = "chkEnablePull1";
            this.chkEnablePull1.Size = new System.Drawing.Size(15, 14);
            this.chkEnablePull1.TabIndex = 10;
            this.chkEnablePull1.UseVisualStyleBackColor = true;
            this.chkEnablePull1.CheckedChanged += new System.EventHandler(this.chkEnablePull1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Schedule";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.lblProcessId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 32);
            this.panel2.TabIndex = 8;
            // 
            // lblProcessId
            // 
            this.lblProcessId.AutoSize = true;
            this.lblProcessId.Location = new System.Drawing.Point(63, 10);
            this.lblProcessId.Name = "lblProcessId";
            this.lblProcessId.Size = new System.Drawing.Size(0, 13);
            this.lblProcessId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Proses ID";
            // 
            // dgPull1
            // 
            this.dgPull1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPull1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPull1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Action,
            this.Status});
            this.dgPull1.Location = new System.Drawing.Point(6, 153);
            this.dgPull1.Name = "dgPull1";
            this.dgPull1.RowHeadersVisible = false;
            this.dgPull1.Size = new System.Drawing.Size(206, 280);
            this.dgPull1.TabIndex = 4;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 55;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Width = 62;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 62;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(175, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Config";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnPull1Stop
            // 
            this.btnPull1Stop.Location = new System.Drawing.Point(108, 100);
            this.btnPull1Stop.Name = "btnPull1Stop";
            this.btnPull1Stop.Size = new System.Drawing.Size(104, 23);
            this.btnPull1Stop.TabIndex = 4;
            this.btnPull1Stop.Text = "Stop";
            this.btnPull1Stop.UseVisualStyleBackColor = true;
            this.btnPull1Stop.Click += new System.EventHandler(this.btnPull1Stop_Click);
            // 
            // btnPull1Start
            // 
            this.btnPull1Start.Location = new System.Drawing.Point(6, 100);
            this.btnPull1Start.Name = "btnPull1Start";
            this.btnPull1Start.Size = new System.Drawing.Size(96, 23);
            this.btnPull1Start.TabIndex = 2;
            this.btnPull1Start.Text = "Start";
            this.btnPull1Start.UseVisualStyleBackColor = true;
            this.btnPull1Start.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gammu-smsd";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh Scheduler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatusPull1
            // 
            this.lblStatusPull1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatusPull1.AutoSize = true;
            this.lblStatusPull1.Location = new System.Drawing.Point(5, 41);
            this.lblStatusPull1.Name = "lblStatusPull1";
            this.lblStatusPull1.Size = new System.Drawing.Size(30, 13);
            this.lblStatusPull1.TabIndex = 6;
            this.lblStatusPull1.Text = "Pull1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timerMonitPull1
            // 
            this.timerMonitPull1.Interval = 1000;
            this.timerMonitPull1.Tick += new System.EventHandler(this.timerMonitPull1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "MultiPull \r\nController";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.labelJam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 471);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(-51, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 10);
            this.label4.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.9084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0916F));
            this.tableLayoutPanel1.Controls.Add(this.lblStatusPull1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picStatusPull1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.picStatusPull2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 142);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(80, 64);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // picStatusPull1
            // 
            this.picStatusPull1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picStatusPull1.Image = global::GammuMonitoring.Properties.Resources.power_on;
            this.picStatusPull1.InitialImage = global::GammuMonitoring.Properties.Resources.power;
            this.picStatusPull1.Location = new System.Drawing.Point(8, 3);
            this.picStatusPull1.Name = "picStatusPull1";
            this.picStatusPull1.Size = new System.Drawing.Size(24, 26);
            this.picStatusPull1.TabIndex = 5;
            this.picStatusPull1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pull2";
            // 
            // picStatusPull2
            // 
            this.picStatusPull2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picStatusPull2.Image = global::GammuMonitoring.Properties.Resources.power_on;
            this.picStatusPull2.InitialImage = global::GammuMonitoring.Properties.Resources.power;
            this.picStatusPull2.Location = new System.Drawing.Point(48, 3);
            this.picStatusPull2.Name = "picStatusPull2";
            this.picStatusPull2.Size = new System.Drawing.Size(24, 26);
            this.picStatusPull2.TabIndex = 7;
            this.picStatusPull2.TabStop = false;
            // 
            // labelJam
            // 
            this.labelJam.AutoSize = true;
            this.labelJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJam.ForeColor = System.Drawing.Color.Red;
            this.labelJam.Location = new System.Drawing.Point(12, 94);
            this.labelJam.Name = "labelJam";
            this.labelJam.Size = new System.Drawing.Size(111, 29);
            this.labelJam.TabIndex = 4;
            this.labelJam.Text = "00:00:00";
            // 
            // timerJam
            // 
            this.timerJam.Interval = 1000;
            this.timerJam.Tick += new System.EventHandler(this.timerJam_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEnablePull2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.dgPull2);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.btnPull2Stop);
            this.groupBox1.Controls.Add(this.btnPull2Start);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnLocationPull2);
            this.groupBox1.Controls.Add(this.txtLocationPull2);
            this.groupBox1.Controls.Add(this.btnSchedulePull2);
            this.groupBox1.Location = new System.Drawing.Point(430, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 471);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    Pull2";
            // 
            // chkEnablePull2
            // 
            this.chkEnablePull2.AutoSize = true;
            this.chkEnablePull2.Location = new System.Drawing.Point(6, 0);
            this.chkEnablePull2.Name = "chkEnablePull2";
            this.chkEnablePull2.Size = new System.Drawing.Size(15, 14);
            this.chkEnablePull2.TabIndex = 10;
            this.chkEnablePull2.UseVisualStyleBackColor = true;
            this.chkEnablePull2.CheckedChanged += new System.EventHandler(this.chkEnablePull2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Schedule";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.lblProcessId2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(6, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 32);
            this.panel3.TabIndex = 8;
            // 
            // lblProcessId2
            // 
            this.lblProcessId2.AutoSize = true;
            this.lblProcessId2.Location = new System.Drawing.Point(63, 9);
            this.lblProcessId2.Name = "lblProcessId2";
            this.lblProcessId2.Size = new System.Drawing.Size(10, 13);
            this.lblProcessId2.TabIndex = 2;
            this.lblProcessId2.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Proses ID";
            // 
            // dgPull2
            // 
            this.dgPull2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPull2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPull2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgPull2.Location = new System.Drawing.Point(6, 153);
            this.dgPull2.Name = "dgPull2";
            this.dgPull2.RowHeadersVisible = false;
            this.dgPull2.Size = new System.Drawing.Size(206, 280);
            this.dgPull2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Action";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 62;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(175, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(37, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Config";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnPull2Stop
            // 
            this.btnPull2Stop.Location = new System.Drawing.Point(108, 100);
            this.btnPull2Stop.Name = "btnPull2Stop";
            this.btnPull2Stop.Size = new System.Drawing.Size(104, 23);
            this.btnPull2Stop.TabIndex = 4;
            this.btnPull2Stop.Text = "Stop";
            this.btnPull2Stop.UseVisualStyleBackColor = true;
            this.btnPull2Stop.Click += new System.EventHandler(this.btnPull2Stop_Click);
            // 
            // btnPull2Start
            // 
            this.btnPull2Start.Location = new System.Drawing.Point(6, 100);
            this.btnPull2Start.Name = "btnPull2Start";
            this.btnPull2Start.Size = new System.Drawing.Size(96, 23);
            this.btnPull2Start.TabIndex = 2;
            this.btnPull2Start.Text = "Start";
            this.btnPull2Start.UseVisualStyleBackColor = true;
            this.btnPull2Start.Click += new System.EventHandler(this.lblPull2Start_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Gammu-smsd";
            // 
            // btnLocationPull2
            // 
            this.btnLocationPull2.Location = new System.Drawing.Point(190, 38);
            this.btnLocationPull2.Name = "btnLocationPull2";
            this.btnLocationPull2.Size = new System.Drawing.Size(22, 20);
            this.btnLocationPull2.TabIndex = 2;
            this.btnLocationPull2.Text = "...";
            this.btnLocationPull2.UseVisualStyleBackColor = true;
            this.btnLocationPull2.Click += new System.EventHandler(this.btnLocationPull2_Click);
            // 
            // txtLocationPull2
            // 
            this.txtLocationPull2.Location = new System.Drawing.Point(6, 38);
            this.txtLocationPull2.Name = "txtLocationPull2";
            this.txtLocationPull2.Size = new System.Drawing.Size(178, 20);
            this.txtLocationPull2.TabIndex = 2;
            // 
            // btnSchedulePull2
            // 
            this.btnSchedulePull2.Location = new System.Drawing.Point(6, 439);
            this.btnSchedulePull2.Name = "btnSchedulePull2";
            this.btnSchedulePull2.Size = new System.Drawing.Size(203, 23);
            this.btnSchedulePull2.TabIndex = 1;
            this.btnSchedulePull2.Text = "Refresh Scheduler";
            this.btnSchedulePull2.UseVisualStyleBackColor = true;
            this.btnSchedulePull2.Click += new System.EventHandler(this.btnSchedulePull2_Click);
            // 
            // timerMonitPull2
            // 
            this.timerMonitPull2.Interval = 1000;
            this.timerMonitPull2.Tick += new System.EventHandler(this.timerMonitPull2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPull1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nuwira MultiPull Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPull1.ResumeLayout(false);
            this.grpPull1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPull1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusPull1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusPull2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPull2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPull1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerMonitPull1;
        private System.Windows.Forms.Button btnPull1Stop;
        private System.Windows.Forms.Button btnPull1Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelJam;
        private System.Windows.Forms.Timer timerJam;
        private System.Windows.Forms.PictureBox picStatusPull1;
        private System.Windows.Forms.Label lblStatusPull1;
        private System.Windows.Forms.DataGridView dgPull1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProcessId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkEnablePull1;
        private System.Windows.Forms.PictureBox picStatusPull2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEnablePull2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgPull2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnPull2Stop;
        private System.Windows.Forms.Button btnPull2Start;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLocationPull2;
        private System.Windows.Forms.TextBox txtLocationPull2;
        private System.Windows.Forms.Button btnSchedulePull2;
        private System.Windows.Forms.Timer timerMonitPull2;
        private System.Windows.Forms.Label lblProcessId2;
    }
}

