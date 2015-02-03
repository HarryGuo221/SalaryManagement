namespace WindowsFormsApplication1
{
    partial class FrmAwd_PunStandard
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
            this.txtAwd_PunMoney = new System.Windows.Forms.TextBox();
            this.lblAwd_PunMoney = new System.Windows.Forms.Label();
            this.lblAwd_PunTitle = new System.Windows.Forms.Label();
            this.txtAwd_PunTitle = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.brnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAwd_PunNo = new System.Windows.Forms.Label();
            this.txtAwd_PunNo = new System.Windows.Forms.TextBox();
            this.lblHeadsUp = new System.Windows.Forms.Label();
            this.lblAwd_PunMemo = new System.Windows.Forms.Label();
            this.txtAwd_PunMemo = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAwd_PunMoney
            // 
            this.txtAwd_PunMoney.Location = new System.Drawing.Point(104, 109);
            this.txtAwd_PunMoney.Name = "txtAwd_PunMoney";
            this.txtAwd_PunMoney.Size = new System.Drawing.Size(133, 21);
            this.txtAwd_PunMoney.TabIndex = 0;
            // 
            // lblAwd_PunMoney
            // 
            this.lblAwd_PunMoney.AutoSize = true;
            this.lblAwd_PunMoney.Location = new System.Drawing.Point(33, 112);
            this.lblAwd_PunMoney.Name = "lblAwd_PunMoney";
            this.lblAwd_PunMoney.Size = new System.Drawing.Size(65, 12);
            this.lblAwd_PunMoney.TabIndex = 1;
            this.lblAwd_PunMoney.Text = "奖惩金额：";
            // 
            // lblAwd_PunTitle
            // 
            this.lblAwd_PunTitle.AutoSize = true;
            this.lblAwd_PunTitle.Location = new System.Drawing.Point(33, 74);
            this.lblAwd_PunTitle.Name = "lblAwd_PunTitle";
            this.lblAwd_PunTitle.Size = new System.Drawing.Size(65, 12);
            this.lblAwd_PunTitle.TabIndex = 3;
            this.lblAwd_PunTitle.Text = "奖惩名称：";
            // 
            // txtAwd_PunTitle
            // 
            this.txtAwd_PunTitle.Location = new System.Drawing.Point(104, 71);
            this.txtAwd_PunTitle.Name = "txtAwd_PunTitle";
            this.txtAwd_PunTitle.Size = new System.Drawing.Size(133, 21);
            this.txtAwd_PunTitle.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(59, 208);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // brnCancel
            // 
            this.brnCancel.Location = new System.Drawing.Point(172, 208);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(75, 23);
            this.brnCancel.TabIndex = 5;
            this.brnCancel.Text = "取 消";
            this.brnCancel.UseVisualStyleBackColor = true;
            this.brnCancel.Click += new System.EventHandler(this.brnCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(283, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(268, 17);
            this.toolStripStatusLabel1.Text = "注意：奖惩金额必须为阿拉伯数字形式(正负均可)";
            // 
            // lblAwd_PunNo
            // 
            this.lblAwd_PunNo.AutoSize = true;
            this.lblAwd_PunNo.Location = new System.Drawing.Point(9, 20);
            this.lblAwd_PunNo.Name = "lblAwd_PunNo";
            this.lblAwd_PunNo.Size = new System.Drawing.Size(89, 12);
            this.lblAwd_PunNo.TabIndex = 8;
            this.lblAwd_PunNo.Text = "奖惩标准编号：";
            // 
            // txtAwd_PunNo
            // 
            this.txtAwd_PunNo.Location = new System.Drawing.Point(104, 17);
            this.txtAwd_PunNo.Name = "txtAwd_PunNo";
            this.txtAwd_PunNo.Size = new System.Drawing.Size(133, 21);
            this.txtAwd_PunNo.TabIndex = 9;
            this.txtAwd_PunNo.TextChanged += new System.EventHandler(this.txtAwd_PunNo_TextChanged);
            // 
            // lblHeadsUp
            // 
            this.lblHeadsUp.AutoSize = true;
            this.lblHeadsUp.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHeadsUp.ForeColor = System.Drawing.Color.Red;
            this.lblHeadsUp.Location = new System.Drawing.Point(104, 45);
            this.lblHeadsUp.Name = "lblHeadsUp";
            this.lblHeadsUp.Size = new System.Drawing.Size(110, 10);
            this.lblHeadsUp.TabIndex = 10;
            this.lblHeadsUp.Text = "*若需添加标准，请输入";
            // 
            // lblAwd_PunMemo
            // 
            this.lblAwd_PunMemo.AutoSize = true;
            this.lblAwd_PunMemo.Location = new System.Drawing.Point(57, 150);
            this.lblAwd_PunMemo.Name = "lblAwd_PunMemo";
            this.lblAwd_PunMemo.Size = new System.Drawing.Size(41, 12);
            this.lblAwd_PunMemo.TabIndex = 11;
            this.lblAwd_PunMemo.Text = "备注：";
            // 
            // txtAwd_PunMemo
            // 
            this.txtAwd_PunMemo.Location = new System.Drawing.Point(104, 147);
            this.txtAwd_PunMemo.Multiline = true;
            this.txtAwd_PunMemo.Name = "txtAwd_PunMemo";
            this.txtAwd_PunMemo.Size = new System.Drawing.Size(133, 48);
            this.txtAwd_PunMemo.TabIndex = 12;
            // 
            // FrmAwd_PunStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 266);
            this.Controls.Add(this.txtAwd_PunMemo);
            this.Controls.Add(this.lblAwd_PunMemo);
            this.Controls.Add(this.lblHeadsUp);
            this.Controls.Add(this.txtAwd_PunNo);
            this.Controls.Add(this.lblAwd_PunNo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.brnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblAwd_PunTitle);
            this.Controls.Add(this.txtAwd_PunTitle);
            this.Controls.Add(this.lblAwd_PunMoney);
            this.Controls.Add(this.txtAwd_PunMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAwd_PunStandard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "奖惩标准";
            this.Load += new System.EventHandler(this.FrmAwd_PunStandard_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAwd_PunMoney;
        private System.Windows.Forms.Label lblAwd_PunMoney;
        private System.Windows.Forms.Label lblAwd_PunTitle;
        private System.Windows.Forms.TextBox txtAwd_PunTitle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblAwd_PunNo;
        private System.Windows.Forms.TextBox txtAwd_PunNo;
        private System.Windows.Forms.Label lblHeadsUp;
        private System.Windows.Forms.Label lblAwd_PunMemo;
        private System.Windows.Forms.TextBox txtAwd_PunMemo;
    }
}