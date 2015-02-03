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
    public partial class FrmBrowsePresentUser : Form
    {
        int Eno = 0;
        public FrmBrowsePresentUser(int eno)
        {
            Eno = eno;
            InitializeComponent();
        }

        private void FrmBrowsePresentUser_Load(object sender, EventArgs e)
        {
            string sql = String.Format("select a.Eno as 员工编号, c.DeptName as 部门, d.LevelName as 职位, EName as 姓名, EGender as 性别, EId as 身份证号码, ENationality as 民族, EPolitical as 政治面貌, ETel as 手机号, EEmail as 电子邮件地址, EAddress as 住址, EMarriage as 婚姻状况, EWorktime as 工龄, Eph as 工作电话, b.CategoryContent as 工资种类, Password as 密码, a.Authority as 权限 from t_Employee a, t_SalaryCategory b, t_Department c, t_SalaryRank d, t_Authority e  where  a.DeptNo = c.DeptNo and a.SalaryCategoryNo = b.SalaryCategoryNo and a.LevelNo = d.LevelNo and e.Authority = a.Authority and  Eno='{0}'", Eno);
            DataTable dt = new DataTable();
            dt = DAO.GetTable(sql);
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
