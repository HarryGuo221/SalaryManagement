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
    public partial class FrmPesonalSalaryBrowse_ChkEmp : Form
    {
        clsUser user;
        public FrmPesonalSalaryBrowse_ChkEmp(clsUser p_user)
        {
            user = p_user;
            InitializeComponent();
        }

        private void FrmPesonalSalaryBrowse_ChkEmp_Load(object sender, EventArgs e)
        {
            string sql = "select Eno as 员工编号, DeptName as 部门, LevelName as 职位, ename  as 姓名 from t_Employee a, t_Department b, t_SalaryRank c where a.DeptNo = b.DeptNo and a.LevelNo= c.LevelNo";
            DataTable dt = DAO.GetTable(sql);
            InitialDataGridView(dgvEmp, dt);
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

        private void dgvEmp_SelectionChanged(object sender, EventArgs e)
        {
            user.Eno = int.Parse(dgvEmp.CurrentRow.Cells[0].Value.ToString());
            txtEno.Text = dgvEmp.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
