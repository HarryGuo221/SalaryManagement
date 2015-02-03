namespace WindowsFormsApplication1
{
    partial class FrmContractManage
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
            this.lblContractType = new System.Windows.Forms.Label();
            this.txtEno = new System.Windows.Forms.TextBox();
            this.lblEno = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblJobPosition = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.MobilePhoneNumber = new System.Windows.Forms.Label();
            this.cmbContractType = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbJobPosition = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblTimeShow = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.btnChooseContract = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContractType
            // 
            this.lblContractType.AutoSize = true;
            this.lblContractType.Location = new System.Drawing.Point(113, 72);
            this.lblContractType.Name = "lblContractType";
            this.lblContractType.Size = new System.Drawing.Size(65, 12);
            this.lblContractType.TabIndex = 0;
            this.lblContractType.Text = "合同类型：";
            // 
            // txtEno
            // 
            this.txtEno.Location = new System.Drawing.Point(184, 96);
            this.txtEno.Name = "txtEno";
            this.txtEno.Size = new System.Drawing.Size(121, 21);
            this.txtEno.TabIndex = 3;
            // 
            // lblEno
            // 
            this.lblEno.AutoSize = true;
            this.lblEno.Location = new System.Drawing.Point(113, 99);
            this.lblEno.Name = "lblEno";
            this.lblEno.Size = new System.Drawing.Size(65, 12);
            this.lblEno.TabIndex = 2;
            this.lblEno.Text = "员工编号：";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(113, 126);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(65, 12);
            this.lblDepartment.TabIndex = 4;
            this.lblDepartment.Text = "所在部门：";
            // 
            // lblJobPosition
            // 
            this.lblJobPosition.AutoSize = true;
            this.lblJobPosition.Location = new System.Drawing.Point(137, 153);
            this.lblJobPosition.Name = "lblJobPosition";
            this.lblJobPosition.Size = new System.Drawing.Size(41, 12);
            this.lblJobPosition.TabIndex = 6;
            this.lblJobPosition.Text = "职位：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(137, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "姓名：";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(137, 207);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 12);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "性别：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(184, 231);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 21);
            this.txtID.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(113, 234);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 12);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "身份证号：";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(184, 258);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(121, 21);
            this.txtPhoneNumber.TabIndex = 15;
            // 
            // MobilePhoneNumber
            // 
            this.MobilePhoneNumber.AutoSize = true;
            this.MobilePhoneNumber.Location = new System.Drawing.Point(113, 261);
            this.MobilePhoneNumber.Name = "MobilePhoneNumber";
            this.MobilePhoneNumber.Size = new System.Drawing.Size(65, 12);
            this.MobilePhoneNumber.TabIndex = 14;
            this.MobilePhoneNumber.Text = "联系电话：";
            // 
            // cmbContractType
            // 
            this.cmbContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContractType.FormattingEnabled = true;
            this.cmbContractType.Items.AddRange(new object[] {
            "正式合同",
            "试用合同"});
            this.cmbContractType.Location = new System.Drawing.Point(184, 69);
            this.cmbContractType.Name = "cmbContractType";
            this.cmbContractType.Size = new System.Drawing.Size(121, 20);
            this.cmbContractType.TabIndex = 16;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "人事部",
            "市场部",
            "财务部"});
            this.cmbDepartment.Location = new System.Drawing.Point(184, 123);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 20);
            this.cmbDepartment.TabIndex = 17;
            // 
            // cmbJobPosition
            // 
            this.cmbJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobPosition.FormattingEnabled = true;
            this.cmbJobPosition.Items.AddRange(new object[] {
            "总经理",
            "总监",
            "部门经理",
            "部门主任",
            "工龄小于5年",
            "工龄小于10年",
            "工龄大于10年"});
            this.cmbJobPosition.Location = new System.Drawing.Point(184, 150);
            this.cmbJobPosition.Name = "cmbJobPosition";
            this.cmbJobPosition.Size = new System.Drawing.Size(121, 20);
            this.cmbJobPosition.TabIndex = 18;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(184, 205);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(35, 16);
            this.rdoMale.TabIndex = 19;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(270, 205);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(35, 16);
            this.rdoFemale.TabIndex = 20;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(115, 305);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "保 存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblTime,
            this.sslblTimeShow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(467, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslblTime
            // 
            this.sslblTime.Name = "sslblTime";
            this.sslblTime.Size = new System.Drawing.Size(68, 17);
            this.sslblTime.Text = "现在时刻：";
            // 
            // sslblTimeShow
            // 
            this.sslblTimeShow.Name = "sslblTimeShow";
            this.sslblTimeShow.Size = new System.Drawing.Size(131, 17);
            this.sslblTimeShow.Text = "toolStripStatusLabel1";
            // 
            // lblContractNo
            // 
            this.lblContractNo.AutoSize = true;
            this.lblContractNo.Location = new System.Drawing.Point(124, 45);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(53, 12);
            this.lblContractNo.TabIndex = 24;
            this.lblContractNo.Text = "合同号：";
            // 
            // txtContractNo
            // 
            this.txtContractNo.Location = new System.Drawing.Point(184, 42);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.ReadOnly = true;
            this.txtContractNo.Size = new System.Drawing.Size(121, 21);
            this.txtContractNo.TabIndex = 25;
            // 
            // btnChooseContract
            // 
            this.btnChooseContract.Location = new System.Drawing.Point(199, 12);
            this.btnChooseContract.Name = "btnChooseContract";
            this.btnChooseContract.Size = new System.Drawing.Size(75, 23);
            this.btnChooseContract.TabIndex = 26;
            this.btnChooseContract.Text = "选择合同";
            this.btnChooseContract.UseVisualStyleBackColor = true;
            this.btnChooseContract.Click += new System.EventHandler(this.btnChooseContract_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmContractManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 358);
            this.Controls.Add(this.btnChooseContract);
            this.Controls.Add(this.txtContractNo);
            this.Controls.Add(this.lblContractNo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.cmbJobPosition);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.cmbContractType);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.MobilePhoneNumber);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblJobPosition);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtEno);
            this.Controls.Add(this.lblEno);
            this.Controls.Add(this.lblContractType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmContractManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmContractManage";
            this.Load += new System.EventHandler(this.FrmContractManage_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContractType;
        private System.Windows.Forms.TextBox txtEno;
        private System.Windows.Forms.Label lblEno;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblJobPosition;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label MobilePhoneNumber;
        private System.Windows.Forms.ComboBox cmbContractType;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbJobPosition;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslblTime;
        private System.Windows.Forms.ToolStripStatusLabel sslblTimeShow;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.TextBox txtContractNo;
        private System.Windows.Forms.Button btnChooseContract;
        private System.Windows.Forms.Timer timer1;
    }
}