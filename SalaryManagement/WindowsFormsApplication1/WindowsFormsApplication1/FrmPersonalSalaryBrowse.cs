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
    public partial class FrmPersonalSalaryBrowse : Form
    {
        int Eno = 0;
        int B_eno = 0; //老总的员工编号
        int frmtype = 0;  //0为个人查询，1为老总查询
        int level = 0; // 按年0还是按月1
        public FrmPersonalSalaryBrowse(int p_eno, int p_frmtype, int p_level)
        {
            if (p_frmtype == 1)
            {
                B_eno = p_eno;
            }
            else
            {
                Eno = p_eno;
            }
            frmtype = p_frmtype;
            level = p_level;
            InitializeComponent();
        }

        private void FrmPersonalSalaryBrowse_Load(object sender, EventArgs e)
        {
            if (frmtype == 0)//个人查询
            {
                pnlManagerOnly.Visible = false;
                if (level == 0)
                {
                    cmbMonth.Enabled = false;
                }
            }
            else //老板查询
            {
                pnlManagerOnly.Visible = true;
                this.btnBrowse.Visible = false;
                if (level == 0)
                {
                    cmbMonth.Enabled = false;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string time = "";
            string sql = "";
            string year = "";
            string month = "";

            if (level == 0)//按年
            {
                if (cmbYear.SelectedIndex == -1)
                {
                    dgvPersonalSalary.Columns.Clear();
                    MessageBox.Show("请选择时间！");
                    return;
                }
                else
                {
                    year = this.cmbYear.SelectedItem.ToString().Trim();
                    time += year;
                }
            }
            else
            {
                if (cmbMonth.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
                {
                    dgvPersonalSalary.Columns.Clear();
                    MessageBox.Show("请选择时间！");
                    return;
                }
                else
                {
                    year = this.cmbYear.SelectedItem.ToString().Trim();
                    month = this.cmbMonth.SelectedItem.ToString().Trim();
                    time = year + "-" + month;
                }

            }
            string sql_1 = String.Format("select count(*) from t_salary where eno='{0}' and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", Eno, time);
            int count_1 = (int)DAO.ExecuteScalar(sql_1);
            if (count_1 <= 0)
            {
                dgvPersonalSalary.Columns.Clear();
                MessageBox.Show("该时间没有数据！！");
                return;
            }
            else
            {
                sql = String.Format("select sum(LevelSalary) as 基本工资, SUM(OvertimeWork) as 加班工资, SUM(BenifitSum) as 补贴, SUM(AllowanceSum) as 津贴, SUM(Awd_PunSum) as 奖惩总额, SUM(AllSum) as 总工资 from t_salary where eno='{0}' and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", Eno, time);
                DataTable dt = DAO.GetTable(sql);
                InitialDataGridView(dgvPersonalSalary, dt);
            }


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

        private void btnBrowseEmployee_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            FrmPesonalSalaryBrowse_ChkEmp frm = new FrmPesonalSalaryBrowse_ChkEmp(user);
            frm.ShowDialog();
            Eno = user.Eno;
            txtEno.Text = Eno.ToString();
        }

        private void btnBoss_Browse_Click(object sender, EventArgs e)
        {
            string time = "";
            string sql = "";
            string year = "";
            string month = "";

            string sql_0 = String.Format("select count(*) from t_employee where eno ='{0}'", Eno);
            int count_0 = (int)DAO.ExecuteScalar(sql_0);
            if (count_0 <= 0)
            {
                dgvPersonalSalary.Columns.Clear();
                MessageBox.Show("请输入正确的编号！");
                return;
            }
            else
            {
                if (level == 0)//按年
                {
                    if (cmbYear.SelectedIndex == -1)
                    {
                        dgvPersonalSalary.Columns.Clear();
                        MessageBox.Show("请选择时间！");
                        return;
                    }
                    else
                    {
                        year = this.cmbYear.SelectedItem.ToString().Trim();
                        time += year;
                    }
                }
                else
                {
                    if (cmbMonth.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
                    {
                        dgvPersonalSalary.Columns.Clear();
                        MessageBox.Show("请选择时间！");
                        return;
                    }
                    else
                    {
                        year = this.cmbYear.SelectedItem.ToString().Trim();
                        month = this.cmbMonth.SelectedItem.ToString().Trim();
                        time = year + "-" + month;
                    }

                }
                string sql_1 = String.Format("select count(*) from t_salary where eno='{0}' and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", Eno, time);
                int count_1 = (int)DAO.ExecuteScalar(sql_1);
                if (count_1 <= 0)
                {
                    dgvPersonalSalary.Columns.Clear();
                    MessageBox.Show("该时间没有数据！！");
                    return;
                }
                else
                {
                    sql = String.Format("select sum(LevelSalary) as 基本工资, SUM(OvertimeWork) as 加班工资, SUM(BenifitSum) as 补贴, SUM(AllowanceSum) as 津贴, SUM(Awd_PunSum) as 奖惩总额, SUM(AllSum) as 总工资 from t_salary where eno='{0}' and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", Eno, time);
                    DataTable dt = DAO.GetTable(sql);
                    InitialDataGridView(dgvPersonalSalary, dt);
                }
            }
        }

    }
}
