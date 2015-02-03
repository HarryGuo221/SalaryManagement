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
    public partial class FrmAddSalary : Form
    {
        //用户数据
        int OperatorNo = 0;
        int ENo = 0;//这里只为新增设置的 员工编号 参数
        int eno = 0;//这里是为修改设置的 员工编号 参数
        float allow_sum = 0;
        float benifit_sum = 0;
        float awd_sum = 0;
        float pun_sum = 0;
        float overtime_sum = 0;
        float basicsalary = 0;
        float allsum = 0;
        //窗口参数
        int Type = 0; //0为新增， 1为修改
        public FrmAddSalary(int p_no, int p_type)
        {
            OperatorNo = p_no;
            Type = p_type;
            InitializeComponent();
        }

        public FrmAddSalary(int p_no, int p_type, int p_eno)
        {
            OperatorNo = p_no;
            Type = p_type;
            eno = p_eno;
            InitializeComponent();
        }

        private void FrmAddSalary_Load(object sender, EventArgs e)
        {
            sslblOperatorNo.Text = OperatorNo.ToString();
            this.timer1.Enabled = true;
            
            if (Type == 0)
            {
                btnBrowse.Visible = false; 
                gpbBenifit.Enabled = false;
                gpbAwllance.Enabled = false;
                gpbAwd.Enabled = false;
                gpbPun.Enabled = false;
                btnBrowseAttendence.Enabled = false;
                btnBrowseAwd.Enabled = false;
                btnSumUp.Enabled = false;
            }
            else if(eno!=0)
            {
                txtNo.ReadOnly = true;
                txtNo.Text = eno.ToString();
                btnBrowse.Visible = true;
                button1.Visible = false;
            }
            else
            {
                btnBrowse.Visible = true;
                button1.Visible = false;
            }

        }

        private void cbAwll_SZ_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            cb = (CheckBox)sender;
            AlterDatainListbox(lstbAllwance, cb);
        }

        private void cbBenifit_GW_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            cb = (CheckBox)sender;
            AlterDatainListbox(lstbBenifit, cb);
        }

        private void cbAwd_Creative_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            cb = (CheckBox)sender;
            AlterDatainListbox(lstbAwd, cb);
        }

        public int ExistText(string text, ListBox lstbox)
        {
            int index = 0;
            index = lstbox.Items.IndexOf(text);
            return index;
        }

        public void AlterDatainListbox(ListBox lstbox, CheckBox cb)
        {
            int sum = 0;
            if (lstbox == lstbAllwance)
            {
                if (txtAllwanceSum.Text == null || txtAllwanceSum.Text == "")
                {
                    sum = 0;
                }
                else
                {
                    sum = int.Parse(txtAllwanceSum.Text.Trim());
                }
            }
            else if (lstbox == lstbBenifit)
            {
                if (txtBenifitSum.Text == null || txtBenifitSum.Text == "")
                {
                    sum = 0;
                }
                else
                {
                    sum = int.Parse(txtBenifitSum.Text.Trim());
                }
            }
            else if (lstbox == lstbAwd)
            {
                if (txtAwdSum.Text == null || txtAwdSum.Text == "")
                {
                    sum = 0;
                }
                else
                {
                    sum = int.Parse(txtAwdSum.Text.Trim());
                }
            }
            else if (lstbox == lstbPun)
            {
                if (txtPunSum.Text == null || txtPunSum.Text == "")
                {
                    sum = 0;
                }
                else
                {
                    sum = int.Parse(txtPunSum.Text.Trim());
                }
            }

            int add = int.Parse(cb.Tag.ToString());//需要加上的金额
            if (cb.CheckState == CheckState.Checked && ExistText(cb.Text, lstbox) < 0)
            {
                lstbox.Items.Add(cb.Text);
                sum += add;
            }
            else if (cb.CheckState == CheckState.Unchecked && ExistText(cb.Text, lstbox) >= 0)
            {
                lstbox.Items.Remove(cb.Text);
                if (sum == 0)
                {
                    return;
                }
                else
                {
                    sum -= add;
                }
            }

            if (lstbox == lstbAllwance)
            {
                txtAllwanceSum.Text = sum.ToString();
            }
            else if (lstbox == lstbBenifit)
            {
                txtBenifitSum.Text = sum.ToString();
            }
            else if (lstbox == lstbAwd)
            {
                txtAwdSum.Text = sum.ToString();
            }
            else if (lstbox == lstbPun)
            {
                txtPunSum.Text = sum.ToString();
            }
        }

        public void AlterDatainListbox_Special(ListBox lstbox, RadioButton rdo, GroupBox gpb)
        {
            int sum = 0;
            int add = 0;
            if (this.txtPunSum.Text == null || this.txtPunSum.Text == "")
            {
                sum = 0;
            }
            else
            {
                sum = int.Parse(txtPunSum.Text.Trim());
            }
            add = int.Parse(rdo.Tag.ToString());
            string text = gpb.Text;
            text += rdo.Text;
            if (rdo.Checked == true && ExistText(text, lstbox) < 0)
            {
                lstbox.Items.Add(text);
                sum += add;
            }
            else if (rdo.Checked == false && ExistText(text, lstbox) >= 0)
            {
                lstbox.Items.Remove(text);
                sum -= add;
            }

            txtPunSum.Text = sum.ToString();
        }

        private void DeleteMoreLeft(ListBox lstbox)
        {
            for (int i = 0; i < lstbox.Items.Count; i++)
            {
                for (int j = i + 1; j < lstbox.Items.Count; j++)
                {
                    if (lstbox.Items[i].Equals(lstbox.Items[j]))
                    {
                        lstbox.Items.Remove(lstbox.Items[j]);
                    }
                }
            }
        }

        private void rdoOnce_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rdo in gpbLateIn20_20.Controls)
            {
                AlterDatainListbox_Special(lstbPun, rdo, gpbLateIn20_20);
                DeleteMoreLeft(lstbPun);
            }
        }

        private void rdoOneTime_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton rdo in gpbLateOut20_50.Controls)
            {
                AlterDatainListbox_Special(lstbPun, rdo, gpbLateOut20_50);
                DeleteMoreLeft(lstbPun);
            }
        }

        private void cbPun_NoAskAbsence_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            cb = (CheckBox)sender;
            AlterDatainListbox(lstbPun, cb);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.sslblTime.Text = dt.ToString();
        }

        private void btnBrowseAttendence_Click(object sender, EventArgs e)
        {

            if (txtNo.Text == null || txtNo.Text == "")
            {
                MessageBox.Show("请重新选择员工！");
                return;
            }
            else
            {
                ENo = int.Parse(txtNo.Text.Trim());
                string sql = String.Format("select count(*) from t_CheckRecord where Eno='{0}' and CONVERT(varchar(20), OffWorkTime, 120) like '{1}%'", ENo, DateTime.Now.ToShortDateString().Substring(0, 7));
                int count = (int)DAO.ExecuteScalar(sql);
                if (count<=0)
                {
                    MessageBox.Show("本月没有职工考勤记录！");
                    return;
                }
                else
                {
                    FrmCheckAttendenceLog frm = new FrmCheckAttendenceLog(ENo, 0);
                    frm.ShowDialog();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            FrmCheckAttendenceLog frm = new FrmCheckAttendenceLog(ENo, 1, OperatorNo, user);
            frm.Owner = this;
            frm.ShowDialog();
            this.txtNo.Text = user.Eno.ToString();
        }

        private void btnSumUp_Click(object sender, EventArgs e)
        {
            if (txtNo.Text == null || txtNo.Text == "")
            {
                MessageBox.Show("请输入编号！！");
                return;
            }
            else
            {
                ENo = int.Parse(txtNo.Text.Trim());
                EverySum();

                string sql_0 = String.Format("select LevelSalary from t_Employee, t_SalaryRank where Eno='{0}' and t_Employee.LevelNo=t_SalaryRank.LevelNo", ENo);
                string salary = DAO.ExecuteScalar(sql_0).ToString();
                salary = salary.Substring(0, salary.IndexOf('.'));
                basicsalary = float.Parse(salary);
                
                string datetime = DateTime.Now.ToShortDateString();
                datetime = datetime.Substring(0, 7);
                //按月份查询
                string sql_1 = String.Format("select AVG(WorkTime) from t_CheckRecord where Eno='{0}' and CONVERT(varchar(20), OffWorkTime, 120) like '{1}%'", ENo, datetime);
                if (DAO.ExecuteScalar(sql_1).ToString() == "")
                {
                    overtime_sum = 0;
                }
                else
                {
                    float avgworktime = float.Parse(DAO.ExecuteScalar(sql_1).ToString());
                    if (avgworktime-9>=0)
                    {
                        overtime_sum = (avgworktime - 9) * 80;//加上中午一小时休息时间 =.=
                    }
                    else
                    {
                        overtime_sum = 0;
                    }
                }

                if (overtime_sum <=0)
                {
                    overtime_sum = 0;
                }
                float AllSum = basicsalary + allow_sum + benifit_sum + awd_sum + pun_sum+overtime_sum;

                this.txtAllSum.Text = AllSum.ToString();
            }
        }

        private void EverySum()
        {
            allow_sum = 0;
            if (txtAllwanceSum.Text == "")
            {
                allow_sum = 0;
            }
            else
                allow_sum = float.Parse(txtAllwanceSum.Text.Trim());

            benifit_sum = 0;
            if (txtBenifitSum.Text == "")
            {
                benifit_sum = 0;
            }
            else
                benifit_sum = float.Parse(txtBenifitSum.Text.Trim());

            awd_sum = 0;
            if (txtAwdSum.Text == "")
            {
                awd_sum = 0;
            }
            else
                awd_sum = float.Parse(txtAwdSum.Text.Trim());

            pun_sum = 0;
            if (txtPunSum.Text == "")
            {
                pun_sum = 0;
            }
            else
                pun_sum = float.Parse(txtPunSum.Text.Trim());
        }

        private void btnBrowseAwd_Click(object sender, EventArgs e)
        {
            if (txtNo.Text == null || txtNo.Text == "")
            {
                MessageBox.Show("请输入编号！！");
                return;
            }
            else
            {
                ENo = int.Parse(txtNo.Text);
                string datetime = DateTime.Now.ToShortDateString();
                datetime = datetime.Substring(0, 6);
                string sql = String.Format("select COUNT(*) from t_Pun_Awar_Record where Eno='{0}' and CONVERT(varchar(20), PWTime, 120) like '{1}%'", ENo, datetime);
                int count = (int)DAO.ExecuteScalar(sql);
                if (count > 0)
                {
                    FrmBrowseAwd_PunLog frm = new FrmBrowseAwd_PunLog(ENo);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("所选职工本月没有奖惩记录");
                }
            }

        }

        private void btnSubmitt_Click(object sender, EventArgs e)
        {
            ENo = int.Parse(this.txtNo.Text.Trim()) ;
            DateTime dt = DateTime.Now;
            if (this.txtNo.Text=="")
            {
                MessageBox.Show("请输入编号！");
                return;
            }
            else
            {
                string sql_1 = String.Format("select COUNT(*) from t_Salary where Eno='{0}' and CONVERT(varchar(20), EnterTime, 120) like '{1}%'", ENo, dt.ToString().Substring(0, 7));
                int count_1 = (int)DAO.ExecuteScalar(sql_1);
                allsum = int.Parse(txtAllSum.Text.ToString());
                if (Type == 0)//新增
                {
                    if (count_1 > 0)
                    {
                        MessageBox.Show("已有工资记录！");
                        return;
                    }
                    else
                    {
                        string sql = String.Format("insert into t_Salary values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", txtNo.Text.Trim(), basicsalary, overtime_sum, benifit_sum, allow_sum, awd_sum + pun_sum, allsum , dt.ToString());
                        int flag = DAO.ExecuteNonQuery(sql);
                        if (flag != 0)
                        {
                            MessageBox.Show("插入成功!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("插入失败！");
                            return;
                        }
                    }
                }
                else//修改
                {
                    if (count_1==0)
                    {
                        MessageBox.Show("此员工没有可供更改的工资条！");
                        return;
                    }
                    else
                    {
                        string sql = String.Format("update t_Salary set levelsalary='{0}',overtimework='{1}',benifitsum='{2}',allowancesum='{3}',awd_punsum'{4}' , allsum='{5}' where eno='{6}' and CONVERT(varchar(20), EnterTime, 120) like {7}%", basicsalary, overtime_sum, benifit_sum, allow_sum, awd_sum + pun_sum,allsum, txtNo.Text.Trim(), dt.ToString().Substring(0, 7));
                        int flag = DAO.ExecuteNonQuery(sql);
                        if (flag != 0)
                        {
                            MessageBox.Show("更新成功!");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("更新失败！");
                            return;
                        }
                    }
                }
            }

            
        }

        private void txtNo_Leave(object sender, EventArgs e)
        {
            if (Type==0)
            {
                if (this.txtNo.Text=="")
                {
                    MessageBox.Show("请输入编号！");
                    return;
                }
                else
                {
                    ENo = int.Parse(this.txtNo.Text.Trim());
                    string sql_0 = String.Format("select count(*) from t_Employee where Eno='{0}'", this.txtNo.Text.Trim());
                    int count_0 = (int)DAO.ExecuteScalar(sql_0);
                    if (count_0==0)
                    {
                        MessageBox.Show("没有对应员工信息，请重新输入编号！");
                        return;
                    }
                    else
                    {
                        string sql_1 = String.Format("select CategoryContent from t_Employee, t_SalaryCategory where t_Employee.SalaryCategoryNo = t_SalaryCategory.SalaryCategoryNo and Eno='{0}'", ENo);
                        string salarycategory = DAO.ExecuteScalar(sql_1).ToString();
                        int index = 0;
                        index=salarycategory.IndexOf('2');
                        if (index>0 && index<salarycategory.Length)
                        {
                            gpbAwllance.Enabled = true;
                        }
                        else
                        {
                            gpbAwllance.Enabled = false;
                        }
                        index = 0;
                        index = salarycategory.IndexOf('3');
                        if (index > 0 && index < salarycategory.Length)
                        {
                            gpbBenifit.Enabled = true;
                        }
                        else
                        {
                            gpbBenifit.Enabled = false;
                        }
                        index = 0;
                        index = salarycategory.IndexOf('5');
                        if (index > 0 && index < salarycategory.Length)
                        {
                            gpbAwd.Enabled = true;
                            gpbPun.Enabled = true;
                        }
                        else
                        {
                            gpbAwllance.Enabled = false;
                            gpbPun.Enabled = false;
                        }
                    }

                    btnBrowseAwd.Enabled = true;
                    btnBrowseAttendence.Enabled = true;
                    btnSumUp.Enabled = true;
                }
            }

        }

        private void txtAllwanceSum_TextChanged(object sender, EventArgs e)
        {
            txtAllSum.Text = "0";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
