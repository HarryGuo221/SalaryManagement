namespace WindowsFormsApplication1
{
    partial class FrmDeleteContracts
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
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtCno = new System.Windows.Forms.TextBox();
            this.lblCno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContract
            // 
            this.dgvContract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Location = new System.Drawing.Point(12, 63);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowTemplate.Height = 23;
            this.dgvContract.Size = new System.Drawing.Size(370, 175);
            this.dgvContract.TabIndex = 9;
            this.dgvContract.SelectionChanged += new System.EventHandler(this.dgvContract_SelectionChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(258, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(77, 244);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "删 除";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtCno
            // 
            this.txtCno.Location = new System.Drawing.Point(155, 27);
            this.txtCno.Name = "txtCno";
            this.txtCno.Size = new System.Drawing.Size(100, 21);
            this.txtCno.TabIndex = 6;
            // 
            // lblCno
            // 
            this.lblCno.AutoSize = true;
            this.lblCno.Location = new System.Drawing.Point(99, 30);
            this.lblCno.Name = "lblCno";
            this.lblCno.Size = new System.Drawing.Size(53, 12);
            this.lblCno.TabIndex = 5;
            this.lblCno.Text = "合同号：";
            // 
            // FrmDeleteContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 276);
            this.Controls.Add(this.dgvContract);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtCno);
            this.Controls.Add(this.lblCno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDeleteContracts";
            this.Text = "删除合同";
            this.Load += new System.EventHandler(this.FrmDeleteContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtCno;
        private System.Windows.Forms.Label lblCno;
    }
}