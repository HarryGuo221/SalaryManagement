namespace WindowsFormsApplication1
{
    partial class FrmAwd_Pun
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlAwd_Pun = new System.Windows.Forms.Panel();
            this.cbAbsenceWithoutAsk = new System.Windows.Forms.CheckBox();
            this.cbContribution = new System.Windows.Forms.CheckBox();
            this.cbCreativeIdea = new System.Windows.Forms.CheckBox();
            this.btnBrowseLog = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.pnlAwd_Pun.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(12, 25);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(41, 12);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "编号：";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(59, 22);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 21);
            this.txtNo.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确 认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(88, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(168, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "查看编号";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(255, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sslblTime
            // 
            this.sslblTime.Name = "sslblTime";
            this.sslblTime.Size = new System.Drawing.Size(131, 17);
            this.sslblTime.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlAwd_Pun
            // 
            this.pnlAwd_Pun.Controls.Add(this.cbAbsenceWithoutAsk);
            this.pnlAwd_Pun.Controls.Add(this.cbContribution);
            this.pnlAwd_Pun.Controls.Add(this.cbCreativeIdea);
            this.pnlAwd_Pun.Location = new System.Drawing.Point(12, 49);
            this.pnlAwd_Pun.Name = "pnlAwd_Pun";
            this.pnlAwd_Pun.Size = new System.Drawing.Size(231, 170);
            this.pnlAwd_Pun.TabIndex = 9;
            // 
            // cbAbsenceWithoutAsk
            // 
            this.cbAbsenceWithoutAsk.AutoSize = true;
            this.cbAbsenceWithoutAsk.Location = new System.Drawing.Point(79, 120);
            this.cbAbsenceWithoutAsk.Name = "cbAbsenceWithoutAsk";
            this.cbAbsenceWithoutAsk.Size = new System.Drawing.Size(96, 16);
            this.cbAbsenceWithoutAsk.TabIndex = 7;
            this.cbAbsenceWithoutAsk.Tag = "5";
            this.cbAbsenceWithoutAsk.Text = "无假旷工一天";
            this.cbAbsenceWithoutAsk.UseVisualStyleBackColor = true;
            // 
            // cbContribution
            // 
            this.cbContribution.AutoSize = true;
            this.cbContribution.Location = new System.Drawing.Point(79, 64);
            this.cbContribution.Name = "cbContribution";
            this.cbContribution.Size = new System.Drawing.Size(60, 16);
            this.cbContribution.TabIndex = 6;
            this.cbContribution.Tag = "2";
            this.cbContribution.Text = "贡献奖";
            this.cbContribution.UseVisualStyleBackColor = true;
            // 
            // cbCreativeIdea
            // 
            this.cbCreativeIdea.AutoSize = true;
            this.cbCreativeIdea.Location = new System.Drawing.Point(79, 29);
            this.cbCreativeIdea.Name = "cbCreativeIdea";
            this.cbCreativeIdea.Size = new System.Drawing.Size(72, 16);
            this.cbCreativeIdea.TabIndex = 5;
            this.cbCreativeIdea.Tag = "1";
            this.cbCreativeIdea.Text = "创新点子";
            this.cbCreativeIdea.UseVisualStyleBackColor = true;
            // 
            // btnBrowseLog
            // 
            this.btnBrowseLog.Location = new System.Drawing.Point(168, 225);
            this.btnBrowseLog.Name = "btnBrowseLog";
            this.btnBrowseLog.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLog.TabIndex = 10;
            this.btnBrowseLog.Text = "查看记录";
            this.btnBrowseLog.UseVisualStyleBackColor = true;
            this.btnBrowseLog.Click += new System.EventHandler(this.btnBrowseLog_Click);
            // 
            // FrmAwd_Pun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 282);
            this.Controls.Add(this.btnBrowseLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.pnlAwd_Pun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAwd_Pun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "奖惩记录";
            this.Load += new System.EventHandler(this.FrmAwd_Pun_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlAwd_Pun.ResumeLayout(false);
            this.pnlAwd_Pun.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sslblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlAwd_Pun;
        private System.Windows.Forms.CheckBox cbAbsenceWithoutAsk;
        private System.Windows.Forms.CheckBox cbContribution;
        private System.Windows.Forms.CheckBox cbCreativeIdea;
        private System.Windows.Forms.Button btnBrowseLog;
    }
}