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
    public partial class FrmCheckAttendenceLog : Form
    {
        int Eno = 0;
        int type = 0;//0为查看出勤记录  1为查看员工表(修改工资条)  2为删除工资条
        int Ono = 0;//操作员编号
        clsUser user;
        public FrmCheckAttendenceLog(int p_eno, int p_type)
        {
            Eno = p_eno;
            type = p_type;
            
            InitializeComponent();
        }

        public FrmCheckAttendenceLog(int p_eno, int p_type, int p_ono, clsUser p_user)
        {
            Eno = p_eno;
            type = p_type;
            Ono = p_ono;
            user = p_user;
            InitializeComponent();
        }

        private void FrmCheckAttendenceLog_Load(object sender, EventArgs e)
        {
            if (type == 1)//修改工资表
            {
                string sql_1 = "select * from t_Employee";
                DataTable dt = new DataTable();
                dt = DAO.GetTable(sql_1);
                InitialDatagridview(this.dataGridView1, dt);
            }
            else if (type == 0)//查看出勤记录
            {
                btnOK.Visible = false;
                DateTime datetime = DateTime.Now;
                string time = datetime.ToShortDateString();
                string sql = String.Format("select * from t_CheckRecord where Eno='{0}' and CONVERT(varchar(20), OffWorkTime, 120) like '{1}%'", Eno, time);
                DataTable dt = new DataTable();
                dt = DAO.GetTable(sql);
                InitialDatagridview(this.dataGridView1, dt);
                this.textBox1.Text = Eno.ToString();
            }
            else//删除工资条
            {
                string sql_1 = String.Format("select * from t_salary where CONVERT(varchar(20), entertime, 120) like '{0}%'", DateTime.Now.ToString().Substring(0, 7));
                DataTable dt = new DataTable();
                dt = DAO.GetTable(sql_1);
                InitialDatagridview(this.dataGridView1, dt);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (type == 1)//修改工资条
            {
                int eno = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
               user.Eno = eno;
                this.Close();
            }
            else if (type == 2)//删除工资条
            {
                if (textBox1.Text =="")
                {
                    MessageBox.Show("没有编号供删除！");
                    return;
                }
                else
                {
                    DialogResult dr = MessageBox.Show("确定删除！！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr==DialogResult.Yes)
                    {
                        int eno = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString());
                        string datetime = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
                        string sql = String.Format("delete from t_Salary where SalaryNo='{0}'", textBox1.Text);
                        int flag = DAO.ExecuteNonQuery(sql);
                        if (flag != 0)
                        {
                            MessageBox.Show("删除成功！");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                int rowindex = dgv.CurrentRow.Index;
                this.textBox1.Text = dgv.Rows[rowindex].Cells[0].Value.ToString();
            }
        }

    }
}
