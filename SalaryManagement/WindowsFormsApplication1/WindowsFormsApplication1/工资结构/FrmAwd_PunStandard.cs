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
    public partial class FrmAwd_PunStandard : Form
    {
        int allcount = 0; //记录数据库中已有的数据条数
        int flag = 0; //判断修改或新增
        public FrmAwd_PunStandard()
        {
            InitializeComponent();
            string sql_0 = String.Format("select COUNT(*) from t_Pun_Awar_Standard");
            allcount = (int)DAO.ExecuteScalar(sql_0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int Awd_PunNo = int.Parse( this.txtAwd_PunNo.Text);
            if (Awd_PunNo > allcount)
            {   //新增
                string sql_1 = String.Format("insert into t_Pun_Awar_Standard values('{0}','{1}','{2}', '{3}')", Awd_PunNo, this.txtAwd_PunTitle.Text.Trim(), this.txtAwd_PunMoney, txtAwd_PunMemo.Text);
                int p_flag = DAO.ExecuteNonQuery(sql_1);
                if (p_flag != 0)
                {
                    MessageBox.Show("新增成功！");
                    return;
                }
                else
                {
                    MessageBox.Show("新增失败！");
                    return;
                }
            }
            else
            {
                string sql_1 = String.Format("update t_Pun_Awar_Standard set PWName='{0}', PWSum='{1}', PWMemo='{2}' where PWNo='{3}'", txtAwd_PunTitle.Text, txtAwd_PunMoney.Text, txtAwd_PunMemo.Text, Awd_PunNo);
                int p_flag = DAO.ExecuteNonQuery(sql_1);
                if (p_flag !=0)
                {
                    MessageBox.Show("修改成功！");
                    return;
                }
                else
                {
                    MessageBox.Show("修改失败！");
                    return;
                }
            }
            
        }

        private void txtAwd_PunNo_TextChanged(object sender, EventArgs e)
        {
            int Awd_PunNo = 0;
            Awd_PunNo = int.Parse( this.txtAwd_PunNo.Text.Trim());
            string sql_0 = String.Format("select * from t_Pun_Awar_Standard where PWNo = '{0}'",Awd_PunNo);
            DataTable dt = DAO.GetTable(sql_0);
            if (dt!=null)
            {
                string title = dt.Rows[0][1].ToString();
                string money = dt.Rows[0][2].ToString();

                this.txtAwd_PunTitle.Text = title;
                this.txtAwd_PunMoney.Text = money;
            }

        }

        private void FrmAwd_PunStandard_Load(object sender, EventArgs e)
        {
            this.lblHeadsUp.Text += allcount+1;
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
