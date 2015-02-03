namespace WindowsFormsApplication1
{
    partial class FrmPersonalSalaryBrowse
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dgvPersonalSalary = new System.Windows.Forms.DataGridView();
            this.pnlManagerOnly = new System.Windows.Forms.Panel();
            this.btnBoss_Browse = new System.Windows.Forms.Button();
            this.btnBrowseEmployee = new System.Windows.Forms.Button();
            this.lblEno = new System.Windows.Forms.Label();
            this.txtEno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalSalary)).BeginInit();
            this.pnlManagerOnly.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(142, 28);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(17, 12);
            this.lblYear.TabIndex = 0;
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
            this.cmbYear.Location = new System.Drawing.Point(38, 25);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(98, 20);
            this.cmbYear.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(229, 28);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "月";
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
            this.cmbMonth.Location = new System.Drawing.Point(165, 25);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(58, 20);
            this.cmbMonth.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(38, 60);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "浏 览";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // dgvPersonalSalary
            // 
            this.dgvPersonalSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonalSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalSalary.Location = new System.Drawing.Point(12, 98);
            this.dgvPersonalSalary.Name = "dgvPersonalSalary";
            this.dgvPersonalSalary.RowTemplate.Height = 23;
            this.dgvPersonalSalary.Size = new System.Drawing.Size(544, 196);
            this.dgvPersonalSalary.TabIndex = 5;
            // 
            // pnlManagerOnly
            // 
            this.pnlManagerOnly.Controls.Add(this.btnBoss_Browse);
            this.pnlManagerOnly.Controls.Add(this.btnBrowseEmployee);
            this.pnlManagerOnly.Controls.Add(this.lblEno);
            this.pnlManagerOnly.Controls.Add(this.txtEno);
            this.pnlManagerOnly.Location = new System.Drawing.Point(270, 12);
            this.pnlManagerOnly.Name = "pnlManagerOnly";
            this.pnlManagerOnly.Size = new System.Drawing.Size(286, 80);
            this.pnlManagerOnly.TabIndex = 6;
            // 
            // btnBoss_Browse
            // 
            this.btnBoss_Browse.Location = new System.Drawing.Point(158, 48);
            this.btnBoss_Browse.Name = "btnBoss_Browse";
            this.btnBoss_Browse.Size = new System.Drawing.Size(75, 23);
            this.btnBoss_Browse.TabIndex = 3;
            this.btnBoss_Browse.Text = "浏 览";
            this.btnBoss_Browse.UseVisualStyleBackColor = true;
            this.btnBoss_Browse.Click += new System.EventHandler(this.btnBoss_Browse_Click);
            // 
            // btnBrowseEmployee
            // 
            this.btnBrowseEmployee.Location = new System.Drawing.Point(191, 11);
            this.btnBrowseEmployee.Name = "btnBrowseEmployee";
            this.btnBrowseEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseEmployee.TabIndex = 2;
            this.btnBrowseEmployee.Text = "查看员工";
            this.btnBrowseEmployee.UseVisualStyleBackColor = true;
            this.btnBrowseEmployee.Click += new System.EventHandler(this.btnBrowseEmployee_Click);
            // 
            // lblEno
            // 
            this.lblEno.AutoSize = true;
            this.lblEno.Location = new System.Drawing.Point(14, 16);
            this.lblEno.Name = "lblEno";
            this.lblEno.Size = new System.Drawing.Size(53, 12);
            this.lblEno.TabIndex = 1;
            this.lblEno.Text = "员工号：";
            // 
            // txtEno
            // 
            this.txtEno.Location = new System.Drawing.Point(73, 13);
            this.txtEno.Name = "txtEno";
            this.txtEno.Size = new System.Drawing.Size(100, 21);
            this.txtEno.TabIndex = 0;
            // 
            // FrmPersonalSalaryBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 306);
            this.Controls.Add(this.pnlManagerOnly);
            this.Controls.Add(this.dgvPersonalSalary);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Name = "FrmPersonalSalaryBrowse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人工资查询";
            this.Load += new System.EventHandler(this.FrmPersonalSalaryBrowse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalSalary)).EndInit();
            this.pnlManagerOnly.ResumeLayout(false);
            this.pnlManagerOnly.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dgvPersonalSalary;
        private System.Windows.Forms.Panel pnlManagerOnly;
        private System.Windows.Forms.Button btnBrowseEmployee;
        private System.Windows.Forms.Label lblEno;
        private System.Windows.Forms.TextBox txtEno;
        private System.Windows.Forms.Button btnBoss_Browse;
    }
}