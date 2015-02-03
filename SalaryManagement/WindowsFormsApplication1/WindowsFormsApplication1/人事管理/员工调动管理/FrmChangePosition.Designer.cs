namespace WindowsFormsApplication1
{
    partial class FrmChangePosition
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
            this.lblEno = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.btnLoadByNo = new System.Windows.Forms.Button();
            this.btnLoadByName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEno
            // 
            this.lblEno.AutoSize = true;
            this.lblEno.Location = new System.Drawing.Point(57, 49);
            this.lblEno.Name = "lblEno";
            this.lblEno.Size = new System.Drawing.Size(41, 12);
            this.lblEno.TabIndex = 0;
            this.lblEno.Text = "编号：";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(104, 46);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 21);
            this.txtNo.TabIndex = 1;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(57, 118);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 12);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "部门：";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(57, 154);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(41, 12);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "职位：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(75, 209);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "完 成";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(57, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "姓名：";
            // 
            // cmbDept
            // 
            this.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "人事部",
            "市场部",
            "财务部"});
            this.cmbDept.Location = new System.Drawing.Point(104, 115);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(146, 20);
            this.cmbDept.TabIndex = 10;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "总经理",
            "总监",
            "部门经理",
            "部门主任",
            "工龄小于5年",
            "工龄小于10年",
            "工龄大于10年"});
            this.cmbPosition.Location = new System.Drawing.Point(104, 151);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(146, 20);
            this.cmbPosition.TabIndex = 11;
            // 
            // btnLoadByNo
            // 
            this.btnLoadByNo.Location = new System.Drawing.Point(210, 44);
            this.btnLoadByNo.Name = "btnLoadByNo";
            this.btnLoadByNo.Size = new System.Drawing.Size(62, 23);
            this.btnLoadByNo.TabIndex = 12;
            this.btnLoadByNo.Text = "加载数据";
            this.btnLoadByNo.UseVisualStyleBackColor = true;
            this.btnLoadByNo.Click += new System.EventHandler(this.btnLoadByNo_Click);
            // 
            // btnLoadByName
            // 
            this.btnLoadByName.Location = new System.Drawing.Point(210, 79);
            this.btnLoadByName.Name = "btnLoadByName";
            this.btnLoadByName.Size = new System.Drawing.Size(62, 23);
            this.btnLoadByName.TabIndex = 13;
            this.btnLoadByName.Text = "加载数据";
            this.btnLoadByName.UseVisualStyleBackColor = true;
            this.btnLoadByName.Click += new System.EventHandler(this.btnLoadByName_Click);
            // 
            // FrmChangePosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 262);
            this.Controls.Add(this.btnLoadByName);
            this.Controls.Add(this.btnLoadByNo);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblEno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmChangePosition";
            this.Text = "员工调度";
            this.Load += new System.EventHandler(this.FrmChangePosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEno;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Button btnLoadByNo;
        private System.Windows.Forms.Button btnLoadByName;
    }
}