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
    public partial class FrmAttendenceRecord : Form
    {
        int Eno = 0;
        public FrmAttendenceRecord(int p_Eno)
        {
            InitializeComponent();
            Eno = p_Eno;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.lblTime.Text = dt.ToString();
        }

        private void FrmAttendenceRecord_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            string sql_0 = String.Format("select EName from t_Employee where Eno = '{0}'", Eno);
            this.sslblName.Text = DAO.ExecuteScalar(sql_0).ToString();
        }

        private void btnCheckin_Click(object sender, EventArgs e)//签到
        {
            DateTime datetime = DateTime.Now;
            string time = datetime.ToShortDateString();
            string sql_0 = String.Format("select COUNT(*) from t_CheckRecord where Eno='{0}' and CONVERT(varchar(20), OnWorkTime, 120) like '{1}%'", Eno, time);
            int flag_0 = (int)DAO.ExecuteScalar(sql_0);
            if (flag_0 == 0)
            {
                string sql_1 = String.Format("insert into t_CheckRecord values('{0}', '{1}', '{2}', '{3}')", Eno, this.lblTime.Text, null, null);//签到时还没有下班时间和加班时长
                int flag_1 = DAO.ExecuteNonQuery(sql_1);
                if (flag_1 != 0)
                {
                    MessageBox.Show("签到成功！");
                    return;
                }
                else
                {
                    MessageBox.Show("签到失败，请重试！");
                    return;
                }
            }
            else
            {
                MessageBox.Show("你今日已经签到，请认真上班！");
                return;
            }

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string TodayTime = this.lblTime.Text.Trim();
            string TodayDateTime = TodayTime.Remove(10, TodayTime.Length - 10);

            string sql_2 = String.Format("select COUNT(*) from t_CheckRecord where CONVERT(varchar(20), OnWorkTime, 120) like '{0}%' and eno ='{1}'", TodayDateTime, Eno);
            int count_2 = (int)DAO.ExecuteScalar(sql_2);
            if (count_2 == 1)
            {
                string sql_3 = String.Format("select OnWorkTime from t_CheckRecord where CONVERT(varchar(20), OnWorkTime, 120) like '{0}%' and eno ='{1}'", TodayDateTime, Eno);
                DateTime CheckinTime = (DateTime)DAO.ExecuteScalar(sql_3);
                DateTime offWorkTime = DateTime.Parse(TodayTime);
                TimeSpan ts = offWorkTime.Subtract(CheckinTime);

                string time = TodayTime.ToString();
                string sql_1 = String.Format("select count(*) from t_CheckRecord where CONVERT(varchar(20), OffWorkTime, 120) like '{0}%' and eno ='{1}'", time, Eno);
                int flag_1 = (int)DAO.ExecuteScalar(sql_1);
                if (flag_1 == 0)
                {
                    int hours = int.Parse(ts.Hours.ToString());
                    string sql_4 = String.Format("update t_CheckRecord set OffWorkTime = '{0}', worktime='{1}' where eno='{2}' and CONVERT(varchar(20), OnWorkTime, 120) like '{3}%'", TodayTime, hours, Eno, TodayDateTime);
                    int flag_4 = DAO.ExecuteNonQuery(sql_4);
                    if (flag_4 != 0)
                    {
                        MessageBox.Show("签离成功！");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("签离失败，请重试！");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("你有多个签离记录，请与人事部联系！");
                    return;
                }

            }
            else if (count_2 == 0)
            {
                MessageBox.Show("对不起，今天没有你的签到记录！请与人事部联系");
                return;
            }
            else if (count_2 > 1)
            {
                MessageBox.Show("今天有多个签到记录，请与人事部联系");
                return;
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string datetime = this.lblTime.Text.Trim();
            datetime = datetime.Remove(8, datetime.Length - 8);
            string sql_0 = String.Format("select count(*) from t_checkrecord where eno='{0}'", Eno);
            int count_0 = (int)DAO.ExecuteScalar(sql_0);
            if (count_0<=0)
            {
                MessageBox.Show("没有出勤记录！");
                return;
            }
            else
            {
                FrmAttendenceBrowse frm_1 = new FrmAttendenceBrowse(datetime, this.sslblName.Text.Trim(), Eno);
                frm_1.ShowDialog();
            }


        }
    }
}