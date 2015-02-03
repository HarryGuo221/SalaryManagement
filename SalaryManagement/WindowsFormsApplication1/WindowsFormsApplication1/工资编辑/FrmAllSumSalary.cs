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
    public partial class FrmAllSumSalary : Form
    {
        int SumInAll = 0;
        int dept = 0;
        string datetime = "";
        public FrmAllSumSalary()
        {
            InitializeComponent();
        }

        private void FrmAllSumSalary_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            txtSum.ReadOnly = true;
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

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            datetime = DateTime.Now.ToShortDateString();
            datetime = datetime.Substring(0,7);
            dept = cmbDepartment.SelectedIndex+1;
            DataTable dt= new DataTable();
            string sql_0 = String.Format("select COUNT(*) from t_Salary where CONVERT(varchar(20), EnterTime, 120) like '{0}%' and Eno in(select Eno from t_Employee where DeptNo='{1}')", datetime, dept);
            int count_0 = (int)DAO.ExecuteScalar(sql_0);
            if (count_0>0)
            {
                string sql = String.Format("select AllSum as 个人总工资, eno as 员工编号 from t_Salary where CONVERT(varchar(20), EnterTime, 120) like '{0}%' and Eno in(select Eno from t_Employee where DeptNo='{1}')", datetime, dept);
                dt = DAO.GetTable(sql);
                InitialDatagridview(dgvDepartmentSalary, dt);
                string sql_2 = String.Format("select SUM(AllSum) from t_Salary where CONVERT(varchar(20), EnterTime, 120) like '{0}%' and Eno in (select Eno from t_Employee where DeptNo='{1}')", datetime, dept);
                this.txtSum.Text = DAO.ExecuteScalar(sql_2).ToString();
                txtSum.ReadOnly = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.sslblTime.Text = dt.ToShortDateString();
        }

        private void btnAlterSum_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定修改？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                txtSum.ReadOnly = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sql = String.Format("insert into t_DaptAllSumSalary values('{0}','{1}','{2}')", dept, txtSum.Text, DateTime.Now.ToString());
            int flag = DAO.ExecuteNonQuery(sql);
            if (flag!=0)
            {
                MessageBox.Show("汇总成功！");
                return;
            }
            else
            {
                MessageBox.Show("汇总失败");
                return;
            }
        }
    }
}
