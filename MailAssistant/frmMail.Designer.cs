namespace MailAssistant
{
    partial class frmMail
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSmtpName = new System.Windows.Forms.ComboBox();
            this.muPort = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSMTP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMailList = new System.Windows.Forms.DataGridView();
            this.mailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtRecAddr = new System.Windows.Forms.TextBox();
            this.cmbAt = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTimeType = new System.Windows.Forms.ComboBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtTimeInter = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStopSend = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnTimeSend = new System.Windows.Forms.Button();
            this.openFileAttach = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMailList)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(444, 487);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSmtpName);
            this.groupBox1.Controls.Add(this.muPort);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbSMTP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMTP";
            // 
            // cmbSmtpName
            // 
            this.cmbSmtpName.FormattingEnabled = true;
            this.cmbSmtpName.Items.AddRange(new object[] {
            "qq",
            "126",
            "139",
            "163"});
            this.cmbSmtpName.Location = new System.Drawing.Point(43, 20);
            this.cmbSmtpName.Name = "cmbSmtpName";
            this.cmbSmtpName.Size = new System.Drawing.Size(68, 20);
            this.cmbSmtpName.TabIndex = 5;
            this.cmbSmtpName.Text = "qq";
            // 
            // muPort
            // 
            this.muPort.Location = new System.Drawing.Point(237, 21);
            this.muPort.Name = "muPort";
            this.muPort.Size = new System.Drawing.Size(60, 21);
            this.muPort.TabIndex = 4;
            this.muPort.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "端口：";
            // 
            // cmbSMTP
            // 
            this.cmbSMTP.FormattingEnabled = true;
            this.cmbSMTP.Items.AddRange(new object[] {
            ".com"});
            this.cmbSMTP.Location = new System.Drawing.Point(122, 21);
            this.cmbSMTP.Name = "cmbSMTP";
            this.cmbSMTP.Size = new System.Drawing.Size(60, 20);
            this.cmbSMTP.TabIndex = 2;
            this.cmbSMTP.Text = ".com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "SMTP.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPsw);
            this.groupBox2.Controls.Add(this.cmbFrom);
            this.groupBox2.Controls.Add(this.txtFrom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发件人";
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(80, 36);
            this.txtPsw.MaxLength = 30;
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '*';
            this.txtPsw.Size = new System.Drawing.Size(248, 21);
            this.txtPsw.TabIndex = 4;
            this.txtPsw.Text = "zhouhy$%";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Items.AddRange(new object[] {
            "@qq.com",
            "@126.com",
            "@139.com",
            "@163.com"});
            this.cmbFrom.Location = new System.Drawing.Point(237, 11);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(91, 20);
            this.cmbFrom.TabIndex = 3;
            this.cmbFrom.Text = "@qq.com";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(80, 11);
            this.txtFrom.MaxLength = 30;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(151, 21);
            this.txtFrom.TabIndex = 2;
            this.txtFrom.Text = "624592410";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "邮箱地址：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 271);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "收件人";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.dgvMailList, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(432, 251);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // dgvMailList
            // 
            this.dgvMailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMailList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mailAddress,
            this.describe});
            this.dgvMailList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMailList.Location = new System.Drawing.Point(78, 35);
            this.dgvMailList.Name = "dgvMailList";
            this.dgvMailList.RowTemplate.Height = 23;
            this.dgvMailList.Size = new System.Drawing.Size(351, 213);
            this.dgvMailList.TabIndex = 5;
            // 
            // mailAddress
            // 
            this.mailAddress.HeaderText = "邮箱地址";
            this.mailAddress.Name = "mailAddress";
            this.mailAddress.Width = 200;
            // 
            // describe
            // 
            this.describe.HeaderText = "描述";
            this.describe.Name = "describe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "添加列表：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "邮箱地址：";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtRecAddr);
            this.flowLayoutPanel1.Controls.Add(this.cmbAt);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnDel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(78, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 26);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // txtRecAddr
            // 
            this.txtRecAddr.Location = new System.Drawing.Point(3, 3);
            this.txtRecAddr.MaxLength = 30;
            this.txtRecAddr.Name = "txtRecAddr";
            this.txtRecAddr.Size = new System.Drawing.Size(100, 21);
            this.txtRecAddr.TabIndex = 2;
            this.txtRecAddr.Tag = "";
            this.txtRecAddr.Text = "709757455";
            // 
            // cmbAt
            // 
            this.cmbAt.FormattingEnabled = true;
            this.cmbAt.Items.AddRange(new object[] {
            "@qq.com",
            "@126.com",
            "@163.com",
            "@139.com"});
            this.cmbAt.Location = new System.Drawing.Point(109, 3);
            this.cmbAt.Name = "cmbAt";
            this.cmbAt.Size = new System.Drawing.Size(73, 20);
            this.cmbAt.TabIndex = 3;
            this.cmbAt.Text = "@qq.com";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(269, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.cmbTimeType);
            this.groupBox5.Controls.Add(this.txtHour);
            this.groupBox5.Controls.Add(this.txtMin);
            this.groupBox5.Controls.Add(this.txtDay);
            this.groupBox5.Controls.Add(this.txtTimeInter);
            this.groupBox5.Controls.Add(this.txtYear);
            this.groupBox5.Controls.Add(this.txtMonth);
            this.groupBox5.Controls.Add(this.txtSec);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 133);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(438, 74);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送时间配置";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "发送时间：";
            // 
            // cmbTimeType
            // 
            this.cmbTimeType.FormattingEnabled = true;
            this.cmbTimeType.Items.AddRange(new object[] {
            "小时",
            "分钟",
            "秒"});
            this.cmbTimeType.Location = new System.Drawing.Point(122, 47);
            this.cmbTimeType.Name = "cmbTimeType";
            this.cmbTimeType.Size = new System.Drawing.Size(60, 20);
            this.cmbTimeType.TabIndex = 3;
            this.cmbTimeType.Text = "分钟";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(249, 20);
            this.txtHour.MaxLength = 2;
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(30, 21);
            this.txtHour.TabIndex = 2;
            this.txtHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtHour.Leave += new System.EventHandler(this.txtHour_Leave);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(306, 20);
            this.txtMin.MaxLength = 2;
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(30, 21);
            this.txtMin.TabIndex = 2;
            this.txtMin.Text = "0";
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtMin.Leave += new System.EventHandler(this.txtMin_Leave);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(192, 20);
            this.txtDay.MaxLength = 2;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(30, 21);
            this.txtDay.TabIndex = 2;
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtDay.Leave += new System.EventHandler(this.txtDay_Leave);
            // 
            // txtTimeInter
            // 
            this.txtTimeInter.Location = new System.Drawing.Point(68, 47);
            this.txtTimeInter.MaxLength = 2;
            this.txtTimeInter.Name = "txtTimeInter";
            this.txtTimeInter.Size = new System.Drawing.Size(40, 21);
            this.txtTimeInter.TabIndex = 2;
            this.txtTimeInter.Text = "5";
            this.txtTimeInter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtTimeInter.Leave += new System.EventHandler(this.txtTimeInter_Leave);
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Location = new System.Drawing.Point(68, 20);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(40, 21);
            this.txtYear.TabIndex = 2;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(135, 20);
            this.txtMonth.MaxLength = 2;
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(30, 21);
            this.txtMonth.TabIndex = 2;
            this.txtMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            this.txtMonth.Leave += new System.EventHandler(this.txtMonth_Leave);
            // 
            // txtSec
            // 
            this.txtSec.Enabled = false;
            this.txtSec.Location = new System.Drawing.Point(363, 20);
            this.txtSec.MaxLength = 2;
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(30, 21);
            this.txtSec.TabIndex = 2;
            this.txtSec.Text = "0";
            this.txtSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "每隔：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(398, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "秒";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(341, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "分";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(284, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "时";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "日";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "月";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "年";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(993, 493);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(453, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 487);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "消息主体";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.rTxtContent, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(531, 467);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(51, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(477, 21);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "邮件主题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "附件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "正文：";
            // 
            // rTxtContent
            // 
            this.rTxtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtContent.Location = new System.Drawing.Point(51, 73);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.Size = new System.Drawing.Size(477, 344);
            this.rTxtContent.TabIndex = 4;
            this.rTxtContent.Text = "邮件主体";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txtBrowse);
            this.flowLayoutPanel2.Controls.Add(this.btBrowse);
            this.flowLayoutPanel2.Controls.Add(this.btnClear);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(51, 33);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(477, 34);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(3, 3);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(276, 21);
            this.txtBrowse.TabIndex = 0;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(285, 3);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "浏览(&B)";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(366, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清空(&C)";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnStopSend, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSendMail, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnTimeSend, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(51, 423);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(477, 41);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // btnStopSend
            // 
            this.btnStopSend.Enabled = false;
            this.btnStopSend.Location = new System.Drawing.Point(180, 3);
            this.btnStopSend.Name = "btnStopSend";
            this.btnStopSend.Size = new System.Drawing.Size(94, 34);
            this.btnStopSend.TabIndex = 5;
            this.btnStopSend.Text = "停止发送(&S)";
            this.btnStopSend.UseVisualStyleBackColor = true;
            this.btnStopSend.Click += new System.EventHandler(this.btnStopSend_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(380, 3);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(94, 34);
            this.btnSendMail.TabIndex = 5;
            this.btnSendMail.Text = "发送(&S)";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnTimeSend
            // 
            this.btnTimeSend.Location = new System.Drawing.Point(280, 3);
            this.btnTimeSend.Name = "btnTimeSend";
            this.btnTimeSend.Size = new System.Drawing.Size(94, 34);
            this.btnTimeSend.TabIndex = 5;
            this.btnTimeSend.Text = "定时发送(&T)";
            this.btnTimeSend.UseVisualStyleBackColor = true;
            this.btnTimeSend.Click += new System.EventHandler(this.btnTimeSend_Click);
            // 
            // openFileAttach
            // 
            this.openFileAttach.Multiselect = true;
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 493);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "frmMail";
            this.Text = "邮件助手(Mail Assistemt)--QQ邮箱需要在邮箱中设置->账户里，有一个选项\"开启POP3/SMTP服务\"需要勾选";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMail_FormClosed);
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMailList)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTxtContent;
        private System.Windows.Forms.NumericUpDown muPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSMTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMailList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAt;
        private System.Windows.Forms.TextBox txtRecAddr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTimeType;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtTimeInter;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.OpenFileDialog openFileAttach;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn describe;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnTimeSend;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnStopSend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cmbSmtpName;
    }
}

