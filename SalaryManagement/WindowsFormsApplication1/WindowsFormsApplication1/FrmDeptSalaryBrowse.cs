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
    public partial class FrmDeptSalaryBrowse : Form
    {
        int Eno = 0;
        int B_eno = 0; //老总的员工编号
        int frmtype = 0;  //1为老总查询，其他则为部门查询
        int level = 0; // 按年0还是按月1
        int deptno = 0;
        public FrmDeptSalaryBrowse(int p_eno, int p_frmtype, int p_level)
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

        private void FrmDeptSalaryBrowse_Load(object sender, EventArgs e)
        {
            //判断是不是老总
            if (frmtype == 1)
            {//是老总
                pnlBossBrowse.Visible = true;
                btnBrowse.Visible = false;
            }
            else//不是老总
            {
                pnlBossBrowse.Visible = false;
                btnBrowse.Visible = true;
            }
            if (level == 1)//是以月查询
            {
                cmbYear.Enabled = true;
                cmbMonth.Enabled = true;
            }
            else//以年查询
            {
                cmbYear.Enabled = true;
                cmbMonth.Visible = false;
                lblMonth.Visible = false;
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
            if (dt.Rows.Count!=0)
            {
                int count = dgv.Columns.Count;
                string p_type = "";
                for (int i = 0; i < count; i++)
                {
                    p_type =dgv.Columns[i].ValueType.Name.ToString();
                    if (p_type=="Decimal")
                    {
                        dgv.Columns[i].DefaultCellStyle.Format = "C2";
                        dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string[] salary = new string[6];
            string time = "";
            string sql = String.Format("select deptno from t_employee where eno='{0}'", Eno);
            deptno = int.Parse(DAO.ExecuteScalar(sql).ToString());
            if (level == 0)//按年
            {
                if (cmbYear.SelectedIndex == -1)
                {
                    dataGridView1.Columns.Clear();
                    pnlDepartment.Visible = false;
                    MessageBox.Show("请选择时间！");
                    return;
                }
                else
                {
                    time = cmbYear.SelectedItem.ToString();
                    string sql_0 = String.Format("select COUNT(*) from t_Salary a, t_Employee b where a.Eno=b.Eno and DeptNo=(select DeptNo from t_Employee where Eno='{0}') and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", Eno, time);
                    int count_0 = (int)DAO.ExecuteScalar(sql_0);
                    if (count_0 <= 0)
                    {
                        dataGridView1.Columns.Clear();
                        MessageBox.Show("该时间没有数据！");
                        return;
                    }
                    else
                    {
                        string sql_1 = String.Format("select sum(LevelSalary) as 基本工资, SUM(OvertimeWork) as 加班工资, SUM(BenifitSum) as 补贴, SUM(AllowanceSum) as 津贴, SUM(Awd_PunSum) as 奖惩总额, SUM(AllSum) as 总工资 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo=(select DeptNo from t_Employee where Eno='{1}')", time, Eno);
                        DataTable dt = DAO.GetTable(sql_1);
                        DataRow dr = dt.Rows[0];
                        for (int i = 0; i < 6; i++)
                        {
                            salary[i] = dr[i].ToString();
                        }

                        txtBasicSal.Text = salary[0];
                        txtOverWork.Text = salary[1];
                        txtBenifit.Text = salary[2];
                        txtAllwance.Text = salary[3];
                        txtAwd_Pun.Text = salary[4];
                        txtAllSum.Text = salary[5];

                        string sql_2 = String.Format("select LevelSalary as 基本工资, OvertimeWork as 加班工资, BenifitSum as 补贴, AllowanceSum as 津贴, Awd_PunSum as 奖惩总额, AllSum as 总工资 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo=(select DeptNo from t_Employee where Eno='{1}')", time, Eno);
                        DataTable dt_2 = DAO.GetTable(sql_2);
                        InitialDataGridView(dataGridView1, dt_2);
                        pnlDepartment.Visible = true;
                        cmbDepartment.SelectedIndex = deptno - 1;
                    }
                }
            }
            else//按月
            {
                if (cmbYear.SelectedIndex == -1 && cmbMonth.SelectedIndex == -1)
                {
                    dataGridView1.Columns.Clear();
                    pnlDepartment.Visible = false;
                    MessageBox.Show("请选择时间！");
                    return;
                }
                else
                {
                    time = cmbYear.SelectedItem.ToString().Trim() + "-" + cmbMonth.SelectedItem.ToString().Trim();
                    string sql_0 = String.Format("select COUNT(*) from t_Salary a, t_Employee b where a.Eno=b.Eno and DeptNo=(select DeptNo from t_Employee where Eno='{0}') and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", Eno, time);
                    int count_0 = (int)DAO.ExecuteScalar(sql_0);
                    if (count_0 <= 0)
                    {
                        dataGridView1.Columns.Clear();
                        MessageBox.Show("该时间没有数据！");
                        return;
                    }
                    else
                    {
                        string sql_1 = String.Format("select sum(LevelSalary) as 基本工资, SUM(OvertimeWork) as 加班工资, SUM(BenifitSum) as 补贴, SUM(AllowanceSum) as 津贴, SUM(Awd_PunSum) as 奖惩总额, SUM(AllSum) as 总工资 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo=(select DeptNo from t_Employee where Eno='{1}')", time, Eno);
                        DataTable dt = DAO.GetTable(sql_1);
                        DataRow dr = dt.Rows[0];
                        for (int i = 0; i < 6; i++)
                        {
                            salary[i] = dr[i].ToString();
                        }

                        txtBasicSal.Text = salary[0];
                        txtOverWork.Text = salary[1];
                        txtBenifit.Text = salary[2];
                        txtAllwance.Text = salary[3];
                        txtAwd_Pun.Text = salary[4];
                        txtAllSum.Text = salary[5];

                        string sql_2 = String.Format("select LevelSalary as 基本工资, OvertimeWork as 加班工资, BenifitSum as 补贴, AllowanceSum as 津贴, Awd_PunSum as 奖惩总额, AllSum as 总工资 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo=(select DeptNo from t_Employee where Eno='{1}')", time, Eno);
                        DataTable dt_2 = DAO.GetTable(sql_2);
                        InitialDataGridView(dataGridView1, dt_2);
                        pnlDepartment.Visible = true;
                        cmbDepartment.SelectedIndex = deptno - 1;
                    }
                }
            }
        }

        private void btnBoss_Browse_Click(object sender, EventArgs e)
        {
            string[] salary = new string[6];
            string time = "";
            if (cmbDept.SelectedIndex == -1)
            {
                MessageBox.Show("请选择部门！");
                return;
            }
            else
            {
                deptno = cmbDept.SelectedIndex + 1;
                if (level == 0)//按年
                {
                    if (cmbYear.SelectedIndex == -1)
                    {
                        dataGridView1.Columns.Clear();
                        pnlDepartment.Visible = false;
                        MessageBox.Show("请选择时间！");
                        return;
                    }
                    else
                    {
                        time = cmbYear.SelectedItem.ToString();
                        string sql_0 = String.Format("select COUNT(*) from t_Salary a, t_Employee b where a.Eno=b.Eno and DeptNo='{0}' and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", deptno, time);
                        int count_0 = (int)DAO.ExecuteScalar(sql_0);
                        if (count_0 <= 0)
                        {
                            dataGridView1.Columns.Clear();
                            foreach (Control c in pnlSalarySum.Controls)
                            {
                                if (c is TextBox)
                                {
                                    c.Text = "";
                                }
                            }
                            MessageBox.Show("该时间没有数据！");
                            return;
                        }
                        else
                        {
                            string sql_1 = String.Format("select sum(LevelSalary) as 基本工资, SUM(OvertimeWork) as 加班工资, SUM(BenifitSum) as 补贴, SUM(AllowanceSum) as 津贴, SUM(Awd_PunSum) as 奖惩总额, SUM(AllSum) as 总工资 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo='{1}'", time, deptno);
                            DataTable dt = DAO.GetTable(sql_1);
                            DataRow dr = dt.Rows[0];
                            for (int i = 0; i < 6; i++)
                            {
                                salary[i] = dr[i].ToString();
                            }

                            txtBasicSal.Text = salary[0];
                            txtOverWork.Text = salary[1];
                            txtBenifit.Text = salary[2];
                            txtAllwance.Text = salary[3];
                            txtAwd_Pun.Text = salary[4];
                            txtAllSum.Text = salary[5];

                            string sql_2 = String.Format("select a.Eno as 员工编号, b.EName as 员工姓名,  LevelSalary as 基本工资, OvertimeWork as 加班工资, BenifitSum as 补贴, AllowanceSum as 津贴, Awd_PunSum as 奖惩总额, AllSum as 总工资, entertime as 时间 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo='{1}'", time, deptno);
                            DataTable dt_2 = DAO.GetTable(sql_2);
                            InitialDataGridView(dataGridView1, dt_2);
                        }
                    }
                }
                else//按月
                {
                    if (cmbYear.SelectedIndex == -1 && cmbMonth.SelectedIndex == -1)
                    {
                        dataGridView1.Columns.Clear();
                        pnlDepartment.Visible = false;
                        MessageBox.Show("请选择时间！");
                        return;
                    }
                    else
                    {
                        time = cmbYear.SelectedItem.ToString().Trim() + "-" + cmbMonth.SelectedItem.ToString().Trim();
                        string sql_0 = String.Format("select COUNT(*) from t_Salary a, t_Employee b where a.Eno=b.Eno and DeptNo='{0}' and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", deptno, time);
                        int count_0 = (int)DAO.ExecuteScalar(sql_0);
                        if (count_0 <= 0)
                        {
                            dataGridView1.Columns.Clear();
                            foreach (Control c in pnlSalarySum.Controls)
                            {
                                if (c is TextBox)
                                {
                                    c.Text = "";
                                }
                            }
                            MessageBox.Show("该时间没有数据！");
                            return;
                        }
                        else
                        {
                            string sql_1 = String.Format("select sum(LevelSalary) as 基本工资, SUM(OvertimeWork) as 加班工资, SUM(BenifitSum) as 补贴, SUM(AllowanceSum) as 津贴, SUM(Awd_PunSum) as 奖惩总额, SUM(AllSum) as 总工资 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo='{1}'", time, deptno);
                            DataTable dt = DAO.GetTable(sql_1);
                            DataRow dr = dt.Rows[0];
                            for (int i = 0; i < 6; i++)
                            {
                                salary[i] = dr[i].ToString();
                            }

                            txtBasicSal.Text = salary[0];
                            txtOverWork.Text = salary[1];
                            txtBenifit.Text = salary[2];
                            txtAllwance.Text = salary[3];
                            txtAwd_Pun.Text = salary[4];
                            txtAllSum.Text = salary[5];

                            string sql_2 = String.Format("select a.Eno as 员工编号, b.EName as 员工姓名,  LevelSalary as 基本工资, OvertimeWork as 加班工资, BenifitSum as 补贴, AllowanceSum as 津贴, Awd_PunSum as 奖惩总额, AllSum as 总工资, entertime as 时间 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo='{1}'", time, deptno);
                            DataTable dt_2 = DAO.GetTable(sql_2);
                            InitialDataGridView(dataGridView1, dt_2);
                        }
                    }
                }
            }
        }
    }
}
