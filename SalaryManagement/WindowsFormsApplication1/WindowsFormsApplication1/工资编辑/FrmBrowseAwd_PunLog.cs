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
    public partial class FrmBrowseAwd_PunLog : Form
    {
        int Eno;
        public FrmBrowseAwd_PunLog(int p_Eno)
        {
            Eno = p_Eno;
            InitializeComponent();
        }

        private void FrmBrowseAwd_PunLog_Load(object sender, EventArgs e)
        {
            string sql = String.Format("select * from t_Pun_Awar_Record where Eno='{0}'", Eno);
            DataTable dt = new DataTable();
            dt=    DAO.GetTable(sql);
            InitialDataGridView(dataGridView1, dt);
        }

        public void InitialDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.Columns.Clear();

            dgv.DataSource = dt.DefaultView;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
        }
    }
}
