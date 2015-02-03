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
    public partial class FrmAttendenceBrowse : Form
    {
        string datetime = null;
        string Ename = null;
        int Eno = 0;
        int type = 0;
        public FrmAttendenceBrowse(string p_datetime, string p_Ename, int p_Eno)
        {
            InitializeComponent();
            datetime = p_datetime;
            Ename = p_Ename;
            Eno = p_Eno;
        }

        private void FrmAttendenceBrowse_Load(object sender, EventArgs e)
        {
            this.txtName.Text = Ename;
            string sql = String.Format("select CheckNo as 考勤编号, OnWorkTime as 上班时间, OffWorkTime as 下班时间 from t_CheckRecord where CONVERT(varchar(20), OnWorkTime, 120) like '{0}%' and Eno = '{1}'", datetime, Eno);
            DataTable dt = DAO.GetTable(sql);

            InitialDataGridView(dataGridView1, dt);
        }

        public void InitialDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.Columns.Clear();

            dgv.DataSource = dt.DefaultView;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;//不允许最后一行出现空白
            dgv.ReadOnly = true;
        }

    }
}
