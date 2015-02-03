namespace WindowsFormsApplication1
{
    partial class SalaryCategory
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbBenifit = new System.Windows.Forms.CheckBox();
            this.cbSalary = new System.Windows.Forms.CheckBox();
            this.cbOvertimeWork = new System.Windows.Forms.CheckBox();
            this.cbAllowance = new System.Windows.Forms.CheckBox();
            this.cbAwd_Pun = new System.Windows.Forms.CheckBox();
            this.pnlCheckBox = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "总经理",
            "总监",
            "部门经理",
            "部门主任",
            "工龄小于5年",
            "工龄小于10年",
            "工龄大于10年"});
            this.comboBox1.Location = new System.Drawing.Point(105, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 6;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(45, 24);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(35, 12);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "职位:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(47, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(175, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbBenifit
            // 
            this.cbBenifit.AutoSize = true;
            this.cbBenifit.Location = new System.Drawing.Point(16, 49);
            this.cbBenifit.Name = "cbBenifit";
            this.cbBenifit.Size = new System.Drawing.Size(48, 16);
            this.cbBenifit.TabIndex = 13;
            this.cbBenifit.Tag = "2";
            this.cbBenifit.Text = "津贴";
            this.cbBenifit.UseVisualStyleBackColor = true;
            this.cbBenifit.CheckedChanged += new System.EventHandler(this.cbSalary_CheckedChanged);
            // 
            // cbSalary
            // 
            this.cbSalary.AutoSize = true;
            this.cbSalary.Checked = true;
            this.cbSalary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSalary.Location = new System.Drawing.Point(16, 12);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.Size = new System.Drawing.Size(72, 16);
            this.cbSalary.TabIndex = 14;
            this.cbSalary.Tag = "1";
            this.cbSalary.Text = "基本工资";
            this.cbSalary.UseVisualStyleBackColor = true;
            this.cbSalary.CheckedChanged += new System.EventHandler(this.cbSalary_CheckedChanged);
            // 
            // cbOvertimeWork
            // 
            this.cbOvertimeWork.AutoSize = true;
            this.cbOvertimeWork.Checked = true;
            this.cbOvertimeWork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOvertimeWork.Location = new System.Drawing.Point(16, 123);
            this.cbOvertimeWork.Name = "cbOvertimeWork";
            this.cbOvertimeWork.Size = new System.Drawing.Size(60, 16);
            this.cbOvertimeWork.TabIndex = 11;
            this.cbOvertimeWork.Tag = "4";
            this.cbOvertimeWork.Text = "加班费";
            this.cbOvertimeWork.UseVisualStyleBackColor = true;
            this.cbOvertimeWork.CheckedChanged += new System.EventHandler(this.cbSalary_CheckedChanged);
            // 
            // cbAllowance
            // 
            this.cbAllowance.AutoSize = true;
            this.cbAllowance.Location = new System.Drawing.Point(16, 86);
            this.cbAllowance.Name = "cbAllowance";
            this.cbAllowance.Size = new System.Drawing.Size(48, 16);
            this.cbAllowance.TabIndex = 12;
            this.cbAllowance.Tag = "3";
            this.cbAllowance.Text = "补贴";
            this.cbAllowance.UseVisualStyleBackColor = true;
            this.cbAllowance.CheckedChanged += new System.EventHandler(this.cbSalary_CheckedChanged);
            // 
            // cbAwd_Pun
            // 
            this.cbAwd_Pun.AutoSize = true;
            this.cbAwd_Pun.Location = new System.Drawing.Point(16, 163);
            this.cbAwd_Pun.Name = "cbAwd_Pun";
            this.cbAwd_Pun.Size = new System.Drawing.Size(72, 16);
            this.cbAwd_Pun.TabIndex = 10;
            this.cbAwd_Pun.Tag = "5";
            this.cbAwd_Pun.Text = "奖惩款项";
            this.cbAwd_Pun.UseVisualStyleBackColor = true;
            this.cbAwd_Pun.CheckedChanged += new System.EventHandler(this.cbSalary_CheckedChanged);
            // 
            // pnlCheckBox
            // 
            this.pnlCheckBox.Controls.Add(this.cbSalary);
            this.pnlCheckBox.Controls.Add(this.cbBenifit);
            this.pnlCheckBox.Controls.Add(this.cbAllowance);
            this.pnlCheckBox.Controls.Add(this.cbOvertimeWork);
            this.pnlCheckBox.Controls.Add(this.cbAwd_Pun);
            this.pnlCheckBox.Location = new System.Drawing.Point(30, 47);
            this.pnlCheckBox.Name = "pnlCheckBox";
            this.pnlCheckBox.Size = new System.Drawing.Size(110, 194);
            this.pnlCheckBox.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(164, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 196);
            this.listBox1.TabIndex = 16;
            // 
            // SalaryCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 282);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SalaryCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工资栏目";
            this.pnlCheckBox.ResumeLayout(false);
            this.pnlCheckBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbBenifit;
        private System.Windows.Forms.CheckBox cbSalary;
        private System.Windows.Forms.CheckBox cbOvertimeWork;
        private System.Windows.Forms.CheckBox cbAllowance;
        private System.Windows.Forms.CheckBox cbAwd_Pun;
        private System.Windows.Forms.Panel pnlCheckBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}