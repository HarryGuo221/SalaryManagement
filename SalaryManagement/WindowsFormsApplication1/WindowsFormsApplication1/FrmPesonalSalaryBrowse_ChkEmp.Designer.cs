namespace WindowsFormsApplication1
{
    partial class FrmPesonalSalaryBrowse_ChkEmp
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
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEno
            // 
            this.lblEno.AutoSize = true;
            this.lblEno.Location = new System.Drawing.Point(47, 29);
            this.lblEno.Name = "lblEno";
            this.lblEno.Size = new System.Drawing.Size(41, 12);
            this.lblEno.TabIndex = 0;
            this.lblEno.Text = "编号：";
            // 
            // txtEno
            // 
            this.txtEno.Location = new System.Drawing.Point(94, 26);
            this.txtEno.Name = "txtEno";
            this.txtEno.Size = new System.Drawing.Size(100, 21);
            this.txtEno.TabIndex = 1;
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(12, 65);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowTemplate.Height = 23;
            this.dgvEmp.Size = new System.Drawing.Size(321, 207);
            this.dgvEmp.TabIndex = 2;
            this.dgvEmp.SelectionChanged += new System.EventHandler(this.dgvEmp_SelectionChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(216, 24);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确 认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmPesonalSalaryBrowse_ChkEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 284);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.txtEno);
            this.Controls.Add(this.lblEno);
            this.Name = "FrmPesonalSalaryBrowse_ChkEmp";
            this.Text = "FrmPesonalSalaryBrowse_ChkEmp";
            this.Load += new System.EventHandler(this.FrmPesonalSalaryBrowse_ChkEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEno;
        private System.Windows.Forms.TextBox txtEno;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Button btnOK;
    }
}