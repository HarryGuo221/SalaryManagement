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
    public partial class FrmOn_OffDuty : Form
    {
        int eno = 0;
        string type = "";
        string datetime = DateTime.Now.ToString();
        string reason = "";
        public FrmOn_OffDuty()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtEno.Text=="" || cmbOn_OffType.SelectedIndex<0 || txtReason.Text=="")
            {
                MessageBox.Show("请输入完全！");
                return;
            }
            else
            {
                eno = int.Parse(txtEno.Text);
                type = cmbOn_OffType.SelectedItem.ToString();
                reason  = txtReason.Text;
                datetime = DateTime.Now.ToString();
                string sql = String.Format("select count(*) from t_employee where eno='{0}'", eno);
                int count = (int)DAO.ExecuteScalar(sql);
                if (count<=0)
                {
                    MessageBox.Show("没有此员工信息");
                    return;
                }
                else
                {
                    string sql_1 = String.Format("insert into [t_On/OffDutyRecord] values('{0}','{1}','{2}','{3}')", eno, type, reason, datetime);
                    int flag_1 = DAO.ExecuteNonQuery(sql_1);
                    if (flag_1 !=0)
                    {
                        MessageBox.Show("添加成功！");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加失败！");
                        return;
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
