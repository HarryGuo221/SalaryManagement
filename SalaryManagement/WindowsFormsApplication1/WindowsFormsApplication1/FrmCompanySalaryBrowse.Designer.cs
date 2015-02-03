namespace WindowsFormsApplication1
{
    partial class FrmCompanySalaryBrowse
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gpbRS_Department = new System.Windows.Forms.GroupBox();
            this.dgvRS_Salary = new System.Windows.Forms.DataGridView();
            this.txtRS_AllSum = new System.Windows.Forms.TextBox();
            this.lblRS_AllSum = new System.Windows.Forms.Label();
            this.txtRS_Awd_Pun = new System.Windows.Forms.TextBox();
            this.lblRS_Awd_Pun = new System.Windows.Forms.Label();
            this.txtRS_Allwance = new System.Windows.Forms.TextBox();
            this.lblRS_Allwance = new System.Windows.Forms.Label();
            this.txtRS_Benifit = new System.Windows.Forms.TextBox();
            this.lblRS_Benifit = new System.Windows.Forms.Label();
            this.txtRS_OverWork = new System.Windows.Forms.TextBox();
            this.lblRS_OverWork = new System.Windows.Forms.Label();
            this.txtRS_BasicSal = new System.Windows.Forms.TextBox();
            this.lblRS_BasicSal = new System.Windows.Forms.Label();
            this.gpbSC_Department = new System.Windows.Forms.GroupBox();
            this.dgvSC_Salary = new System.Windows.Forms.DataGridView();
            this.txtSC_AllSum = new System.Windows.Forms.TextBox();
            this.lblSC_AllSum = new System.Windows.Forms.Label();
            this.txtSC_Awd_Pun = new System.Windows.Forms.TextBox();
            this.lblSC_Awd_Pun = new System.Windows.Forms.Label();
            this.txtSC_Allwance = new System.Windows.Forms.TextBox();
            this.lblSC_Allwance = new System.Windows.Forms.Label();
            this.txtSC_Benifit = new System.Windows.Forms.TextBox();
            this.lblSC_Benifit = new System.Windows.Forms.Label();
            this.txtSC_OverWork = new System.Windows.Forms.TextBox();
            this.lblSC_OverWork = new System.Windows.Forms.Label();
            this.txtSC_BasicSal = new System.Windows.Forms.TextBox();
            this.lblSC_BasicSal = new System.Windows.Forms.Label();
            this.gpbCW_Department = new System.Windows.Forms.GroupBox();
            this.dgvCW_Salary = new System.Windows.Forms.DataGridView();
            this.txtCW_AllSum = new System.Windows.Forms.TextBox();
            this.lblCW_AllSum = new System.Windows.Forms.Label();
            this.txtCW_Awd_Pun = new System.Windows.Forms.TextBox();
            this.lblCW_Awd_Pun = new System.Windows.Forms.Label();
            this.txtCW_Allwance = new System.Windows.Forms.TextBox();
            this.lblCW_Allwance = new System.Windows.Forms.Label();
            this.txtCW_Benifit = new System.Windows.Forms.TextBox();
            this.lblCW_Benifit = new System.Windows.Forms.Label();
            this.txtCW_OverWork = new System.Windows.Forms.TextBox();
            this.lblCW_OverWork = new System.Windows.Forms.Label();
            this.txtCW_BasicSal = new System.Windows.Forms.TextBox();
            this.lblCW_BasicSal = new System.Windows.Forms.Label();
            this.gpbAllSum = new System.Windows.Forms.GroupBox();
            this.txtAll_Allsum = new System.Windows.Forms.TextBox();
            this.lblAll_Allsum = new System.Windows.Forms.Label();
            this.txtAll_Awd_Pun = new System.Windows.Forms.TextBox();
            this.lblAll_Awd_Pun = new System.Windows.Forms.Label();
            this.txtAll_Allwance = new System.Windows.Forms.TextBox();
            this.lblAll_Allwance = new System.Windows.Forms.Label();
            this.txtAll_Benifit = new System.Windows.Forms.TextBox();
            this.lblAll_Benifit = new System.Windows.Forms.Label();
            this.txtAll_OverWork = new System.Windows.Forms.TextBox();
            this.lblAll_OverWork = new System.Windows.Forms.Label();
            this.txtAll_BasicSum = new System.Windows.Forms.TextBox();
            this.lblAll_BasicSum = new System.Windows.Forms.Label();
            this.gpbRS_Department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRS_Salary)).BeginInit();
            this.gpbSC_Department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSC_Salary)).BeginInit();
            this.gpbCW_Department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCW_Salary)).BeginInit();
            this.gpbAllSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2011",
            "2012",
            "2013"});
            this.cmbYear.Location = new System.Drawing.Point(71, 27);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 20);
            this.cmbYear.TabIndex = 1;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(242, 27);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 20);
            this.cmbMonth.TabIndex = 3;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(369, 30);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "月";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(486, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "查 看";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gpbRS_Department
            // 
            this.gpbRS_Department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbRS_Department.Controls.Add(this.dgvRS_Salary);
            this.gpbRS_Department.Controls.Add(this.txtRS_AllSum);
            this.gpbRS_Department.Controls.Add(this.lblRS_AllSum);
            this.gpbRS_Department.Controls.Add(this.txtRS_Awd_Pun);
            this.gpbRS_Department.Controls.Add(this.lblRS_Awd_Pun);
            this.gpbRS_Department.Controls.Add(this.txtRS_Allwance);
            this.gpbRS_Department.Controls.Add(this.lblRS_Allwance);
            this.gpbRS_Department.Controls.Add(this.txtRS_Benifit);
            this.gpbRS_Department.Controls.Add(this.lblRS_Benifit);
            this.gpbRS_Department.Controls.Add(this.txtRS_OverWork);
            this.gpbRS_Department.Controls.Add(this.lblRS_OverWork);
            this.gpbRS_Department.Controls.Add(this.txtRS_BasicSal);
            this.gpbRS_Department.Controls.Add(this.lblRS_BasicSal);
            this.gpbRS_Department.Location = new System.Drawing.Point(12, 128);
            this.gpbRS_Department.Name = "gpbRS_Department";
            this.gpbRS_Department.Size = new System.Drawing.Size(817, 180);
            this.gpbRS_Department.TabIndex = 5;
            this.gpbRS_Department.TabStop = false;
            this.gpbRS_Department.Tag = "1";
            this.gpbRS_Department.Text = "人事部";
            // 
            // dgvRS_Salary
            // 
            this.dgvRS_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRS_Salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRS_Salary.Location = new System.Drawing.Point(6, 41);
            this.dgvRS_Salary.Name = "dgvRS_Salary";
            this.dgvRS_Salary.RowTemplate.Height = 23;
            this.dgvRS_Salary.Size = new System.Drawing.Size(805, 133);
            this.dgvRS_Salary.TabIndex = 45;
            // 
            // txtRS_AllSum
            // 
            this.txtRS_AllSum.Location = new System.Drawing.Point(720, 14);
            this.txtRS_AllSum.Name = "txtRS_AllSum";
            this.txtRS_AllSum.ReadOnly = true;
            this.txtRS_AllSum.Size = new System.Drawing.Size(80, 21);
            this.txtRS_AllSum.TabIndex = 44;
            // 
            // lblRS_AllSum
            // 
            this.lblRS_AllSum.AutoSize = true;
            this.lblRS_AllSum.Location = new System.Drawing.Point(670, 17);
            this.lblRS_AllSum.Name = "lblRS_AllSum";
            this.lblRS_AllSum.Size = new System.Drawing.Size(53, 12);
            this.lblRS_AllSum.TabIndex = 43;
            this.lblRS_AllSum.Text = "总工资：";
            // 
            // txtRS_Awd_Pun
            // 
            this.txtRS_Awd_Pun.Location = new System.Drawing.Point(583, 14);
            this.txtRS_Awd_Pun.Name = "txtRS_Awd_Pun";
            this.txtRS_Awd_Pun.ReadOnly = true;
            this.txtRS_Awd_Pun.Size = new System.Drawing.Size(75, 21);
            this.txtRS_Awd_Pun.TabIndex = 42;
            // 
            // lblRS_Awd_Pun
            // 
            this.lblRS_Awd_Pun.AutoSize = true;
            this.lblRS_Awd_Pun.Location = new System.Drawing.Point(546, 17);
            this.lblRS_Awd_Pun.Name = "lblRS_Awd_Pun";
            this.lblRS_Awd_Pun.Size = new System.Drawing.Size(41, 12);
            this.lblRS_Awd_Pun.TabIndex = 41;
            this.lblRS_Awd_Pun.Text = "奖惩：";
            // 
            // txtRS_Allwance
            // 
            this.txtRS_Allwance.Location = new System.Drawing.Point(457, 14);
            this.txtRS_Allwance.Name = "txtRS_Allwance";
            this.txtRS_Allwance.ReadOnly = true;
            this.txtRS_Allwance.Size = new System.Drawing.Size(75, 21);
            this.txtRS_Allwance.TabIndex = 40;
            // 
            // lblRS_Allwance
            // 
            this.lblRS_Allwance.AutoSize = true;
            this.lblRS_Allwance.Location = new System.Drawing.Point(419, 17);
            this.lblRS_Allwance.Name = "lblRS_Allwance";
            this.lblRS_Allwance.Size = new System.Drawing.Size(41, 12);
            this.lblRS_Allwance.TabIndex = 39;
            this.lblRS_Allwance.Text = "津贴：";
            // 
            // txtRS_Benifit
            // 
            this.txtRS_Benifit.Location = new System.Drawing.Point(337, 14);
            this.txtRS_Benifit.Name = "txtRS_Benifit";
            this.txtRS_Benifit.ReadOnly = true;
            this.txtRS_Benifit.Size = new System.Drawing.Size(75, 21);
            this.txtRS_Benifit.TabIndex = 38;
            // 
            // lblRS_Benifit
            // 
            this.lblRS_Benifit.AutoSize = true;
            this.lblRS_Benifit.Location = new System.Drawing.Point(299, 17);
            this.lblRS_Benifit.Name = "lblRS_Benifit";
            this.lblRS_Benifit.Size = new System.Drawing.Size(41, 12);
            this.lblRS_Benifit.TabIndex = 37;
            this.lblRS_Benifit.Text = "补贴：";
            // 
            // txtRS_OverWork
            // 
            this.txtRS_OverWork.Location = new System.Drawing.Point(216, 14);
            this.txtRS_OverWork.Name = "txtRS_OverWork";
            this.txtRS_OverWork.ReadOnly = true;
            this.txtRS_OverWork.Size = new System.Drawing.Size(75, 21);
            this.txtRS_OverWork.TabIndex = 36;
            // 
            // lblRS_OverWork
            // 
            this.lblRS_OverWork.AutoSize = true;
            this.lblRS_OverWork.Location = new System.Drawing.Point(158, 17);
            this.lblRS_OverWork.Name = "lblRS_OverWork";
            this.lblRS_OverWork.Size = new System.Drawing.Size(65, 12);
            this.lblRS_OverWork.TabIndex = 35;
            this.lblRS_OverWork.Text = "加班工资：";
            // 
            // txtRS_BasicSal
            // 
            this.txtRS_BasicSal.Location = new System.Drawing.Point(78, 14);
            this.txtRS_BasicSal.Name = "txtRS_BasicSal";
            this.txtRS_BasicSal.ReadOnly = true;
            this.txtRS_BasicSal.Size = new System.Drawing.Size(75, 21);
            this.txtRS_BasicSal.TabIndex = 34;
            // 
            // lblRS_BasicSal
            // 
            this.lblRS_BasicSal.AutoSize = true;
            this.lblRS_BasicSal.Location = new System.Drawing.Point(17, 17);
            this.lblRS_BasicSal.Name = "lblRS_BasicSal";
            this.lblRS_BasicSal.Size = new System.Drawing.Size(65, 12);
            this.lblRS_BasicSal.TabIndex = 33;
            this.lblRS_BasicSal.Text = "基本工资：";
            // 
            // gpbSC_Department
            // 
            this.gpbSC_Department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbSC_Department.Controls.Add(this.dgvSC_Salary);
            this.gpbSC_Department.Controls.Add(this.txtSC_AllSum);
            this.gpbSC_Department.Controls.Add(this.lblSC_AllSum);
            this.gpbSC_Department.Controls.Add(this.txtSC_Awd_Pun);
            this.gpbSC_Department.Controls.Add(this.lblSC_Awd_Pun);
            this.gpbSC_Department.Controls.Add(this.txtSC_Allwance);
            this.gpbSC_Department.Controls.Add(this.lblSC_Allwance);
            this.gpbSC_Department.Controls.Add(this.txtSC_Benifit);
            this.gpbSC_Department.Controls.Add(this.lblSC_Benifit);
            this.gpbSC_Department.Controls.Add(this.txtSC_OverWork);
            this.gpbSC_Department.Controls.Add(this.lblSC_OverWork);
            this.gpbSC_Department.Controls.Add(this.txtSC_BasicSal);
            this.gpbSC_Department.Controls.Add(this.lblSC_BasicSal);
            this.gpbSC_Department.Location = new System.Drawing.Point(12, 314);
            this.gpbSC_Department.Name = "gpbSC_Department";
            this.gpbSC_Department.Size = new System.Drawing.Size(817, 180);
            this.gpbSC_Department.TabIndex = 6;
            this.gpbSC_Department.TabStop = false;
            this.gpbSC_Department.Tag = "2";
            this.gpbSC_Department.Text = "市场部";
            // 
            // dgvSC_Salary
            // 
            this.dgvSC_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSC_Salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSC_Salary.Location = new System.Drawing.Point(6, 41);
            this.dgvSC_Salary.Name = "dgvSC_Salary";
            this.dgvSC_Salary.RowTemplate.Height = 23;
            this.dgvSC_Salary.Size = new System.Drawing.Size(805, 133);
            this.dgvSC_Salary.TabIndex = 57;
            // 
            // txtSC_AllSum
            // 
            this.txtSC_AllSum.Location = new System.Drawing.Point(720, 14);
            this.txtSC_AllSum.Name = "txtSC_AllSum";
            this.txtSC_AllSum.ReadOnly = true;
            this.txtSC_AllSum.Size = new System.Drawing.Size(80, 21);
            this.txtSC_AllSum.TabIndex = 56;
            // 
            // lblSC_AllSum
            // 
            this.lblSC_AllSum.AutoSize = true;
            this.lblSC_AllSum.Location = new System.Drawing.Point(670, 17);
            this.lblSC_AllSum.Name = "lblSC_AllSum";
            this.lblSC_AllSum.Size = new System.Drawing.Size(53, 12);
            this.lblSC_AllSum.TabIndex = 55;
            this.lblSC_AllSum.Text = "总工资：";
            // 
            // txtSC_Awd_Pun
            // 
            this.txtSC_Awd_Pun.Location = new System.Drawing.Point(583, 14);
            this.txtSC_Awd_Pun.Name = "txtSC_Awd_Pun";
            this.txtSC_Awd_Pun.ReadOnly = true;
            this.txtSC_Awd_Pun.Size = new System.Drawing.Size(75, 21);
            this.txtSC_Awd_Pun.TabIndex = 54;
            // 
            // lblSC_Awd_Pun
            // 
            this.lblSC_Awd_Pun.AutoSize = true;
            this.lblSC_Awd_Pun.Location = new System.Drawing.Point(546, 17);
            this.lblSC_Awd_Pun.Name = "lblSC_Awd_Pun";
            this.lblSC_Awd_Pun.Size = new System.Drawing.Size(41, 12);
            this.lblSC_Awd_Pun.TabIndex = 53;
            this.lblSC_Awd_Pun.Text = "奖惩：";
            // 
            // txtSC_Allwance
            // 
            this.txtSC_Allwance.Location = new System.Drawing.Point(457, 14);
            this.txtSC_Allwance.Name = "txtSC_Allwance";
            this.txtSC_Allwance.ReadOnly = true;
            this.txtSC_Allwance.Size = new System.Drawing.Size(75, 21);
            this.txtSC_Allwance.TabIndex = 52;
            // 
            // lblSC_Allwance
            // 
            this.lblSC_Allwance.AutoSize = true;
            this.lblSC_Allwance.Location = new System.Drawing.Point(419, 17);
            this.lblSC_Allwance.Name = "lblSC_Allwance";
            this.lblSC_Allwance.Size = new System.Drawing.Size(41, 12);
            this.lblSC_Allwance.TabIndex = 51;
            this.lblSC_Allwance.Text = "津贴：";
            // 
            // txtSC_Benifit
            // 
            this.txtSC_Benifit.Location = new System.Drawing.Point(337, 14);
            this.txtSC_Benifit.Name = "txtSC_Benifit";
            this.txtSC_Benifit.ReadOnly = true;
            this.txtSC_Benifit.Size = new System.Drawing.Size(75, 21);
            this.txtSC_Benifit.TabIndex = 50;
            // 
            // lblSC_Benifit
            // 
            this.lblSC_Benifit.AutoSize = true;
            this.lblSC_Benifit.Location = new System.Drawing.Point(299, 17);
            this.lblSC_Benifit.Name = "lblSC_Benifit";
            this.lblSC_Benifit.Size = new System.Drawing.Size(41, 12);
            this.lblSC_Benifit.TabIndex = 49;
            this.lblSC_Benifit.Text = "补贴：";
            // 
            // txtSC_OverWork
            // 
            this.txtSC_OverWork.Location = new System.Drawing.Point(216, 14);
            this.txtSC_OverWork.Name = "txtSC_OverWork";
            this.txtSC_OverWork.ReadOnly = true;
            this.txtSC_OverWork.Size = new System.Drawing.Size(75, 21);
            this.txtSC_OverWork.TabIndex = 48;
            // 
            // lblSC_OverWork
            // 
            this.lblSC_OverWork.AutoSize = true;
            this.lblSC_OverWork.Location = new System.Drawing.Point(158, 17);
            this.lblSC_OverWork.Name = "lblSC_OverWork";
            this.lblSC_OverWork.Size = new System.Drawing.Size(65, 12);
            this.lblSC_OverWork.TabIndex = 47;
            this.lblSC_OverWork.Text = "加班工资：";
            // 
            // txtSC_BasicSal
            // 
            this.txtSC_BasicSal.Location = new System.Drawing.Point(78, 14);
            this.txtSC_BasicSal.Name = "txtSC_BasicSal";
            this.txtSC_BasicSal.ReadOnly = true;
            this.txtSC_BasicSal.Size = new System.Drawing.Size(75, 21);
            this.txtSC_BasicSal.TabIndex = 46;
            // 
            // lblSC_BasicSal
            // 
            this.lblSC_BasicSal.AutoSize = true;
            this.lblSC_BasicSal.Location = new System.Drawing.Point(17, 17);
            this.lblSC_BasicSal.Name = "lblSC_BasicSal";
            this.lblSC_BasicSal.Size = new System.Drawing.Size(65, 12);
            this.lblSC_BasicSal.TabIndex = 45;
            this.lblSC_BasicSal.Text = "基本工资：";
            // 
            // gpbCW_Department
            // 
            this.gpbCW_Department.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCW_Department.Controls.Add(this.dgvCW_Salary);
            this.gpbCW_Department.Controls.Add(this.txtCW_AllSum);
            this.gpbCW_Department.Controls.Add(this.lblCW_AllSum);
            this.gpbCW_Department.Controls.Add(this.txtCW_Awd_Pun);
            this.gpbCW_Department.Controls.Add(this.lblCW_Awd_Pun);
            this.gpbCW_Department.Controls.Add(this.txtCW_Allwance);
            this.gpbCW_Department.Controls.Add(this.lblCW_Allwance);
            this.gpbCW_Department.Controls.Add(this.txtCW_Benifit);
            this.gpbCW_Department.Controls.Add(this.lblCW_Benifit);
            this.gpbCW_Department.Controls.Add(this.txtCW_OverWork);
            this.gpbCW_Department.Controls.Add(this.lblCW_OverWork);
            this.gpbCW_Department.Controls.Add(this.txtCW_BasicSal);
            this.gpbCW_Department.Controls.Add(this.lblCW_BasicSal);
            this.gpbCW_Department.Location = new System.Drawing.Point(12, 500);
            this.gpbCW_Department.Name = "gpbCW_Department";
            this.gpbCW_Department.Size = new System.Drawing.Size(817, 180);
            this.gpbCW_Department.TabIndex = 7;
            this.gpbCW_Department.TabStop = false;
            this.gpbCW_Department.Tag = "3";
            this.gpbCW_Department.Text = "财务部";
            // 
            // dgvCW_Salary
            // 
            this.dgvCW_Salary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCW_Salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCW_Salary.Location = new System.Drawing.Point(6, 41);
            this.dgvCW_Salary.Name = "dgvCW_Salary";
            this.dgvCW_Salary.RowTemplate.Height = 23;
            this.dgvCW_Salary.Size = new System.Drawing.Size(805, 133);
            this.dgvCW_Salary.TabIndex = 57;
            // 
            // txtCW_AllSum
            // 
            this.txtCW_AllSum.Location = new System.Drawing.Point(720, 14);
            this.txtCW_AllSum.Name = "txtCW_AllSum";
            this.txtCW_AllSum.ReadOnly = true;
            this.txtCW_AllSum.Size = new System.Drawing.Size(80, 21);
            this.txtCW_AllSum.TabIndex = 56;
            // 
            // lblCW_AllSum
            // 
            this.lblCW_AllSum.AutoSize = true;
            this.lblCW_AllSum.Location = new System.Drawing.Point(670, 17);
            this.lblCW_AllSum.Name = "lblCW_AllSum";
            this.lblCW_AllSum.Size = new System.Drawing.Size(53, 12);
            this.lblCW_AllSum.TabIndex = 55;
            this.lblCW_AllSum.Text = "总工资：";
            // 
            // txtCW_Awd_Pun
            // 
            this.txtCW_Awd_Pun.Location = new System.Drawing.Point(583, 14);
            this.txtCW_Awd_Pun.Name = "txtCW_Awd_Pun";
            this.txtCW_Awd_Pun.ReadOnly = true;
            this.txtCW_Awd_Pun.Size = new System.Drawing.Size(75, 21);
            this.txtCW_Awd_Pun.TabIndex = 54;
            // 
            // lblCW_Awd_Pun
            // 
            this.lblCW_Awd_Pun.AutoSize = true;
            this.lblCW_Awd_Pun.Location = new System.Drawing.Point(546, 17);
            this.lblCW_Awd_Pun.Name = "lblCW_Awd_Pun";
            this.lblCW_Awd_Pun.Size = new System.Drawing.Size(41, 12);
            this.lblCW_Awd_Pun.TabIndex = 53;
            this.lblCW_Awd_Pun.Text = "奖惩：";
            // 
            // txtCW_Allwance
            // 
            this.txtCW_Allwance.Location = new System.Drawing.Point(457, 14);
            this.txtCW_Allwance.Name = "txtCW_Allwance";
            this.txtCW_Allwance.ReadOnly = true;
            this.txtCW_Allwance.Size = new System.Drawing.Size(75, 21);
            this.txtCW_Allwance.TabIndex = 52;
            // 
            // lblCW_Allwance
            // 
            this.lblCW_Allwance.AutoSize = true;
            this.lblCW_Allwance.Location = new System.Drawing.Point(419, 17);
            this.lblCW_Allwance.Name = "lblCW_Allwance";
            this.lblCW_Allwance.Size = new System.Drawing.Size(41, 12);
            this.lblCW_Allwance.TabIndex = 51;
            this.lblCW_Allwance.Text = "津贴：";
            // 
            // txtCW_Benifit
            // 
            this.txtCW_Benifit.Location = new System.Drawing.Point(337, 14);
            this.txtCW_Benifit.Name = "txtCW_Benifit";
            this.txtCW_Benifit.ReadOnly = true;
            this.txtCW_Benifit.Size = new System.Drawing.Size(75, 21);
            this.txtCW_Benifit.TabIndex = 50;
            // 
            // lblCW_Benifit
            // 
            this.lblCW_Benifit.AutoSize = true;
            this.lblCW_Benifit.Location = new System.Drawing.Point(299, 17);
            this.lblCW_Benifit.Name = "lblCW_Benifit";
            this.lblCW_Benifit.Size = new System.Drawing.Size(41, 12);
            this.lblCW_Benifit.TabIndex = 49;
            this.lblCW_Benifit.Text = "补贴：";
            // 
            // txtCW_OverWork
            // 
            this.txtCW_OverWork.Location = new System.Drawing.Point(216, 14);
            this.txtCW_OverWork.Name = "txtCW_OverWork";
            this.txtCW_OverWork.ReadOnly = true;
            this.txtCW_OverWork.Size = new System.Drawing.Size(75, 21);
            this.txtCW_OverWork.TabIndex = 48;
            // 
            // lblCW_OverWork
            // 
            this.lblCW_OverWork.AutoSize = true;
            this.lblCW_OverWork.Location = new System.Drawing.Point(158, 17);
            this.lblCW_OverWork.Name = "lblCW_OverWork";
            this.lblCW_OverWork.Size = new System.Drawing.Size(65, 12);
            this.lblCW_OverWork.TabIndex = 47;
            this.lblCW_OverWork.Text = "加班工资：";
            // 
            // txtCW_BasicSal
            // 
            this.txtCW_BasicSal.Location = new System.Drawing.Point(78, 14);
            this.txtCW_BasicSal.Name = "txtCW_BasicSal";
            this.txtCW_BasicSal.ReadOnly = true;
            this.txtCW_BasicSal.Size = new System.Drawing.Size(75, 21);
            this.txtCW_BasicSal.TabIndex = 46;
            // 
            // lblCW_BasicSal
            // 
            this.lblCW_BasicSal.AutoSize = true;
            this.lblCW_BasicSal.Location = new System.Drawing.Point(17, 17);
            this.lblCW_BasicSal.Name = "lblCW_BasicSal";
            this.lblCW_BasicSal.Size = new System.Drawing.Size(65, 12);
            this.lblCW_BasicSal.TabIndex = 45;
            this.lblCW_BasicSal.Text = "基本工资：";
            // 
            // gpbAllSum
            // 
            this.gpbAllSum.BackColor = System.Drawing.SystemColors.Control;
            this.gpbAllSum.Controls.Add(this.txtAll_Allsum);
            this.gpbAllSum.Controls.Add(this.lblAll_Allsum);
            this.gpbAllSum.Controls.Add(this.txtAll_Awd_Pun);
            this.gpbAllSum.Controls.Add(this.lblAll_Awd_Pun);
            this.gpbAllSum.Controls.Add(this.txtAll_Allwance);
            this.gpbAllSum.Controls.Add(this.lblAll_Allwance);
            this.gpbAllSum.Controls.Add(this.txtAll_Benifit);
            this.gpbAllSum.Controls.Add(this.lblAll_Benifit);
            this.gpbAllSum.Controls.Add(this.txtAll_OverWork);
            this.gpbAllSum.Controls.Add(this.lblAll_OverWork);
            this.gpbAllSum.Controls.Add(this.txtAll_BasicSum);
            this.gpbAllSum.Controls.Add(this.lblAll_BasicSum);
            this.gpbAllSum.Location = new System.Drawing.Point(18, 53);
            this.gpbAllSum.Name = "gpbAllSum";
            this.gpbAllSum.Size = new System.Drawing.Size(811, 69);
            this.gpbAllSum.TabIndex = 8;
            this.gpbAllSum.TabStop = false;
            this.gpbAllSum.Text = "总计";
            // 
            // txtAll_Allsum
            // 
            this.txtAll_Allsum.Location = new System.Drawing.Point(714, 31);
            this.txtAll_Allsum.Name = "txtAll_Allsum";
            this.txtAll_Allsum.ReadOnly = true;
            this.txtAll_Allsum.Size = new System.Drawing.Size(80, 21);
            this.txtAll_Allsum.TabIndex = 56;
            // 
            // lblAll_Allsum
            // 
            this.lblAll_Allsum.AutoSize = true;
            this.lblAll_Allsum.Location = new System.Drawing.Point(664, 34);
            this.lblAll_Allsum.Name = "lblAll_Allsum";
            this.lblAll_Allsum.Size = new System.Drawing.Size(53, 12);
            this.lblAll_Allsum.TabIndex = 55;
            this.lblAll_Allsum.Text = "总工资：";
            // 
            // txtAll_Awd_Pun
            // 
            this.txtAll_Awd_Pun.Location = new System.Drawing.Point(577, 31);
            this.txtAll_Awd_Pun.Name = "txtAll_Awd_Pun";
            this.txtAll_Awd_Pun.ReadOnly = true;
            this.txtAll_Awd_Pun.Size = new System.Drawing.Size(75, 21);
            this.txtAll_Awd_Pun.TabIndex = 54;
            // 
            // lblAll_Awd_Pun
            // 
            this.lblAll_Awd_Pun.AutoSize = true;
            this.lblAll_Awd_Pun.Location = new System.Drawing.Point(540, 34);
            this.lblAll_Awd_Pun.Name = "lblAll_Awd_Pun";
            this.lblAll_Awd_Pun.Size = new System.Drawing.Size(41, 12);
            this.lblAll_Awd_Pun.TabIndex = 53;
            this.lblAll_Awd_Pun.Text = "奖惩：";
            // 
            // txtAll_Allwance
            // 
            this.txtAll_Allwance.Location = new System.Drawing.Point(451, 31);
            this.txtAll_Allwance.Name = "txtAll_Allwance";
            this.txtAll_Allwance.ReadOnly = true;
            this.txtAll_Allwance.Size = new System.Drawing.Size(75, 21);
            this.txtAll_Allwance.TabIndex = 52;
            // 
            // lblAll_Allwance
            // 
            this.lblAll_Allwance.AutoSize = true;
            this.lblAll_Allwance.Location = new System.Drawing.Point(413, 34);
            this.lblAll_Allwance.Name = "lblAll_Allwance";
            this.lblAll_Allwance.Size = new System.Drawing.Size(41, 12);
            this.lblAll_Allwance.TabIndex = 51;
            this.lblAll_Allwance.Text = "津贴：";
            // 
            // txtAll_Benifit
            // 
            this.txtAll_Benifit.Location = new System.Drawing.Point(331, 31);
            this.txtAll_Benifit.Name = "txtAll_Benifit";
            this.txtAll_Benifit.ReadOnly = true;
            this.txtAll_Benifit.Size = new System.Drawing.Size(75, 21);
            this.txtAll_Benifit.TabIndex = 50;
            // 
            // lblAll_Benifit
            // 
            this.lblAll_Benifit.AutoSize = true;
            this.lblAll_Benifit.Location = new System.Drawing.Point(293, 34);
            this.lblAll_Benifit.Name = "lblAll_Benifit";
            this.lblAll_Benifit.Size = new System.Drawing.Size(41, 12);
            this.lblAll_Benifit.TabIndex = 49;
            this.lblAll_Benifit.Text = "补贴：";
            // 
            // txtAll_OverWork
            // 
            this.txtAll_OverWork.Location = new System.Drawing.Point(210, 31);
            this.txtAll_OverWork.Name = "txtAll_OverWork";
            this.txtAll_OverWork.ReadOnly = true;
            this.txtAll_OverWork.Size = new System.Drawing.Size(75, 21);
            this.txtAll_OverWork.TabIndex = 48;
            // 
            // lblAll_OverWork
            // 
            this.lblAll_OverWork.AutoSize = true;
            this.lblAll_OverWork.Location = new System.Drawing.Point(152, 34);
            this.lblAll_OverWork.Name = "lblAll_OverWork";
            this.lblAll_OverWork.Size = new System.Drawing.Size(65, 12);
            this.lblAll_OverWork.TabIndex = 47;
            this.lblAll_OverWork.Text = "加班工资：";
            // 
            // txtAll_BasicSum
            // 
            this.txtAll_BasicSum.Location = new System.Drawing.Point(72, 31);
            this.txtAll_BasicSum.Name = "txtAll_BasicSum";
            this.txtAll_BasicSum.ReadOnly = true;
            this.txtAll_BasicSum.Size = new System.Drawing.Size(75, 21);
            this.txtAll_BasicSum.TabIndex = 46;
            // 
            // lblAll_BasicSum
            // 
            this.lblAll_BasicSum.AutoSize = true;
            this.lblAll_BasicSum.Location = new System.Drawing.Point(11, 34);
            this.lblAll_BasicSum.Name = "lblAll_BasicSum";
            this.lblAll_BasicSum.Size = new System.Drawing.Size(65, 12);
            this.lblAll_BasicSum.TabIndex = 45;
            this.lblAll_BasicSum.Text = "基本工资：";
            // 
            // FrmCompanySalaryBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 692);
            this.Controls.Add(this.gpbAllSum);
            this.Controls.Add(this.gpbCW_Department);
            this.Controls.Add(this.gpbSC_Department);
            this.Controls.Add(this.gpbRS_Department);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label1);
            this.Name = "FrmCompanySalaryBrowse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公司工资查询";
            this.Load += new System.EventHandler(this.FrmCompanySalaryBrowse_Load);
            this.gpbRS_Department.ResumeLayout(false);
            this.gpbRS_Department.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRS_Salary)).EndInit();
            this.gpbSC_Department.ResumeLayout(false);
            this.gpbSC_Department.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSC_Salary)).EndInit();
            this.gpbCW_Department.ResumeLayout(false);
            this.gpbCW_Department.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCW_Salary)).EndInit();
            this.gpbAllSum.ResumeLayout(false);
            this.gpbAllSum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gpbRS_Department;
        private System.Windows.Forms.GroupBox gpbSC_Department;
        private System.Windows.Forms.GroupBox gpbCW_Department;
        private System.Windows.Forms.TextBox txtRS_AllSum;
        private System.Windows.Forms.Label lblRS_AllSum;
        private System.Windows.Forms.TextBox txtRS_Awd_Pun;
        private System.Windows.Forms.Label lblRS_Awd_Pun;
        private System.Windows.Forms.TextBox txtRS_Allwance;
        private System.Windows.Forms.Label lblRS_Allwance;
        private System.Windows.Forms.TextBox txtRS_Benifit;
        private System.Windows.Forms.Label lblRS_Benifit;
        private System.Windows.Forms.TextBox txtRS_OverWork;
        private System.Windows.Forms.Label lblRS_OverWork;
        private System.Windows.Forms.TextBox txtRS_BasicSal;
        private System.Windows.Forms.Label lblRS_BasicSal;
        private System.Windows.Forms.TextBox txtSC_AllSum;
        private System.Windows.Forms.Label lblSC_AllSum;
        private System.Windows.Forms.TextBox txtSC_Awd_Pun;
        private System.Windows.Forms.Label lblSC_Awd_Pun;
        private System.Windows.Forms.TextBox txtSC_Allwance;
        private System.Windows.Forms.Label lblSC_Allwance;
        private System.Windows.Forms.TextBox txtSC_Benifit;
        private System.Windows.Forms.Label lblSC_Benifit;
        private System.Windows.Forms.TextBox txtSC_OverWork;
        private System.Windows.Forms.Label lblSC_OverWork;
        private System.Windows.Forms.TextBox txtSC_BasicSal;
        private System.Windows.Forms.Label lblSC_BasicSal;
        private System.Windows.Forms.TextBox txtCW_AllSum;
        private System.Windows.Forms.Label lblCW_AllSum;
        private System.Windows.Forms.TextBox txtCW_Awd_Pun;
        private System.Windows.Forms.Label lblCW_Awd_Pun;
        private System.Windows.Forms.TextBox txtCW_Allwance;
        private System.Windows.Forms.Label lblCW_Allwance;
        private System.Windows.Forms.TextBox txtCW_Benifit;
        private System.Windows.Forms.Label lblCW_Benifit;
        private System.Windows.Forms.TextBox txtCW_OverWork;
        private System.Windows.Forms.Label lblCW_OverWork;
        private System.Windows.Forms.TextBox txtCW_BasicSal;
        private System.Windows.Forms.Label lblCW_BasicSal;
        private System.Windows.Forms.DataGridView dgvRS_Salary;
        private System.Windows.Forms.DataGridView dgvSC_Salary;
        private System.Windows.Forms.DataGridView dgvCW_Salary;
        private System.Windows.Forms.GroupBox gpbAllSum;
        private System.Windows.Forms.TextBox txtAll_Allsum;
        private System.Windows.Forms.Label lblAll_Allsum;
        private System.Windows.Forms.TextBox txtAll_Awd_Pun;
        private System.Windows.Forms.Label lblAll_Awd_Pun;
        private System.Windows.Forms.TextBox txtAll_Allwance;
        private System.Windows.Forms.Label lblAll_Allwance;
        private System.Windows.Forms.TextBox txtAll_Benifit;
        private System.Windows.Forms.Label lblAll_Benifit;
        private System.Windows.Forms.TextBox txtAll_OverWork;
        private System.Windows.Forms.Label lblAll_OverWork;
        private System.Windows.Forms.TextBox txtAll_BasicSum;
        private System.Windows.Forms.Label lblAll_BasicSum;
    }
}