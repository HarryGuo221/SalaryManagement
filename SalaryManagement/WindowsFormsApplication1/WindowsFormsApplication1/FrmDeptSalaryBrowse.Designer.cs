namespace WindowsFormsApplication1
{
    partial class FrmDeptSalaryBrowse
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
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlBossBrowse = new System.Windows.Forms.Panel();
            this.btnBoss_Browse = new System.Windows.Forms.Button();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.pnlSalarySum = new System.Windows.Forms.Panel();
            this.txtAllSum = new System.Windows.Forms.TextBox();
            this.lblAllSum = new System.Windows.Forms.Label();
            this.txtAwd_Pun = new System.Windows.Forms.TextBox();
            this.lblAwd_Pun = new System.Windows.Forms.Label();
            this.txtAllwance = new System.Windows.Forms.TextBox();
            this.lblAllwance = new System.Windows.Forms.Label();
            this.txtBenifit = new System.Windows.Forms.TextBox();
            this.lblBenifit = new System.Windows.Forms.Label();
            this.txtOverWork = new System.Windows.Forms.TextBox();
            this.lblOverWork = new System.Windows.Forms.Label();
            this.txtBasicSal = new System.Windows.Forms.TextBox();
            this.lblBasicSal = new System.Windows.Forms.Label();
            this.pnlDepartment = new System.Windows.Forms.Panel();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlBossBrowse.SuspendLayout();
            this.pnlSalarySum.SuspendLayout();
            this.pnlDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(131, 29);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(17, 12);
            this.lblYear.TabIndex = 10;
            this.lblYear.Text = "年";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2011",
            "2012",
            "2013"});
            this.cmbYear.Location = new System.Drawing.Point(38, 26);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(87, 20);
            this.cmbYear.TabIndex = 11;
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
            this.cmbMonth.Location = new System.Drawing.Point(158, 26);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(77, 20);
            this.cmbMonth.TabIndex = 13;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(238, 29);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 12;
            this.lblMonth.Text = "月";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(38, 61);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "查 看";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(785, 254);
            this.dataGridView1.TabIndex = 17;
            // 
            // pnlBossBrowse
            // 
            this.pnlBossBrowse.Controls.Add(this.btnBoss_Browse);
            this.pnlBossBrowse.Controls.Add(this.cmbDept);
            this.pnlBossBrowse.Controls.Add(this.lblDept);
            this.pnlBossBrowse.Location = new System.Drawing.Point(291, 12);
            this.pnlBossBrowse.Name = "pnlBossBrowse";
            this.pnlBossBrowse.Size = new System.Drawing.Size(197, 83);
            this.pnlBossBrowse.TabIndex = 18;
            // 
            // btnBoss_Browse
            // 
            this.btnBoss_Browse.Location = new System.Drawing.Point(17, 49);
            this.btnBoss_Browse.Name = "btnBoss_Browse";
            this.btnBoss_Browse.Size = new System.Drawing.Size(75, 23);
            this.btnBoss_Browse.TabIndex = 18;
            this.btnBoss_Browse.Text = "查 看";
            this.btnBoss_Browse.UseVisualStyleBackColor = true;
            this.btnBoss_Browse.Click += new System.EventHandler(this.btnBoss_Browse_Click);
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "人事部",
            "市场部",
            "财务部"});
            this.cmbDept.Location = new System.Drawing.Point(62, 14);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(121, 20);
            this.cmbDept.TabIndex = 17;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(15, 17);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(41, 12);
            this.lblDept.TabIndex = 16;
            this.lblDept.Text = "部门：";
            // 
            // pnlSalarySum
            // 
            this.pnlSalarySum.Controls.Add(this.txtAllSum);
            this.pnlSalarySum.Controls.Add(this.lblAllSum);
            this.pnlSalarySum.Controls.Add(this.txtAwd_Pun);
            this.pnlSalarySum.Controls.Add(this.lblAwd_Pun);
            this.pnlSalarySum.Controls.Add(this.txtAllwance);
            this.pnlSalarySum.Controls.Add(this.lblAllwance);
            this.pnlSalarySum.Controls.Add(this.txtBenifit);
            this.pnlSalarySum.Controls.Add(this.lblBenifit);
            this.pnlSalarySum.Controls.Add(this.txtOverWork);
            this.pnlSalarySum.Controls.Add(this.lblOverWork);
            this.pnlSalarySum.Controls.Add(this.txtBasicSal);
            this.pnlSalarySum.Controls.Add(this.lblBasicSal);
            this.pnlSalarySum.Location = new System.Drawing.Point(12, 101);
            this.pnlSalarySum.Name = "pnlSalarySum";
            this.pnlSalarySum.Size = new System.Drawing.Size(795, 44);
            this.pnlSalarySum.TabIndex = 19;
            // 
            // txtAllSum
            // 
            this.txtAllSum.Location = new System.Drawing.Point(704, 12);
            this.txtAllSum.Name = "txtAllSum";
            this.txtAllSum.ReadOnly = true;
            this.txtAllSum.Size = new System.Drawing.Size(80, 21);
            this.txtAllSum.TabIndex = 32;
            // 
            // lblAllSum
            // 
            this.lblAllSum.AutoSize = true;
            this.lblAllSum.Location = new System.Drawing.Point(654, 15);
            this.lblAllSum.Name = "lblAllSum";
            this.lblAllSum.Size = new System.Drawing.Size(53, 12);
            this.lblAllSum.TabIndex = 31;
            this.lblAllSum.Text = "总工资：";
            // 
            // txtAwd_Pun
            // 
            this.txtAwd_Pun.Location = new System.Drawing.Point(567, 12);
            this.txtAwd_Pun.Name = "txtAwd_Pun";
            this.txtAwd_Pun.ReadOnly = true;
            this.txtAwd_Pun.Size = new System.Drawing.Size(75, 21);
            this.txtAwd_Pun.TabIndex = 30;
            // 
            // lblAwd_Pun
            // 
            this.lblAwd_Pun.AutoSize = true;
            this.lblAwd_Pun.Location = new System.Drawing.Point(530, 15);
            this.lblAwd_Pun.Name = "lblAwd_Pun";
            this.lblAwd_Pun.Size = new System.Drawing.Size(41, 12);
            this.lblAwd_Pun.TabIndex = 29;
            this.lblAwd_Pun.Text = "奖惩：";
            // 
            // txtAllwance
            // 
            this.txtAllwance.Location = new System.Drawing.Point(441, 12);
            this.txtAllwance.Name = "txtAllwance";
            this.txtAllwance.ReadOnly = true;
            this.txtAllwance.Size = new System.Drawing.Size(75, 21);
            this.txtAllwance.TabIndex = 28;
            // 
            // lblAllwance
            // 
            this.lblAllwance.AutoSize = true;
            this.lblAllwance.Location = new System.Drawing.Point(403, 15);
            this.lblAllwance.Name = "lblAllwance";
            this.lblAllwance.Size = new System.Drawing.Size(41, 12);
            this.lblAllwance.TabIndex = 27;
            this.lblAllwance.Text = "津贴：";
            // 
            // txtBenifit
            // 
            this.txtBenifit.Location = new System.Drawing.Point(321, 12);
            this.txtBenifit.Name = "txtBenifit";
            this.txtBenifit.ReadOnly = true;
            this.txtBenifit.Size = new System.Drawing.Size(75, 21);
            this.txtBenifit.TabIndex = 26;
            // 
            // lblBenifit
            // 
            this.lblBenifit.AutoSize = true;
            this.lblBenifit.Location = new System.Drawing.Point(283, 15);
            this.lblBenifit.Name = "lblBenifit";
            this.lblBenifit.Size = new System.Drawing.Size(41, 12);
            this.lblBenifit.TabIndex = 25;
            this.lblBenifit.Text = "补贴：";
            // 
            // txtOverWork
            // 
            this.txtOverWork.Location = new System.Drawing.Point(200, 12);
            this.txtOverWork.Name = "txtOverWork";
            this.txtOverWork.ReadOnly = true;
            this.txtOverWork.Size = new System.Drawing.Size(75, 21);
            this.txtOverWork.TabIndex = 24;
            // 
            // lblOverWork
            // 
            this.lblOverWork.AutoSize = true;
            this.lblOverWork.Location = new System.Drawing.Point(142, 15);
            this.lblOverWork.Name = "lblOverWork";
            this.lblOverWork.Size = new System.Drawing.Size(65, 12);
            this.lblOverWork.TabIndex = 23;
            this.lblOverWork.Text = "加班工资：";
            // 
            // txtBasicSal
            // 
            this.txtBasicSal.Location = new System.Drawing.Point(62, 12);
            this.txtBasicSal.Name = "txtBasicSal";
            this.txtBasicSal.ReadOnly = true;
            this.txtBasicSal.Size = new System.Drawing.Size(75, 21);
            this.txtBasicSal.TabIndex = 22;
            // 
            // lblBasicSal
            // 
            this.lblBasicSal.AutoSize = true;
            this.lblBasicSal.Location = new System.Drawing.Point(1, 15);
            this.lblBasicSal.Name = "lblBasicSal";
            this.lblBasicSal.Size = new System.Drawing.Size(65, 12);
            this.lblBasicSal.TabIndex = 21;
            this.lblBasicSal.Text = "基本工资：";
            // 
            // pnlDepartment
            // 
            this.pnlDepartment.Controls.Add(this.cmbDepartment);
            this.pnlDepartment.Controls.Add(this.lblDepartment);
            this.pnlDepartment.Location = new System.Drawing.Point(519, 12);
            this.pnlDepartment.Name = "pnlDepartment";
            this.pnlDepartment.Size = new System.Drawing.Size(200, 83);
            this.pnlDepartment.TabIndex = 20;
            this.pnlDepartment.Visible = false;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Enabled = false;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "人事部",
            "市场部",
            "财务部"});
            this.cmbDepartment.Location = new System.Drawing.Point(74, 14);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 20);
            this.cmbDepartment.TabIndex = 1;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDepartment.Location = new System.Drawing.Point(3, 17);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 12);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "所在部门：";
            // 
            // FrmDeptSalaryBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 417);
            this.Controls.Add(this.pnlDepartment);
            this.Controls.Add(this.pnlSalarySum);
            this.Controls.Add(this.pnlBossBrowse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Name = "FrmDeptSalaryBrowse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门工资查询";
            this.Load += new System.EventHandler(this.FrmDeptSalaryBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlBossBrowse.ResumeLayout(false);
            this.pnlBossBrowse.PerformLayout();
            this.pnlSalarySum.ResumeLayout(false);
            this.pnlSalarySum.PerformLayout();
            this.pnlDepartment.ResumeLayout(false);
            this.pnlDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlBossBrowse;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Button btnBoss_Browse;
        private System.Windows.Forms.Panel pnlSalarySum;
        private System.Windows.Forms.TextBox txtAllSum;
        private System.Windows.Forms.Label lblAllSum;
        private System.Windows.Forms.TextBox txtAwd_Pun;
        private System.Windows.Forms.Label lblAwd_Pun;
        private System.Windows.Forms.TextBox txtAllwance;
        private System.Windows.Forms.Label lblAllwance;
        private System.Windows.Forms.TextBox txtBenifit;
        private System.Windows.Forms.Label lblBenifit;
        private System.Windows.Forms.TextBox txtOverWork;
        private System.Windows.Forms.Label lblOverWork;
        private System.Windows.Forms.TextBox txtBasicSal;
        private System.Windows.Forms.Label lblBasicSal;
        private System.Windows.Forms.Panel pnlDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblDepartment;
    }
}