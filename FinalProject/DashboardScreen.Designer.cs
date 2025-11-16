namespace FinalProject
{
    partial class DashboardScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardScreen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNavbar = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panelScannerStatus = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblConnectStatus = new System.Windows.Forms.Label();
            this.lblScannerStatus = new System.Windows.Forms.Label();
            this.panelScanToday = new System.Windows.Forms.Panel();
            this.lblTodayNum = new System.Windows.Forms.Label();
            this.lblScanToday = new System.Windows.Forms.Label();
            this.panelTotalScans = new System.Windows.Forms.Panel();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.lblTotalScans = new System.Windows.Forms.Label();
            this.panelThisWeek = new System.Windows.Forms.Panel();
            this.lblWeekNum = new System.Windows.Forms.Label();
            this.lblThisWeek = new System.Windows.Forms.Label();
            this.panelRecentScans = new System.Windows.Forms.Panel();
            this.dgvRecentScans = new System.Windows.Forms.DataGridView();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnScanHistory = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecentScans = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelScannerStatus.SuspendLayout();
            this.panelScanToday.SuspendLayout();
            this.panelTotalScans.SuspendLayout();
            this.panelThisWeek.SuspendLayout();
            this.panelRecentScans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentScans)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblNavbar);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2056, 171);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.btnLogout.Location = new System.Drawing.Point(1765, 54);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 68);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(1684, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 102);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1489, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1057, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Roan University";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(965, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(1405, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 102);
            this.panel2.TabIndex = 1;
            // 
            // lblNavbar
            // 
            this.lblNavbar.AutoSize = true;
            this.lblNavbar.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavbar.ForeColor = System.Drawing.Color.White;
            this.lblNavbar.Location = new System.Drawing.Point(51, 58);
            this.lblNavbar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNavbar.Name = "lblNavbar";
            this.lblNavbar.Size = new System.Drawing.Size(592, 52);
            this.lblNavbar.TabIndex = 0;
            this.lblNavbar.Text = " Student ID Scanning System";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(71, 218);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(377, 43);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard Overview";
            // 
            // panelScannerStatus
            // 
            this.panelScannerStatus.BackColor = System.Drawing.Color.White;
            this.panelScannerStatus.Controls.Add(this.lblType);
            this.panelScannerStatus.Controls.Add(this.cmbType);
            this.panelScannerStatus.Controls.Add(this.lblConnectStatus);
            this.panelScannerStatus.Controls.Add(this.lblScannerStatus);
            this.panelScannerStatus.ForeColor = System.Drawing.Color.Transparent;
            this.panelScannerStatus.Location = new System.Drawing.Point(79, 283);
            this.panelScannerStatus.Margin = new System.Windows.Forms.Padding(4);
            this.panelScannerStatus.Name = "panelScannerStatus";
            this.panelScannerStatus.Size = new System.Drawing.Size(425, 214);
            this.panelScannerStatus.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(32, 146);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(84, 37);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Barcode",
            "QR Code",
            "RFID"});
            this.cmbType.Location = new System.Drawing.Point(133, 143);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(245, 45);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblConnectStatus
            // 
            this.lblConnectStatus.AutoSize = true;
            this.lblConnectStatus.BackColor = System.Drawing.Color.LimeGreen;
            this.lblConnectStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConnectStatus.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectStatus.ForeColor = System.Drawing.Color.White;
            this.lblConnectStatus.Location = new System.Drawing.Point(126, 79);
            this.lblConnectStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConnectStatus.Name = "lblConnectStatus";
            this.lblConnectStatus.Size = new System.Drawing.Size(150, 37);
            this.lblConnectStatus.TabIndex = 2;
            this.lblConnectStatus.Text = "Connected";
            // 
            // lblScannerStatus
            // 
            this.lblScannerStatus.AutoSize = true;
            this.lblScannerStatus.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScannerStatus.ForeColor = System.Drawing.Color.Black;
            this.lblScannerStatus.Location = new System.Drawing.Point(93, 26);
            this.lblScannerStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScannerStatus.Name = "lblScannerStatus";
            this.lblScannerStatus.Size = new System.Drawing.Size(227, 41);
            this.lblScannerStatus.TabIndex = 1;
            this.lblScannerStatus.Text = "Scanner Status";
            // 
            // panelScanToday
            // 
            this.panelScanToday.BackColor = System.Drawing.Color.White;
            this.panelScanToday.Controls.Add(this.lblTodayNum);
            this.panelScanToday.Controls.Add(this.lblScanToday);
            this.panelScanToday.ForeColor = System.Drawing.Color.Transparent;
            this.panelScanToday.Location = new System.Drawing.Point(575, 283);
            this.panelScanToday.Margin = new System.Windows.Forms.Padding(4);
            this.panelScanToday.Name = "panelScanToday";
            this.panelScanToday.Size = new System.Drawing.Size(425, 214);
            this.panelScanToday.TabIndex = 3;
            // 
            // lblTodayNum
            // 
            this.lblTodayNum.AutoSize = true;
            this.lblTodayNum.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayNum.ForeColor = System.Drawing.Color.Orange;
            this.lblTodayNum.Location = new System.Drawing.Point(185, 92);
            this.lblTodayNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayNum.Name = "lblTodayNum";
            this.lblTodayNum.Size = new System.Drawing.Size(62, 73);
            this.lblTodayNum.TabIndex = 1;
            this.lblTodayNum.Text = "1";
            this.lblTodayNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTodayNum.Click += new System.EventHandler(this.lblTodayNum_Click);
            // 
            // lblScanToday
            // 
            this.lblScanToday.AutoSize = true;
            this.lblScanToday.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanToday.ForeColor = System.Drawing.Color.Black;
            this.lblScanToday.Location = new System.Drawing.Point(128, 26);
            this.lblScanToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanToday.Name = "lblScanToday";
            this.lblScanToday.Size = new System.Drawing.Size(173, 41);
            this.lblScanToday.TabIndex = 0;
            this.lblScanToday.Text = "Scan Today";
            // 
            // panelTotalScans
            // 
            this.panelTotalScans.BackColor = System.Drawing.Color.White;
            this.panelTotalScans.Controls.Add(this.lblTotalNum);
            this.panelTotalScans.Controls.Add(this.lblTotalScans);
            this.panelTotalScans.ForeColor = System.Drawing.Color.Transparent;
            this.panelTotalScans.Location = new System.Drawing.Point(1560, 283);
            this.panelTotalScans.Margin = new System.Windows.Forms.Padding(4);
            this.panelTotalScans.Name = "panelTotalScans";
            this.panelTotalScans.Size = new System.Drawing.Size(425, 214);
            this.panelTotalScans.TabIndex = 5;
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotalNum.Location = new System.Drawing.Point(176, 92);
            this.lblTotalNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(62, 73);
            this.lblTotalNum.TabIndex = 3;
            this.lblTotalNum.Text = "1";
            this.lblTotalNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalScans
            // 
            this.lblTotalScans.AutoSize = true;
            this.lblTotalScans.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScans.ForeColor = System.Drawing.Color.Black;
            this.lblTotalScans.Location = new System.Drawing.Point(115, 26);
            this.lblTotalScans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalScans.Name = "lblTotalScans";
            this.lblTotalScans.Size = new System.Drawing.Size(174, 41);
            this.lblTotalScans.TabIndex = 3;
            this.lblTotalScans.Text = "Total Scans";
            // 
            // panelThisWeek
            // 
            this.panelThisWeek.BackColor = System.Drawing.Color.White;
            this.panelThisWeek.Controls.Add(this.lblWeekNum);
            this.panelThisWeek.Controls.Add(this.lblThisWeek);
            this.panelThisWeek.ForeColor = System.Drawing.Color.Transparent;
            this.panelThisWeek.Location = new System.Drawing.Point(1064, 283);
            this.panelThisWeek.Margin = new System.Windows.Forms.Padding(4);
            this.panelThisWeek.Name = "panelThisWeek";
            this.panelThisWeek.Size = new System.Drawing.Size(425, 214);
            this.panelThisWeek.TabIndex = 4;
            // 
            // lblWeekNum
            // 
            this.lblWeekNum.AutoSize = true;
            this.lblWeekNum.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekNum.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblWeekNum.Location = new System.Drawing.Point(179, 92);
            this.lblWeekNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeekNum.Name = "lblWeekNum";
            this.lblWeekNum.Size = new System.Drawing.Size(62, 73);
            this.lblWeekNum.TabIndex = 2;
            this.lblWeekNum.Text = "1";
            this.lblWeekNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThisWeek
            // 
            this.lblThisWeek.AutoSize = true;
            this.lblThisWeek.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisWeek.ForeColor = System.Drawing.Color.Black;
            this.lblThisWeek.Location = new System.Drawing.Point(125, 26);
            this.lblThisWeek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThisWeek.Name = "lblThisWeek";
            this.lblThisWeek.Size = new System.Drawing.Size(163, 41);
            this.lblThisWeek.TabIndex = 2;
            this.lblThisWeek.Text = "This Week";
            // 
            // panelRecentScans
            // 
            this.panelRecentScans.BackColor = System.Drawing.Color.White;
            this.panelRecentScans.Controls.Add(this.dgvRecentScans);
            this.panelRecentScans.ForeColor = System.Drawing.Color.Transparent;
            this.panelRecentScans.Location = new System.Drawing.Point(79, 582);
            this.panelRecentScans.Margin = new System.Windows.Forms.Padding(4);
            this.panelRecentScans.Name = "panelRecentScans";
            this.panelRecentScans.Size = new System.Drawing.Size(1907, 256);
            this.panelRecentScans.TabIndex = 3;
            this.panelRecentScans.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRecentScans_Paint);
            // 
            // dgvRecentScans
            // 
            this.dgvRecentScans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentScans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecentScans.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentScans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentScans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentScans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentScans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentScans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateTime,
            this.colStudId,
            this.colStudentName,
            this.colScanType,
            this.colStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentScans.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentScans.Location = new System.Drawing.Point(4, 11);
            this.dgvRecentScans.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecentScans.Name = "dgvRecentScans";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentScans.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentScans.RowHeadersWidth = 51;
            this.dgvRecentScans.Size = new System.Drawing.Size(1899, 241);
            this.dgvRecentScans.TabIndex = 0;
            this.dgvRecentScans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentScans_CellContentClick);
            // 
            // colDateTime
            // 
            this.colDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDateTime.HeaderText = "Date / Time";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            // 
            // colStudId
            // 
            this.colStudId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStudId.HeaderText = "Student ID";
            this.colStudId.MinimumWidth = 6;
            this.colStudId.Name = "colStudId";
            // 
            // colStudentName
            // 
            this.colStudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStudentName.HeaderText = "Student Name";
            this.colStudentName.MinimumWidth = 6;
            this.colStudentName.Name = "colStudentName";
            // 
            // colScanType
            // 
            this.colScanType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colScanType.HeaderText = "Scan Type";
            this.colScanType.MinimumWidth = 6;
            this.colScanType.Name = "colScanType";
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(145, 875);
            this.btnScan.Margin = new System.Windows.Forms.Padding(4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(248, 68);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnScanHistory
            // 
            this.btnScanHistory.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanHistory.Location = new System.Drawing.Point(899, 875);
            this.btnScanHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnScanHistory.Name = "btnScanHistory";
            this.btnScanHistory.Size = new System.Drawing.Size(248, 68);
            this.btnScanHistory.TabIndex = 8;
            this.btnScanHistory.Text = "Scan History";
            this.btnScanHistory.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Location = new System.Drawing.Point(1673, 875);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(248, 68);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.lblRecentScans);
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(79, 529);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1907, 65);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.StudentID,
            this.StudentName,
            this.ScanType,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(29, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(943, 244);
            this.dataGridView1.TabIndex = 1;
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateTime.HeaderText = "Date / Time";
            this.DateTime.MinimumWidth = 6;
            this.DateTime.Name = "DateTime";
            this.DateTime.Width = 106;
            // 
            // StudentID
            // 
            this.StudentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 97;
            // 
            // StudentName
            // 
            this.StudentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 121;
            // 
            // ScanType
            // 
            this.ScanType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ScanType.HeaderText = "Scan Type";
            this.ScanType.MinimumWidth = 6;
            this.ScanType.Name = "ScanType";
            this.ScanType.Width = 102;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 73;
            // 
            // lblRecentScans
            // 
            this.lblRecentScans.AutoSize = true;
            this.lblRecentScans.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentScans.ForeColor = System.Drawing.Color.White;
            this.lblRecentScans.Location = new System.Drawing.Point(32, 15);
            this.lblRecentScans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecentScans.Name = "lblRecentScans";
            this.lblRecentScans.Size = new System.Drawing.Size(193, 36);
            this.lblRecentScans.TabIndex = 0;
            this.lblRecentScans.Text = "Recent Scans";
            this.lblRecentScans.Click += new System.EventHandler(this.lblRecentScans_Click);
            // 
            // DashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(111)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1924, 961);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnScanHistory);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.panelRecentScans);
            this.Controls.Add(this.panelTotalScans);
            this.Controls.Add(this.panelScanToday);
            this.Controls.Add(this.panelThisWeek);
            this.Controls.Add(this.panelScannerStatus);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Roan University";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelScannerStatus.ResumeLayout(false);
            this.panelScannerStatus.PerformLayout();
            this.panelScanToday.ResumeLayout(false);
            this.panelScanToday.PerformLayout();
            this.panelTotalScans.ResumeLayout(false);
            this.panelTotalScans.PerformLayout();
            this.panelThisWeek.ResumeLayout(false);
            this.panelThisWeek.PerformLayout();
            this.panelRecentScans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentScans)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNavbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel panelScannerStatus;
        private System.Windows.Forms.Panel panelScanToday;
        private System.Windows.Forms.Panel panelTotalScans;
        private System.Windows.Forms.Panel panelThisWeek;
        private System.Windows.Forms.Panel panelRecentScans;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnScanHistory;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblScannerStatus;
        private System.Windows.Forms.Label lblScanToday;
        private System.Windows.Forms.Label lblThisWeek;
        private System.Windows.Forms.Label lblTotalScans;
        private System.Windows.Forms.Label lblRecentScans;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dgvRecentScans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label lblTodayNum;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.Label lblWeekNum;
        private System.Windows.Forms.Label lblConnectStatus;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
    }
}