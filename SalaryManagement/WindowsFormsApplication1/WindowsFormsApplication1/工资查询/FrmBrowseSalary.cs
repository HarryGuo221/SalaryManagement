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
    public partial class FrmBrowseSalary : Form
    {
        int authority = 0;
        int eno = 0;
        public FrmBrowseSalary(int p_authority, int p_eno)
        {
            authority = p_authority;
            eno = p_eno;
            InitializeComponent();
        }

        private void FrmBrowseSalary_Load(object sender, EventArgs e)
        {
            if (authority==0)
            {
                btnBrowse.Visible = true;
                toolStripStatusLabel1.Visible = false;
            }
            else
            {
                btnBrowse.Visible = false;
                txtEno.Text = eno.ToString();
                string datetime = DateTime.Now.ToShortDateString().Substring(0,7);
                string sql_0 = String.Format("select count(*) from t_salary where eno ='{0}' and CONVERT(varchar(20), entertime, 120) like '{1}%'", eno, datetime);
                int count_0 = (int)DAO.ExecuteScalar(sql_0);
                if (count_0 == 0)
                {
                    MessageBox.Show("没有本月工资记录！");
                    return;
                }
                else
                {
                    string sql_1 = String.Format("select * from t_salary where eno ='{0}' and CONVERT(varchar(20), entertime, 120) like '{1}%'", eno, datetime);
                    DataTable dt = DAO.GetTable(sql_1);
                    InitialDatagridview(dgvPersonalSalary, dt);
                }

            }
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (txtEno.Text=="")
            {
                MessageBox.Show("请输入编号！");
                return;
            }
            else
            {
                eno= int.Parse(txtEno.Text);
                string sql_0 = String.Format("select count(*) from t_salary where eno ='{0}'", eno);
                int count_0 = (int)DAO.ExecuteScalar(sql_0);
                if (count_0 ==0)
                {
                    MessageBox.Show("没有该员工工资信息！");

                    return;
                }
                else
                {
                    string sql_1 = String.Format("select a.Eno as 员工编号, b.EName as 姓名 ,LevelSalary as 基本工资, OvertimeWork as 加班工资, BenifitSum as 津贴总额, AllowanceSum as 补贴总额, Awd_PunSum as 奖惩总额, AllSum as 工资总额, EnterTime as 时间 from t_Salary a, t_Employee b where a.Eno=b.Eno and  a.Eno='{0}'", eno);
                    DataTable dt = DAO.GetTable(sql_1);
                    InitialDatagridview(dgvPersonalSalary, dt);
                }
            }
        }
    }
}
