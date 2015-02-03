namespace WindowsFormsApplication1
{
    partial class FrmOn_OffDuty
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
            this.txtEno = new System.Windows.Forms.TextBox();
            this.lblOn_OffType = new System.Windows.Forms.Label();
            this.cmbOn_OffType = new System.Windows.Forms.ComboBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEno
            // 
            this.lblEno.AutoSize = true;
            this.lblEno.Location = new System.Drawing.Point(47, 46);
            this.lblEno.Name = "lblEno";
            this.lblEno.Size = new System.Drawing.Size(53, 12);
            this.lblEno.TabIndex = 0;
            this.lblEno.Text = "员工号：";
            // 
            // txtEno
            // 
            this.txtEno.Location = new System.Drawing.Point(106, 43);
            this.txtEno.Name = "txtEno";
            this.txtEno.Size = new System.Drawing.Size(121, 21);
            this.txtEno.TabIndex = 1;
            // 
            // lblOn_OffType
            // 
            this.lblOn_OffType.AutoSize = true;
            this.lblOn_OffType.Location = new System.Drawing.Point(17, 85);
            this.lblOn_OffType.Name = "lblOn_OffType";
            this.lblOn_OffType.Size = new System.Drawing.Size(83, 12);
            this.lblOn_OffType.TabIndex = 2;
            this.lblOn_OffType.Text = "上/离职种类：";
            // 
            // cmbOn_OffType
            // 
            this.cmbOn_OffType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOn_OffType.FormattingEnabled = true;
            this.cmbOn_OffType.Items.AddRange(new object[] {
            "上岗",
            "离职"});
            this.cmbOn_OffType.Location = new System.Drawing.Point(106, 82);
            this.cmbOn_OffType.Name = "cmbOn_OffType";
            this.cmbOn_OffType.Size = new System.Drawing.Size(121, 20);
            this.cmbOn_OffType.TabIndex = 3;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(59, 124);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(41, 12);
            this.lblReason.TabIndex = 4;
            this.lblReason.Text = "原因：";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(106, 124);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(121, 77);
            this.txtReason.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(36, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确 认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(171, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmOn_OffDuty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 293);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.cmbOn_OffType);
            this.Controls.Add(this.lblOn_OffType);
            this.Controls.Add(this.txtEno);
            this.Controls.Add(this.lblEno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOn_OffDuty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工上离职管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEno;
        private System.Windows.Forms.TextBox txtEno;
        private System.Windows.Forms.Label lblOn_OffType;
        private System.Windows.Forms.ComboBox cmbOn_OffType;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}