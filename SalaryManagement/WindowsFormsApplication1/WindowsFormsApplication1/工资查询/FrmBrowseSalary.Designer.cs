namespace WindowsFormsApplication1
{
    partial class FrmBrowseSalary
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
            this.dgvPersonalSalary = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalSalary)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEno
            // 
            this.lblEno.AutoSize = true;
            this.lblEno.Location = new System.Drawing.Point(47, 33);
            this.lblEno.Name = "lblEno";
            this.lblEno.Size = new System.Drawing.Size(41, 12);
            this.lblEno.TabIndex = 0;
            this.lblEno.Text = "编号：";
            // 
            // txtEno
            // 
            this.txtEno.Location = new System.Drawing.Point(94, 30);
            this.txtEno.Name = "txtEno";
            this.txtEno.Size = new System.Drawing.Size(100, 21);
            this.txtEno.TabIndex = 1;
            // 
            // dgvPersonalSalary
            // 
            this.dgvPersonalSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonalSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonalSalary.Location = new System.Drawing.Point(12, 69);
            this.dgvPersonalSalary.Name = "dgvPersonalSalary";
            this.dgvPersonalSalary.RowTemplate.Height = 23;
            this.dgvPersonalSalary.Size = new System.Drawing.Size(351, 177);
            this.dgvPersonalSalary.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(239, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "查 看";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(375, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(308, 17);
            this.toolStripStatusLabel1.Text = "只能查看当月工资条，若想查看更多信息，请联系管理员";
            // 
            // FrmBrowseSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 271);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.dgvPersonalSalary);
            this.Controls.Add(this.txtEno);
            this.Controls.Add(this.lblEno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBrowseSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看工资";
            this.Load += new System.EventHandler(this.FrmBrowseSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonalSalary)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEno;
        private System.Windows.Forms.TextBox txtEno;
        private System.Windows.Forms.DataGridView dgvPersonalSalary;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}