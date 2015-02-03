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
    public partial class FrmUserBasicInfo : Form
    {
        int Eno = 0;
        int formStatus = 0; //0为查看，-1为修改，1为增加，2为删除
        int Authority = 0;
        public FrmUserBasicInfo(int p_Eno, int p_auhority)
        {
            InitializeComponent();
            Eno = p_Eno;
            Authority = p_auhority;
        }

        //public int eno
        //{
        //    get { return Eno; }
        //    set { Eno = value; }
        //}

        private void FrmUserBasicInfo_Load(object sender, EventArgs e)
        {
            LoadData(Eno);
            ChangeControlsEnability(false, 0);
            this.btnCancel.Visible = false;
            this.btnOK.Visible = false;
        }

        public void LoadData(int Eno)
        {
            string[] info = new string[14];
            string sql = String.Format("select b.DeptName, c.LevelName, EName, EGender,EId,ENationality,EPolitical,ETel,EEmail,EAddress,EMarriage,EWorktime,Eph,[Password] from t_Employee a,t_Department b, t_SalaryRank c where Eno='{0}' and a.DeptNo=b.DeptNo and a.LevelNo= c.LevelNo", Eno);
            DataTable dt = DAO.GetTable(sql);
            for (int i = 0; i < 14; i++)
            {
                info[i] = dt.Rows[0][i].ToString();
            }

            txtName.Text = info[2];
            if (info[3] == "1")
            {
                rdobtnMale.Checked = true;
                rdobtnFemale.Checked = false;
            }
            else
            {
                rdobtnFemale.Checked = true;
                rdobtnMale.Checked = false;
            }
            txtSocialID.Text = info[4];
            txtNationality.Text = info[5];
            txtPolitic.Text = info[6];
            txtMobilePhone.Text = info[7];
            txtEmailAddress.Text = info[8];
            txtMarriageStatus.Text = info[10];
            txtAddress.Text = info[9];
            this.cbPosition.Text = info[1];
            this.cbDepartment.Text = info[0];
            txtWorkTime.Text = info[11];
            txtWorkPhoneNumber.Text = info[12];
            txtPassword.Text = info[13];
            txtNo.Text = Eno.ToString();
            this.cmbAuthority.Text = cmbAuthority.Items[Authority].ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b">设置enable的值</param>
        /// <param name="flag">0/1</param>
        private void ChangeControlsEnability(Boolean b, int flag)//(0表示新增，需要输入编号；1表示修改，不需要输入编号)
        {
            foreach (Control c in gpbEssentialInfo.Controls)
            {
                if (c is TextBox)
                {
                    TextBox tb = new TextBox();
                    tb = (TextBox)c;
                    int tag = int.Parse(tb.Tag.ToString());
                    if (tag >= flag)
                    {
                        c.Enabled = b;
                    }
                    else
                    {
                        c.Enabled = !b;
                    }
                }
                else if (c is RadioButton)
                {
                    c.Enabled = b;
                }
            }

            foreach (Control item in gpbCompanyInfo.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = new TextBox();
                    tb = (TextBox)item;
                    int tag = int.Parse(tb.Tag.ToString());
                    if (tag >= flag)
                    {
                        item.Enabled = b;
                    }
                    else
                    {
                        item.Enabled = !b;
                    }
                }
                else if (item is ComboBox)
                {
                    item.Enabled = b;
                }
            }
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            ChangeControlsEnability(true, 0);
            this.btnCancel.Visible = true;
            this.btnOK.Visible = true;
            foreach (Control c in gpbEssentialInfo.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
            }
            foreach (Control c in gpbCompanyInfo.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
            }
            rdobtnMale.Checked = true;
            rdobtnFemale.Checked = false;
        }

        private void 本人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData(Eno);
            ChangeControlsEnability(true, 1);
            this.btnCancel.Visible = true;
            this.btnOK.Visible = true;
        }

        private void 其他用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            FrmChangeUserInfo frm1 = new FrmChangeUserInfo(0, user);

            frm1.ShowDialog();
            this.txtNo.Text = user.Eno.ToString();
            ChangeControlsEnability(true, 1);
            LoadData(user.Eno);
            this.btnCancel.Visible = true;
            this.btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int deptno = 0;
            int levelno = 0;
            int salarycategoryno = 0;
            int gender = 0;
            //检查必填项
            if (this.txtNo.Text == "")
            {
                MessageBox.Show("请重新输入！");
                return;
            }
            else if (cbDepartment.SelectedIndex < 0 || cbPosition.SelectedIndex < 0 || cmbAuthority.SelectedIndex < 0)
            {
                MessageBox.Show("请重新输入！");
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("请重新输入！");
                return;
            }

            int p_eno = int.Parse(txtNo.Text.ToString());

            string sql_1 = String.Format("select DeptNo from t_Department where DeptName='{0}'", this.cbDepartment.Text.Trim());
            deptno = int.Parse(DAO.ExecuteScalar(sql_1).ToString());

            string sql_2 = String.Format("select LevelNo from t_SalaryRank where LevelName='{0}'", this.cbPosition.Text.Trim());
            levelno = int.Parse(DAO.ExecuteScalar(sql_2).ToString());

            string sql_5 = String.Format("select SalaryCategoryNo from t_SalaryCategory where Position='{0}'", this.cbPosition.Text);
            salarycategoryno = int.Parse(DAO.ExecuteScalar(sql_5).ToString());

            if (this.rdobtnFemale.Checked == true)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }

            string sql = String.Format("select COUNT(*) from t_Employee where Eno='{0}'", p_eno);
            int count = (int)DAO.ExecuteScalar(sql);

            Eno = int.Parse(txtNo.Text);
            string name = txtName.Text.Trim();
            string eid = txtSocialID.Text.Trim();
            string nationality = txtNationality.Text;
            string politic = txtPolitic.Text;
            string etel = txtMobilePhone.Text;
            string email = txtEmailAddress.Text;
            string address = txtAddress.Text;
            string marriage = txtMarriageStatus.Text;
            int worktime = 0;
            string workphone = txtWorkPhoneNumber.Text;
            string password = txtPassword.Text;
            int authority = 0;
            authority = this.cmbAuthority.SelectedIndex;

            if (count == 0)  //新增
            {
                string sql_4 = String.Format("insert into t_Employee values('{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','(16)')", Eno, deptno, levelno, name, gender, eid, nationality, politic, etel, email, address, marriage, worktime, workphone,salarycategoryno, password, authority);
                int flag_4 = DAO.ExecuteNonQuery(sql_4);
                if (flag_4 != 0)
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
            else  //修改
            {
                string sql_3 = String.Format("update t_Employee set DeptNo='{0}', LevelNo='{1}', EName='{2}', EGender='{3}', EId='{4}', ENationality='{5}', EPolitical='{6}', ETel='{7}', EEmail='{8}', EAddress='{9}', EMarriage='{10}', Eph='{11}', EWorktime='{12}', [Password]='{13}', Authority='{14}',  SalaryCategoryNo='{15}' where Eno='{16}'", deptno, levelno, txtName.Text, gender, txtSocialID.Text, txtNationality.Text, txtPolitic.Text, txtMobilePhone.Text, txtEmailAddress.Text, txtAddress.Text, txtMarriageStatus.Text, txtWorkPhoneNumber.Text, txtWorkTime.Text, txtPassword.Text, authority,salarycategoryno , Eno);
                int flag = DAO.ExecuteNonQuery(sql_3);
                if (flag != 0)
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

        private void 当前用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定删除此用户？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                string sql_1 = String.Format("delete from t_CheckRecord where Eno='{0}'", Eno);
                int flag_1 = DAO.ExecuteNonQuery(sql_1);
                string sql_2 = String.Format("delete from [t_On/OffDutyRecord] where Eno='{0}'", Eno);
                int flag_2 = DAO.ExecuteNonQuery(sql_2);
                string sql_3 = String.Format("delete from t_Pun_Awar_Record where Eno='{0}'", Eno);
                int flag_3 = DAO.ExecuteNonQuery(sql_3);
                string sql_4 = String.Format("delete from t_Salary where Eno='{0}'", Eno);
                int flag_4 = DAO.ExecuteNonQuery(sql_4);
                string sql_5 = String.Format("delete from t_Employee where Eno='{0}'", Eno);
                int flag_5 = DAO.ExecuteNonQuery(sql_5);

                if (flag_1 != 0 && flag_2 != 0 && flag_3 != 0 && flag_4 != 0 && flag_5 != 0)
                {
                    MessageBox.Show("删除成功！");
                    return;
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

        private void 其他用户ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmChangeUserInfo frm = new FrmChangeUserInfo(1);
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
