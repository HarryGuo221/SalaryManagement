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
    public partial class FrmCompanySalaryBrowse : Form
    {
        int frmtype = 0;
        public FrmCompanySalaryBrowse(int p_frmtype)
        {
            frmtype = p_frmtype;
            InitializeComponent();
        }

        private void FrmCompanySalaryBrowse_Load(object sender, EventArgs e)
        {
            if (frmtype ==0)
            {
                cmbYear.Enabled = true;
                this.cmbMonth.Enabled = false;
            }
            else
            {
                cmbMonth.Enabled = true;
                cmbYear.Enabled = true;
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    //c.Text = c.Text.ToString("C2");
                }
            }





            string time = "";
            if (frmtype == 0)//按年查询
            {
                if (cmbYear.SelectedIndex == -1)
                {
                    MessageBox.Show("请选择时间！");
                    return;
                }
                else
                {
                    time = cmbYear.SelectedItem.ToString().Trim();
                    LoadData(time, gpbRS_Department);
                    LoadData(time, gpbSC_Department);
                    LoadData(time, gpbCW_Department);
                    SumAll(time);
                }
            }
            else//按月查询
            {
                if (cmbYear.SelectedIndex == -1 || cmbMonth.SelectedIndex ==-1)
                {
                    MessageBox.Show("请选择时间！");
                    return;
                }
                else
                {
                    time = cmbYear.SelectedItem.ToString().Trim()+"-"+cmbMonth.SelectedItem.ToString().Trim();
                    LoadData(time, gpbRS_Department);
                    LoadData(time, gpbSC_Department);
                    LoadData(time, gpbCW_Department);
                    SumAll(time);
                }
            }


        }

        private void SumAll(string time)
        {
            string sql = String.Format("select sum(LevelSalary) as 基本工资, SUM(OvertimeWork) as 加班工资, SUM(BenifitSum) as 补贴, SUM(AllowanceSum) as 津贴, SUM(Awd_PunSum) as 奖惩总额, SUM(AllSum) as 总工资 from t_Salary a where CONVERT(varchar(20), EnterTime, 120) like '{0}%'", time);
            DataTable dt = DAO.GetTable(sql);
            DataRow dr = dt.Rows[0];
            string[] s = new string[6];
            for (int i = 0; i < 6; i++)
            {
                s[i] = dr[i].ToString();
            }

            this.txtAll_BasicSum.Text = s[0];
            txtAll_OverWork.Text = s[1];
            txtAll_Benifit.Text = s[2];
            txtAll_Allwance.Text = s[3];
            txtAll_Awd_Pun.Text = s[4];
            txtAll_Allsum.Text = s[5];

            foreach (Control c in gpbAllSum.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text=="")
                    {
                        c.Text = "0";
                    }
                }
            }
        }


        private void LoadData(string time, GroupBox gpb)
        {
            int deptno = int.Parse(gpb.Tag.ToString());
            string[] salary = new string[6];
            string sql_1 = String.Format("select sum(LevelSalary) as 基本工资, SUM(OvertimeWork) as 加班工资, SUM(BenifitSum) as 补贴, SUM(AllowanceSum) as 津贴, SUM(Awd_PunSum) as 奖惩总额, SUM(AllSum) as 总工资 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo='{1}'", time, deptno);
            DataTable dt_1 = DAO.GetTable(sql_1);
            DataRow dr_1 = dt_1.Rows[0];
            for (int i = 0; i < 6; i++)
            {
                salary[i] = dr_1[i].ToString();
            }
            if (deptno==1)
            {
                this.txtRS_BasicSal.Text = salary[0];
                txtRS_OverWork.Text = salary[1];
                txtRS_Benifit.Text = salary[2];
                txtRS_Allwance.Text = salary[3];
                txtRS_Awd_Pun.Text = salary[4];
                txtRS_AllSum.Text = salary[5];
            }
            else if (deptno ==2)
            {
                txtSC_BasicSal.Text = salary[0];
                txtSC_OverWork.Text = salary[1];
                txtSC_Benifit.Text = salary[2];
                txtSC_Allwance.Text = salary[3];
                txtSC_Awd_Pun.Text = salary[4];
                txtSC_AllSum.Text = salary[5];
            }
            else
            {
                txtCW_BasicSal.Text = salary[0];
                txtCW_OverWork.Text = salary[1];
                txtCW_BasicSal.Text = salary[2];
                txtCW_Allwance.Text = salary[3];
                txtCW_Awd_Pun.Text = salary[4];
                txtCW_AllSum.Text = salary[5];
            }


            string sql_2 = String.Format("select a.Eno as 编号, b.EName as 姓名, LevelSalary as 基本工资, OvertimeWork as 加班工资, BenifitSum as 补贴, AllowanceSum as 津贴, Awd_PunSum as 奖惩总额, AllSum as 总工资 from t_Salary a, t_Employee b where a.Eno=b.Eno and CONVERT(varchar(20), EnterTime, 120) like '{0}%' and DeptNo='{1}'", time, deptno);
            DataTable dt_2 = DAO.GetTable(sql_2);
            foreach (Control c in gpb.Controls)
            {
                if (c is DataGridView)
                {
                    DataGridView dgv = (DataGridView)c;
                    InitialDataGridView(dgv, dt_2);
                }
            }

            foreach (Control c in gpb.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text =="")
                    {
                        c.Text = "0";
                    }
                }
            }
        }

        public void InitialDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.Columns.Clear();
            if (dt!=null)
            {
                dgv.DataSource = dt.DefaultView;
                dgv.AutoGenerateColumns = true;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.AllowUserToAddRows = false;//不允许最后一行出现空白
                dgv.ReadOnly = true;
                if (dt.Rows.Count != 0)
                {
                    int count = dgv.Columns.Count;
                    string p_type = "";
                    for (int i = 0; i < count; i++)
                    {
                        p_type = dgv.Columns[i].ValueType.Name.ToString();
                        if (p_type == "Decimal")
                        {
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                    }
                }
            }

        }


    }
}
