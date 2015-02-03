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
    public partial class FrmAwd_Pun : Form
    {
        int Eno = 0;
        public FrmAwd_Pun()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            sslblTime.Text = dt.ToString();
        }

        private void FrmAwd_Pun_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (Tag != null)
            {
                this.txtNo.Text = Tag.ToString();
                txtNo.ReadOnly = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int count = 0;
            int allcount = 0;
            if (txtNo.Text == "" || txtNo.Text == "0")
            {
                MessageBox.Show("请输入编号！");
                return;
            }
            else
            {
                Eno = int.Parse(txtNo.Text.Trim());
                string time = DateTime.Now.ToString();
                string datetime = DateTime.Now.ToShortDateString();
                foreach (CheckBox cb in pnlAwd_Pun.Controls)
                {
                    if (cb.Checked == true)
                    {
                        int pw_no = int.Parse(cb.Tag.ToString().Trim());
                        string sql_0 = String.Format("select count(*)from t_Pun_Awar_Record where Eno='{0}' and CONVERT(varchar(20), PWTime, 120) like '{1}%' and PWNo='{2}'", Eno, datetime, pw_no);
                        int flag_0 = (int)DAO.ExecuteScalar(sql_0);
                        if (flag_0 == 0)
                        {
                            string sql = String.Format("insert into t_Pun_Awar_Record values('{0}','{1}','{2}')", Eno, time, pw_no);
                            int flag = DAO.ExecuteNonQuery(sql);
                            if (flag != 0)
                            {
                                count++;
                            }
                        }
                        else
                        {
                            MessageBox.Show("对不起，已有" + cb.Text.Trim() + "此奖惩记录!");
                        }
                        allcount++;
                    }
                }
            }

            if (count == allcount)
            {
                MessageBox.Show("插入成功！");
                return;
            }
            else if (count < allcount && count > 0)
            {
                MessageBox.Show("部分插入成功！");
                return;
            }
            else
            {
                MessageBox.Show("插入失败！");
                return;
            }
        }

        private void btnBrowseLog_Click(object sender, EventArgs e)
        {
            if (txtNo.Text == "" || txtNo.Text == "0")
            {
                MessageBox.Show("请输入编号！");
                return;
            }
            else
            {
                Eno = int.Parse(txtNo.Text.Trim());
                string datetime = DateTime.Now.ToShortDateString();
                datetime = datetime.Substring(0, 6);
                string sql = String.Format("select COUNT(*) from t_Pun_Awar_Record where Eno='{0}' and CONVERT(varchar(20), PWTime, 120) like '{1}%'", Eno, datetime);
                int count = (int)DAO.ExecuteScalar(sql);
                if (count > 0)
                {
                    FrmBrowseAwd_PunLog frm = new FrmBrowseAwd_PunLog(Eno);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("所选职工本月没有奖惩记录");
                }
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            FrmAwd_Pun_Browse frm = new FrmAwd_Pun_Browse(user);
            frm.ShowDialog();
            txtNo.Text = user.Eno.ToString();
        }
    }
}
