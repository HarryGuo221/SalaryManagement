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
    public partial class FrmChangePosition : Form
    {
        int Eno = 0;
        string Ename = "";
        int deptno = 0;
        int levelno = 0;
        public FrmChangePosition()
        {
            InitializeComponent();
        }

        private void FrmChangePosition_Load(object sender, EventArgs e)
        {
            this.cmbDept.Enabled = false;
            this.cmbPosition.Enabled = false;
        }

        private void btnLoadByNo_Click(object sender, EventArgs e)
        {
            if (txtNo.Text == "")
            {
                MessageBox.Show("请输入编号！");
                return;
            }
            else
            {
                Eno = int.Parse(txtNo.Text);
                string sql_0 = String.Format("select count(*) from t_employee where eno='{0}'", Eno);
                int count_0 = (int)DAO.ExecuteScalar(sql_0);
                if (count_0<=0)
                {
                    MessageBox.Show("请输入正确的编号！");
                    return;
                }
                else
                {
                    string sql = String.Format("select EName, DeptNo, LevelNo from t_Employee where Eno='{0}'", Eno);
                    DataTable dt = DAO.GetTable(sql);
                    txtName.Text = dt.Rows[0][0].ToString();
                    cmbDept.SelectedIndex = int.Parse(dt.Rows[0][1].ToString()) - 1;
                    cmbPosition.SelectedIndex = int.Parse(dt.Rows[0][2].ToString()) - 1;

                    btnLoadByName.Visible = false;
                    this.cmbDept.Enabled = true;
                    this.cmbPosition.Enabled = true;
                }
            }
        }

        private void btnLoadByName_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                MessageBox.Show("请输入姓名！");
                return;
            }
            else
            {
                int count = 0;
                Ename = txtName.Text.Trim();
                string sql_0 = String.Format("select count(*) from t_employee where ename='{0}'", txtName.Text.Trim());
                count = (int)DAO.ExecuteScalar(sql_0);
                
                if (count>0)
                {
                    if (count>1)
                    {
                        MessageBox.Show("有多个数据，请输入编号！");
                        btnLoadByName.Visible = false;
                        return;
                    }
                    else if(count==1)
                    {
                        string sql_1 = String.Format("select eno, DeptNo, LevelNo from t_Employee where EName='{0}'", Ename);
                        DataTable dt = DAO.GetTable(sql_1);
                        txtNo.Text = dt.Rows[0][0].ToString();
                        cmbDept.SelectedIndex = int.Parse(dt.Rows[0][1].ToString()) - 1;
                        cmbPosition.SelectedIndex = int.Parse(dt.Rows[0][2].ToString()) - 1;

                        btnLoadByNo.Visible = false;
                        this.cmbDept.Enabled = true;
                        this.cmbPosition.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("数据有误！！");
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            deptno = cmbDept.SelectedIndex+1;
            levelno = cmbPosition.SelectedIndex+1;
            string sql = String.Format("update t_Employee set DeptNo='{0}', LevelNo='{1}' where Eno='{2}'",deptno ,levelno , Eno);
            int flag = DAO.ExecuteNonQuery(sql);
            if (flag!=0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
                return;
            }
        }
    }
}
