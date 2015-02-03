namespace WindowsFormsApplication1
{
    partial class FrmAllSumSalary
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
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dgvDepartmentSalary = new System.Windows.Forms.DataGridView();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnAlterSum = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentSalary)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(44, 23);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 12);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "部门：";
            // 
            // dgvDepartmentSalary
            // 
            this.dgvDepartmentSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentSalary.Location = new System.Drawing.Point(12, 52);
            this.dgvDepartmentSalary.Name = "dgvDepartmentSalary";
            this.dgvDepartmentSalary.RowTemplate.Height = 23;
            this.dgvDepartmentSalary.Size = new System.Drawing.Size(260, 150);
            this.dgvDepartmentSalary.TabIndex = 2;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "人事部",
            "市场部",
            "财务部"});
            this.cmbDepartment.Location = new System.Drawing.Point(91, 20);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 20);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(19, 220);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(41, 12);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "总计：";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(66, 215);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 21);
            this.txtSum.TabIndex = 5;
            // 
            // btnAlterSum
            // 
            this.btnAlterSum.Location = new System.Drawing.Point(181, 215);
            this.btnAlterSum.Name = "btnAlterSum";
            this.btnAlterSum.Size = new System.Drawing.Size(75, 23);
            this.btnAlterSum.TabIndex = 6;
            this.btnAlterSum.Text = "更 改";
            this.btnAlterSum.UseVisualStyleBackColor = true;
            this.btnAlterSum.Click += new System.EventHandler(this.btnAlterSum_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(46, 283);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 283);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sslblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "今日日期：";
            // 
            // sslblTime
            // 
            this.sslblTime.Name = "sslblTime";
            this.sslblTime.Size = new System.Drawing.Size(131, 17);
            this.sslblTime.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAllSumSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAlterSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.dgvDepartmentSalary);
            this.Controls.Add(this.lblDepartment);
            this.Name = "FrmAllSumSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门汇总工资";
            this.Load += new System.EventHandler(this.FrmAllSumSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentSalary)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.DataGridView dgvDepartmentSalary;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnAlterSum;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sslblTime;
        private System.Windows.Forms.Timer timer1;
    }
}