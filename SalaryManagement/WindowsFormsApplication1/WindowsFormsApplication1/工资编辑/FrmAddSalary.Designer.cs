namespace WindowsFormsApplication1
{
    partial class FrmAddSalary
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
            this.lblNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.gpbAwllance = new System.Windows.Forms.GroupBox();
            this.cbAwllDBYW_3000 = new System.Windows.Forms.CheckBox();
            this.cbAwllCL_500 = new System.Windows.Forms.CheckBox();
            this.cbAwllWH_200 = new System.Windows.Forms.CheckBox();
            this.cbAwllJT_150 = new System.Windows.Forms.CheckBox();
            this.cbAwllSZ_3000 = new System.Windows.Forms.CheckBox();
            this.gpbBenifit = new System.Windows.Forms.GroupBox();
            this.cbBenifitTSJS_800 = new System.Windows.Forms.CheckBox();
            this.cbBenifitYB_400 = new System.Windows.Forms.CheckBox();
            this.cbBenifitGW_400 = new System.Windows.Forms.CheckBox();
            this.gpbAwd = new System.Windows.Forms.GroupBox();
            this.cbAwdContribute_300 = new System.Windows.Forms.CheckBox();
            this.cbAwdCreative_500 = new System.Windows.Forms.CheckBox();
            this.cbPunNoAskAbsence_90 = new System.Windows.Forms.CheckBox();
            this.gpbPun = new System.Windows.Forms.GroupBox();
            this.gpbLateOut20_50 = new System.Windows.Forms.GroupBox();
            this.rdoThreeTimesDead_150 = new System.Windows.Forms.RadioButton();
            this.rdoTwoTimes_100 = new System.Windows.Forms.RadioButton();
            this.rdoOneTime_50 = new System.Windows.Forms.RadioButton();
            this.gpbLateIn20_20 = new System.Windows.Forms.GroupBox();
            this.rdoThreeTimes_60 = new System.Windows.Forms.RadioButton();
            this.rdoTwice_40 = new System.Windows.Forms.RadioButton();
            this.rdoOnce_20 = new System.Windows.Forms.RadioButton();
            this.lstbAllwance = new System.Windows.Forms.ListBox();
            this.lstbBenifit = new System.Windows.Forms.ListBox();
            this.lstbAwd = new System.Windows.Forms.ListBox();
            this.lstbPun = new System.Windows.Forms.ListBox();
            this.txtAllwanceSum = new System.Windows.Forms.TextBox();
            this.txtBenifitSum = new System.Windows.Forms.TextBox();
            this.txtAwdSum = new System.Windows.Forms.TextBox();
            this.txtPunSum = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllSum = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblOperatorNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnBrowseAttendence = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSubmitt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSumUp = new System.Windows.Forms.Button();
            this.btnBrowseAwd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbAwllance.SuspendLayout();
            this.gpbBenifit.SuspendLayout();
            this.gpbAwd.SuspendLayout();
            this.gpbPun.SuspendLayout();
            this.gpbLateOut20_50.SuspendLayout();
            this.gpbLateIn20_20.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(43, 21);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(41, 12);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "编号：";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(90, 18);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 21);
            this.txtNo.TabIndex = 1;
            this.txtNo.Leave += new System.EventHandler(this.txtNo_Leave);
            // 
            // gpbAwllance
            // 
            this.gpbAwllance.Controls.Add(this.cbAwllDBYW_3000);
            this.gpbAwllance.Controls.Add(this.cbAwllCL_500);
            this.gpbAwllance.Controls.Add(this.cbAwllWH_200);
            this.gpbAwllance.Controls.Add(this.cbAwllJT_150);
            this.gpbAwllance.Controls.Add(this.cbAwllSZ_3000);
            this.gpbAwllance.Location = new System.Drawing.Point(12, 57);
            this.gpbAwllance.Name = "gpbAwllance";
            this.gpbAwllance.Size = new System.Drawing.Size(131, 153);
            this.gpbAwllance.TabIndex = 2;
            this.gpbAwllance.TabStop = false;
            this.gpbAwllance.Text = "补贴";
            // 
            // cbAwllDBYW_3000
            // 
            this.cbAwllDBYW_3000.AutoSize = true;
            this.cbAwllDBYW_3000.Location = new System.Drawing.Point(16, 125);
            this.cbAwllDBYW_3000.Name = "cbAwllDBYW_3000";
            this.cbAwllDBYW_3000.Size = new System.Drawing.Size(96, 16);
            this.cbAwllDBYW_3000.TabIndex = 4;
            this.cbAwllDBYW_3000.Tag = "3000";
            this.cbAwllDBYW_3000.Text = "大病意外补贴";
            this.cbAwllDBYW_3000.UseVisualStyleBackColor = true;
            this.cbAwllDBYW_3000.CheckedChanged += new System.EventHandler(this.cbAwll_SZ_CheckedChanged);
            // 
            // cbAwllCL_500
            // 
            this.cbAwllCL_500.AutoSize = true;
            this.cbAwllCL_500.Location = new System.Drawing.Point(16, 100);
            this.cbAwllCL_500.Name = "cbAwllCL_500";
            this.cbAwllCL_500.Size = new System.Drawing.Size(72, 16);
            this.cbAwllCL_500.TabIndex = 3;
            this.cbAwllCL_500.Tag = "500";
            this.cbAwllCL_500.Text = "差旅补贴";
            this.cbAwllCL_500.UseVisualStyleBackColor = true;
            this.cbAwllCL_500.CheckedChanged += new System.EventHandler(this.cbAwll_SZ_CheckedChanged);
            // 
            // cbAwllWH_200
            // 
            this.cbAwllWH_200.AutoSize = true;
            this.cbAwllWH_200.Location = new System.Drawing.Point(16, 75);
            this.cbAwllWH_200.Name = "cbAwllWH_200";
            this.cbAwllWH_200.Size = new System.Drawing.Size(72, 16);
            this.cbAwllWH_200.TabIndex = 2;
            this.cbAwllWH_200.Tag = "200";
            this.cbAwllWH_200.Text = "文化补贴";
            this.cbAwllWH_200.UseVisualStyleBackColor = true;
            this.cbAwllWH_200.CheckedChanged += new System.EventHandler(this.cbAwll_SZ_CheckedChanged);
            // 
            // cbAwllJT_150
            // 
            this.cbAwllJT_150.AutoSize = true;
            this.cbAwllJT_150.Location = new System.Drawing.Point(16, 50);
            this.cbAwllJT_150.Name = "cbAwllJT_150";
            this.cbAwllJT_150.Size = new System.Drawing.Size(72, 16);
            this.cbAwllJT_150.TabIndex = 1;
            this.cbAwllJT_150.Tag = "150";
            this.cbAwllJT_150.Text = "交通补贴";
            this.cbAwllJT_150.UseVisualStyleBackColor = true;
            this.cbAwllJT_150.CheckedChanged += new System.EventHandler(this.cbAwll_SZ_CheckedChanged);
            // 
            // cbAwllSZ_3000
            // 
            this.cbAwllSZ_3000.AutoSize = true;
            this.cbAwllSZ_3000.Location = new System.Drawing.Point(16, 25);
            this.cbAwllSZ_3000.Name = "cbAwllSZ_3000";
            this.cbAwllSZ_3000.Size = new System.Drawing.Size(72, 16);
            this.cbAwllSZ_3000.TabIndex = 0;
            this.cbAwllSZ_3000.Tag = "3000";
            this.cbAwllSZ_3000.Text = "丧葬补贴";
            this.cbAwllSZ_3000.UseVisualStyleBackColor = true;
            this.cbAwllSZ_3000.CheckedChanged += new System.EventHandler(this.cbAwll_SZ_CheckedChanged);
            // 
            // gpbBenifit
            // 
            this.gpbBenifit.Controls.Add(this.cbBenifitTSJS_800);
            this.gpbBenifit.Controls.Add(this.cbBenifitYB_400);
            this.gpbBenifit.Controls.Add(this.cbBenifitGW_400);
            this.gpbBenifit.Location = new System.Drawing.Point(149, 57);
            this.gpbBenifit.Name = "gpbBenifit";
            this.gpbBenifit.Size = new System.Drawing.Size(121, 153);
            this.gpbBenifit.TabIndex = 3;
            this.gpbBenifit.TabStop = false;
            this.gpbBenifit.Text = "津贴";
            // 
            // cbBenifitTSJS_800
            // 
            this.cbBenifitTSJS_800.AutoSize = true;
            this.cbBenifitTSJS_800.Location = new System.Drawing.Point(16, 125);
            this.cbBenifitTSJS_800.Name = "cbBenifitTSJS_800";
            this.cbBenifitTSJS_800.Size = new System.Drawing.Size(96, 16);
            this.cbBenifitTSJS_800.TabIndex = 2;
            this.cbBenifitTSJS_800.Tag = "800";
            this.cbBenifitTSJS_800.Text = "特殊技术津贴";
            this.cbBenifitTSJS_800.UseVisualStyleBackColor = true;
            this.cbBenifitTSJS_800.CheckedChanged += new System.EventHandler(this.cbBenifit_GW_CheckedChanged);
            // 
            // cbBenifitYB_400
            // 
            this.cbBenifitYB_400.AutoSize = true;
            this.cbBenifitYB_400.Location = new System.Drawing.Point(16, 75);
            this.cbBenifitYB_400.Name = "cbBenifitYB_400";
            this.cbBenifitYB_400.Size = new System.Drawing.Size(72, 16);
            this.cbBenifitYB_400.TabIndex = 1;
            this.cbBenifitYB_400.Tag = "400";
            this.cbBenifitYB_400.Text = "夜班津贴";
            this.cbBenifitYB_400.UseVisualStyleBackColor = true;
            this.cbBenifitYB_400.CheckedChanged += new System.EventHandler(this.cbBenifit_GW_CheckedChanged);
            // 
            // cbBenifitGW_400
            // 
            this.cbBenifitGW_400.AutoSize = true;
            this.cbBenifitGW_400.Location = new System.Drawing.Point(16, 25);
            this.cbBenifitGW_400.Name = "cbBenifitGW_400";
            this.cbBenifitGW_400.Size = new System.Drawing.Size(72, 16);
            this.cbBenifitGW_400.TabIndex = 0;
            this.cbBenifitGW_400.Tag = "400";
            this.cbBenifitGW_400.Text = "高温津贴";
            this.cbBenifitGW_400.UseVisualStyleBackColor = true;
            this.cbBenifitGW_400.CheckedChanged += new System.EventHandler(this.cbBenifit_GW_CheckedChanged);
            // 
            // gpbAwd
            // 
            this.gpbAwd.Controls.Add(this.cbAwdContribute_300);
            this.gpbAwd.Controls.Add(this.cbAwdCreative_500);
            this.gpbAwd.Controls.Add(this.cbPunNoAskAbsence_90);
            this.gpbAwd.Location = new System.Drawing.Point(276, 57);
            this.gpbAwd.Name = "gpbAwd";
            this.gpbAwd.Size = new System.Drawing.Size(142, 153);
            this.gpbAwd.TabIndex = 4;
            this.gpbAwd.TabStop = false;
            this.gpbAwd.Text = "奖惩款项";
            // 
            // cbAwdContribute_300
            // 
            this.cbAwdContribute_300.AutoSize = true;
            this.cbAwdContribute_300.Location = new System.Drawing.Point(16, 75);
            this.cbAwdContribute_300.Name = "cbAwdContribute_300";
            this.cbAwdContribute_300.Size = new System.Drawing.Size(120, 16);
            this.cbAwdContribute_300.TabIndex = 1;
            this.cbAwdContribute_300.Tag = "300";
            this.cbAwdContribute_300.Text = "公司印象贡献奖励";
            this.cbAwdContribute_300.UseVisualStyleBackColor = true;
            this.cbAwdContribute_300.CheckedChanged += new System.EventHandler(this.cbAwd_Creative_CheckedChanged);
            // 
            // cbAwdCreative_500
            // 
            this.cbAwdCreative_500.AutoSize = true;
            this.cbAwdCreative_500.Location = new System.Drawing.Point(16, 25);
            this.cbAwdCreative_500.Name = "cbAwdCreative_500";
            this.cbAwdCreative_500.Size = new System.Drawing.Size(96, 16);
            this.cbAwdCreative_500.TabIndex = 0;
            this.cbAwdCreative_500.Tag = "500";
            this.cbAwdCreative_500.Text = "创新点子奖励";
            this.cbAwdCreative_500.UseVisualStyleBackColor = true;
            this.cbAwdCreative_500.CheckedChanged += new System.EventHandler(this.cbAwd_Creative_CheckedChanged);
            // 
            // cbPunNoAskAbsence_90
            // 
            this.cbPunNoAskAbsence_90.AutoSize = true;
            this.cbPunNoAskAbsence_90.Location = new System.Drawing.Point(16, 125);
            this.cbPunNoAskAbsence_90.Name = "cbPunNoAskAbsence_90";
            this.cbPunNoAskAbsence_90.Size = new System.Drawing.Size(96, 16);
            this.cbPunNoAskAbsence_90.TabIndex = 2;
            this.cbPunNoAskAbsence_90.Tag = "-90";
            this.cbPunNoAskAbsence_90.Text = "无假旷工一次";
            this.cbPunNoAskAbsence_90.UseVisualStyleBackColor = true;
            this.cbPunNoAskAbsence_90.CheckedChanged += new System.EventHandler(this.cbAwd_Creative_CheckedChanged);
            // 
            // gpbPun
            // 
            this.gpbPun.Controls.Add(this.gpbLateOut20_50);
            this.gpbPun.Controls.Add(this.gpbLateIn20_20);
            this.gpbPun.Location = new System.Drawing.Point(424, 57);
            this.gpbPun.Name = "gpbPun";
            this.gpbPun.Size = new System.Drawing.Size(205, 153);
            this.gpbPun.TabIndex = 5;
            this.gpbPun.TabStop = false;
            this.gpbPun.Text = "出勤惩罚";
            // 
            // gpbLateOut20_50
            // 
            this.gpbLateOut20_50.Controls.Add(this.rdoThreeTimesDead_150);
            this.gpbLateOut20_50.Controls.Add(this.rdoTwoTimes_100);
            this.gpbLateOut20_50.Controls.Add(this.rdoOneTime_50);
            this.gpbLateOut20_50.Location = new System.Drawing.Point(9, 92);
            this.gpbLateOut20_50.Name = "gpbLateOut20_50";
            this.gpbLateOut20_50.Size = new System.Drawing.Size(190, 49);
            this.gpbLateOut20_50.TabIndex = 16;
            this.gpbLateOut20_50.TabStop = false;
            this.gpbLateOut20_50.Text = "迟到20分钟以上";
            // 
            // rdoThreeTimesDead_150
            // 
            this.rdoThreeTimesDead_150.AutoSize = true;
            this.rdoThreeTimesDead_150.Location = new System.Drawing.Point(143, 21);
            this.rdoThreeTimesDead_150.Name = "rdoThreeTimesDead_150";
            this.rdoThreeTimesDead_150.Size = new System.Drawing.Size(41, 16);
            this.rdoThreeTimesDead_150.TabIndex = 2;
            this.rdoThreeTimesDead_150.TabStop = true;
            this.rdoThreeTimesDead_150.Tag = "-150";
            this.rdoThreeTimesDead_150.Text = "3次";
            this.rdoThreeTimesDead_150.UseVisualStyleBackColor = true;
            this.rdoThreeTimesDead_150.CheckedChanged += new System.EventHandler(this.rdoOneTime_CheckedChanged);
            // 
            // rdoTwoTimes_100
            // 
            this.rdoTwoTimes_100.AutoSize = true;
            this.rdoTwoTimes_100.Location = new System.Drawing.Point(76, 21);
            this.rdoTwoTimes_100.Name = "rdoTwoTimes_100";
            this.rdoTwoTimes_100.Size = new System.Drawing.Size(41, 16);
            this.rdoTwoTimes_100.TabIndex = 1;
            this.rdoTwoTimes_100.TabStop = true;
            this.rdoTwoTimes_100.Tag = "-100";
            this.rdoTwoTimes_100.Text = "2次";
            this.rdoTwoTimes_100.UseVisualStyleBackColor = true;
            this.rdoTwoTimes_100.CheckedChanged += new System.EventHandler(this.rdoOneTime_CheckedChanged);
            // 
            // rdoOneTime_50
            // 
            this.rdoOneTime_50.AutoSize = true;
            this.rdoOneTime_50.Location = new System.Drawing.Point(7, 21);
            this.rdoOneTime_50.Name = "rdoOneTime_50";
            this.rdoOneTime_50.Size = new System.Drawing.Size(41, 16);
            this.rdoOneTime_50.TabIndex = 0;
            this.rdoOneTime_50.TabStop = true;
            this.rdoOneTime_50.Tag = "-50";
            this.rdoOneTime_50.Text = "1次";
            this.rdoOneTime_50.UseVisualStyleBackColor = true;
            this.rdoOneTime_50.CheckedChanged += new System.EventHandler(this.rdoOneTime_CheckedChanged);
            // 
            // gpbLateIn20_20
            // 
            this.gpbLateIn20_20.Controls.Add(this.rdoThreeTimes_60);
            this.gpbLateIn20_20.Controls.Add(this.rdoTwice_40);
            this.gpbLateIn20_20.Controls.Add(this.rdoOnce_20);
            this.gpbLateIn20_20.Location = new System.Drawing.Point(9, 24);
            this.gpbLateIn20_20.Name = "gpbLateIn20_20";
            this.gpbLateIn20_20.Size = new System.Drawing.Size(190, 49);
            this.gpbLateIn20_20.TabIndex = 15;
            this.gpbLateIn20_20.TabStop = false;
            this.gpbLateIn20_20.Text = "迟到20分钟以内";
            // 
            // rdoThreeTimes_60
            // 
            this.rdoThreeTimes_60.AutoSize = true;
            this.rdoThreeTimes_60.Location = new System.Drawing.Point(143, 21);
            this.rdoThreeTimes_60.Name = "rdoThreeTimes_60";
            this.rdoThreeTimes_60.Size = new System.Drawing.Size(41, 16);
            this.rdoThreeTimes_60.TabIndex = 2;
            this.rdoThreeTimes_60.TabStop = true;
            this.rdoThreeTimes_60.Tag = "-60";
            this.rdoThreeTimes_60.Text = "3次";
            this.rdoThreeTimes_60.UseVisualStyleBackColor = true;
            this.rdoThreeTimes_60.CheckedChanged += new System.EventHandler(this.rdoOnce_CheckedChanged);
            // 
            // rdoTwice_40
            // 
            this.rdoTwice_40.AutoSize = true;
            this.rdoTwice_40.Location = new System.Drawing.Point(76, 20);
            this.rdoTwice_40.Name = "rdoTwice_40";
            this.rdoTwice_40.Size = new System.Drawing.Size(41, 16);
            this.rdoTwice_40.TabIndex = 1;
            this.rdoTwice_40.TabStop = true;
            this.rdoTwice_40.Tag = "-40";
            this.rdoTwice_40.Text = "2次";
            this.rdoTwice_40.UseVisualStyleBackColor = true;
            this.rdoTwice_40.CheckedChanged += new System.EventHandler(this.rdoOnce_CheckedChanged);
            // 
            // rdoOnce_20
            // 
            this.rdoOnce_20.AutoSize = true;
            this.rdoOnce_20.Location = new System.Drawing.Point(7, 21);
            this.rdoOnce_20.Name = "rdoOnce_20";
            this.rdoOnce_20.Size = new System.Drawing.Size(41, 16);
            this.rdoOnce_20.TabIndex = 0;
            this.rdoOnce_20.TabStop = true;
            this.rdoOnce_20.Tag = "-20";
            this.rdoOnce_20.Text = "1次";
            this.rdoOnce_20.UseVisualStyleBackColor = true;
            this.rdoOnce_20.CheckedChanged += new System.EventHandler(this.rdoOnce_CheckedChanged);
            // 
            // lstbAllwance
            // 
            this.lstbAllwance.FormattingEnabled = true;
            this.lstbAllwance.ItemHeight = 12;
            this.lstbAllwance.Location = new System.Drawing.Point(12, 216);
            this.lstbAllwance.Name = "lstbAllwance";
            this.lstbAllwance.Size = new System.Drawing.Size(131, 64);
            this.lstbAllwance.TabIndex = 6;
            // 
            // lstbBenifit
            // 
            this.lstbBenifit.FormattingEnabled = true;
            this.lstbBenifit.ItemHeight = 12;
            this.lstbBenifit.Location = new System.Drawing.Point(149, 216);
            this.lstbBenifit.Name = "lstbBenifit";
            this.lstbBenifit.Size = new System.Drawing.Size(121, 64);
            this.lstbBenifit.TabIndex = 7;
            // 
            // lstbAwd
            // 
            this.lstbAwd.FormattingEnabled = true;
            this.lstbAwd.ItemHeight = 12;
            this.lstbAwd.Location = new System.Drawing.Point(276, 216);
            this.lstbAwd.Name = "lstbAwd";
            this.lstbAwd.Size = new System.Drawing.Size(91, 64);
            this.lstbAwd.TabIndex = 8;
            // 
            // lstbPun
            // 
            this.lstbPun.FormattingEnabled = true;
            this.lstbPun.ItemHeight = 12;
            this.lstbPun.Location = new System.Drawing.Point(424, 216);
            this.lstbPun.Name = "lstbPun";
            this.lstbPun.Size = new System.Drawing.Size(155, 64);
            this.lstbPun.TabIndex = 9;
            // 
            // txtAllwanceSum
            // 
            this.txtAllwanceSum.Location = new System.Drawing.Point(28, 286);
            this.txtAllwanceSum.Name = "txtAllwanceSum";
            this.txtAllwanceSum.ReadOnly = true;
            this.txtAllwanceSum.Size = new System.Drawing.Size(100, 21);
            this.txtAllwanceSum.TabIndex = 10;
            this.txtAllwanceSum.TextChanged += new System.EventHandler(this.txtAllwanceSum_TextChanged);
            // 
            // txtBenifitSum
            // 
            this.txtBenifitSum.Location = new System.Drawing.Point(161, 286);
            this.txtBenifitSum.Name = "txtBenifitSum";
            this.txtBenifitSum.ReadOnly = true;
            this.txtBenifitSum.Size = new System.Drawing.Size(100, 21);
            this.txtBenifitSum.TabIndex = 11;
            this.txtBenifitSum.TextChanged += new System.EventHandler(this.txtAllwanceSum_TextChanged);
            // 
            // txtAwdSum
            // 
            this.txtAwdSum.Location = new System.Drawing.Point(297, 286);
            this.txtAwdSum.Name = "txtAwdSum";
            this.txtAwdSum.ReadOnly = true;
            this.txtAwdSum.Size = new System.Drawing.Size(100, 21);
            this.txtAwdSum.TabIndex = 12;
            this.txtAwdSum.TextChanged += new System.EventHandler(this.txtAllwanceSum_TextChanged);
            // 
            // txtPunSum
            // 
            this.txtPunSum.Location = new System.Drawing.Point(470, 286);
            this.txtPunSum.Name = "txtPunSum";
            this.txtPunSum.ReadOnly = true;
            this.txtPunSum.Size = new System.Drawing.Size(100, 21);
            this.txtPunSum.TabIndex = 13;
            this.txtPunSum.Validated += new System.EventHandler(this.txtAllwanceSum_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(211, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Tag = "0";
            this.btnBrowse.Text = "查看员工表";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(193, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "工资总额：";
            // 
            // txtAllSum
            // 
            this.txtAllSum.Location = new System.Drawing.Point(281, 342);
            this.txtAllSum.Name = "txtAllSum";
            this.txtAllSum.ReadOnly = true;
            this.txtAllSum.Size = new System.Drawing.Size(128, 21);
            this.txtAllSum.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sslblOperatorNo,
            this.sslblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(641, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "操作员：";
            // 
            // sslblOperatorNo
            // 
            this.sslblOperatorNo.Name = "sslblOperatorNo";
            this.sslblOperatorNo.Size = new System.Drawing.Size(131, 17);
            this.sslblOperatorNo.Text = "toolStripStatusLabel2";
            // 
            // sslblTime
            // 
            this.sslblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sslblTime.Name = "sslblTime";
            this.sslblTime.Size = new System.Drawing.Size(131, 17);
            this.sslblTime.Text = "toolStripStatusLabel2";
            this.sslblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowseAttendence
            // 
            this.btnBrowseAttendence.Location = new System.Drawing.Point(585, 216);
            this.btnBrowseAttendence.Name = "btnBrowseAttendence";
            this.btnBrowseAttendence.Size = new System.Drawing.Size(44, 64);
            this.btnBrowseAttendence.TabIndex = 18;
            this.btnBrowseAttendence.Tag = "1";
            this.btnBrowseAttendence.Text = "查看出勤明细";
            this.btnBrowseAttendence.UseVisualStyleBackColor = true;
            this.btnBrowseAttendence.Click += new System.EventHandler(this.btnBrowseAttendence_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSubmitt
            // 
            this.btnSubmitt.Location = new System.Drawing.Point(195, 375);
            this.btnSubmitt.Name = "btnSubmitt";
            this.btnSubmitt.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitt.TabIndex = 19;
            this.btnSubmitt.Tag = "1";
            this.btnSubmitt.Text = "提 交";
            this.btnSubmitt.UseVisualStyleBackColor = true;
            this.btnSubmitt.Click += new System.EventHandler(this.btnSubmitt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSumUp
            // 
            this.btnSumUp.Location = new System.Drawing.Point(276, 313);
            this.btnSumUp.Name = "btnSumUp";
            this.btnSumUp.Size = new System.Drawing.Size(75, 23);
            this.btnSumUp.TabIndex = 21;
            this.btnSumUp.Tag = "1";
            this.btnSumUp.Text = "总 计";
            this.btnSumUp.UseVisualStyleBackColor = true;
            this.btnSumUp.Click += new System.EventHandler(this.btnSumUp_Click);
            // 
            // btnBrowseAwd
            // 
            this.btnBrowseAwd.Location = new System.Drawing.Point(373, 216);
            this.btnBrowseAwd.Name = "btnBrowseAwd";
            this.btnBrowseAwd.Size = new System.Drawing.Size(44, 64);
            this.btnBrowseAwd.TabIndex = 22;
            this.btnBrowseAwd.Tag = "1";
            this.btnBrowseAwd.Text = "查看奖惩明细";
            this.btnBrowseAwd.UseVisualStyleBackColor = true;
            this.btnBrowseAwd.Click += new System.EventHandler(this.btnBrowseAwd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Tag = "0";
            this.button1.Text = "开始创建";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.txtNo_Leave);
            // 
            // FrmAddSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBrowseAwd);
            this.Controls.Add(this.btnSumUp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitt);
            this.Controls.Add(this.btnBrowseAttendence);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtAllSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPunSum);
            this.Controls.Add(this.txtAwdSum);
            this.Controls.Add(this.txtBenifitSum);
            this.Controls.Add(this.txtAllwanceSum);
            this.Controls.Add(this.lstbPun);
            this.Controls.Add(this.lstbAwd);
            this.Controls.Add(this.lstbBenifit);
            this.Controls.Add(this.lstbAllwance);
            this.Controls.Add(this.gpbPun);
            this.Controls.Add(this.gpbAwd);
            this.Controls.Add(this.gpbBenifit);
            this.Controls.Add(this.gpbAwllance);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建工资单";
            this.Load += new System.EventHandler(this.FrmAddSalary_Load);
            this.gpbAwllance.ResumeLayout(false);
            this.gpbAwllance.PerformLayout();
            this.gpbBenifit.ResumeLayout(false);
            this.gpbBenifit.PerformLayout();
            this.gpbAwd.ResumeLayout(false);
            this.gpbAwd.PerformLayout();
            this.gpbPun.ResumeLayout(false);
            this.gpbLateOut20_50.ResumeLayout(false);
            this.gpbLateOut20_50.PerformLayout();
            this.gpbLateIn20_20.ResumeLayout(false);
            this.gpbLateIn20_20.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.GroupBox gpbAwllance;
        private System.Windows.Forms.CheckBox cbAwllWH_200;
        private System.Windows.Forms.CheckBox cbAwllJT_150;
        private System.Windows.Forms.CheckBox cbAwllSZ_3000;
        private System.Windows.Forms.CheckBox cbAwllDBYW_3000;
        private System.Windows.Forms.CheckBox cbAwllCL_500;
        private System.Windows.Forms.GroupBox gpbBenifit;
        private System.Windows.Forms.CheckBox cbBenifitTSJS_800;
        private System.Windows.Forms.CheckBox cbBenifitYB_400;
        private System.Windows.Forms.CheckBox cbBenifitGW_400;
        private System.Windows.Forms.GroupBox gpbAwd;
        private System.Windows.Forms.CheckBox cbAwdContribute_300;
        private System.Windows.Forms.CheckBox cbAwdCreative_500;
        private System.Windows.Forms.GroupBox gpbPun;
        private System.Windows.Forms.GroupBox gpbLateOut20_50;
        private System.Windows.Forms.RadioButton rdoThreeTimesDead_150;
        private System.Windows.Forms.RadioButton rdoTwoTimes_100;
        private System.Windows.Forms.RadioButton rdoOneTime_50;
        private System.Windows.Forms.GroupBox gpbLateIn20_20;
        private System.Windows.Forms.RadioButton rdoThreeTimes_60;
        private System.Windows.Forms.RadioButton rdoTwice_40;
        private System.Windows.Forms.RadioButton rdoOnce_20;
        private System.Windows.Forms.CheckBox cbPunNoAskAbsence_90;
        private System.Windows.Forms.ListBox lstbAllwance;
        private System.Windows.Forms.ListBox lstbBenifit;
        private System.Windows.Forms.ListBox lstbAwd;
        private System.Windows.Forms.ListBox lstbPun;
        private System.Windows.Forms.TextBox txtAllwanceSum;
        private System.Windows.Forms.TextBox txtBenifitSum;
        private System.Windows.Forms.TextBox txtAwdSum;
        private System.Windows.Forms.TextBox txtPunSum;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAllSum;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sslblOperatorNo;
        private System.Windows.Forms.Button btnBrowseAttendence;
        private System.Windows.Forms.ToolStripStatusLabel sslblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSubmitt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSumUp;
        private System.Windows.Forms.Button btnBrowseAwd;
        private System.Windows.Forms.Button button1;
    }
}