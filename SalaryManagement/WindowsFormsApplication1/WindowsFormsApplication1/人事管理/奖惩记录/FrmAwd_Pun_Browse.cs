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
    public partial class FrmAwd_Pun_Browse : Form
    {
        int eno = 0;
        clsUser user;
        public FrmAwd_Pun_Browse(clsUser p_user)
        {
            user = p_user;
            InitializeComponent();
        }

        private void FrmAwd_Pun_Browse_Load(object sender, EventArgs e)
        {
            string sql_1 = "select Eno as 员工编号, EName as 姓名, DeptName as 部门, LevelName as 职位 from t_Employee a, t_Department b, t_SalaryRank c where a.DeptNo=b.DeptNo and a.LevelNo = c.LevelNo";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(sql_1);
            InitialDatagridview(dgvEmployee, dt);
        }

        private void InitialDatagridview(DataGridView dgv, DataTable dt)
        {
            dgv.Columns.Clear();

            dgv.DataSource = dt.DefaultView;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;//不允许最后一行出现空白
            dgv.ReadOnly = true;
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                int rowindex = dgv.CurrentRow.Index;
                eno = int.Parse(dgv.Rows[rowindex].Cells[0].Value.ToString());
                this.txtEno.Text = eno.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEno.Text =="")
            {
                MessageBox.Show("请输入或选择编号！");
                return;
            }
            else
            {
                int select_eno = int.Parse(txtEno.Text.Trim());
                user.Eno = select_eno;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
