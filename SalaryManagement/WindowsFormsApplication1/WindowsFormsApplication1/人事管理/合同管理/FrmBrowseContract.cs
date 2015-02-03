using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmBrowseContract : Form
    {
        int Cno = 0;
        clsUser user;
        public FrmBrowseContract(clsUser p_user)
        {
            user = p_user;
            InitializeComponent();
        }

        private void FrmBrowseContract_Load(object sender, EventArgs e)
        {
            string sql = "select * from t_ContractDetail";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(sql);
            InitializeDatagridview(dataGridView1, dt);
        }

        private void InitializeDatagridview(DataGridView dgv, DataTable dt)
        {
            dgv.Columns.Clear();

            dgv.DataSource = dt.DefaultView;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Cno = Convert.ToInt32(this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            user.Cno = Cno;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
