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
    
    public partial class FrmLogin : Form
    {
        private int Authority = 0;
        public int Eno = 0;
        public int Password = 0;
        clsUser user;
        public FrmLogin(clsUser p_user)
        {
            InitializeComponent();
            user = p_user;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Eno = int.Parse(this.txtEno.Text.ToString().Trim());
            Password = int.Parse(this.txtPwd.Text.ToString().Trim());
            string sql = String.Format("select count(*) from dbo.t_Employee where ENo='{0}' and password='{1}'", Eno, Password);
            Authority = comboBox1.SelectedIndex;
            int flag = (int)DAO.ExecuteScalar(sql);
            if (flag == 1)
            {
                this.DialogResult = DialogResult.OK;
                user.Eno = Eno;
                user.Authority = Authority;
            }
            else
            {
                MessageBox.Show("用户信息错误！！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("确定退出？", "退出警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ChangeAuthority();
        }

        private void txtEno_Leave(object sender, EventArgs e)
        {
            ChangeAuthority();
        }

        public void ChangeAuthority()
        {
            if (txtEno.Text!="")
            {
                string sql = String.Format("select Authority from t_Employee where Eno='{0}'", txtEno.Text.Trim());
                Authority = (int)DAO.ExecuteScalar(sql);

                this.comboBox1.Text = comboBox1.Items[Authority].ToString();
                if (Authority > 0)
                {
                    this.comboBox1.Enabled = false;
                }
            }
        }
    }
}
