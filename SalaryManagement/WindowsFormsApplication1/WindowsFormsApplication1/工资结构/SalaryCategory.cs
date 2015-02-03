using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions; //新知识点Regex

namespace WindowsFormsApplication1
{
    public partial class SalaryCategory : Form
    {
        public SalaryCategory()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string categorycontent = null;
            string position = null;
            position = this.comboBox1.Text.Trim();

            foreach (CheckBox cb in pnlCheckBox.Controls)
            {
                if (cb.Checked == true)
                {
                    categorycontent += cb.Tag.ToString() + "+";
                }
            }
            categorycontent = categorycontent.Remove(categorycontent.Length - 1, 1);
            //检查是否有相同职位的工资标准存在
            string sql_0 = String.Format("select count(*) from t_SalaryCategory where position='{0}'", position);
            int count_0 = (int)DAO.ExecuteScalar(sql_0);
            if (count_0 == 1)
            {
                DialogResult dr = MessageBox.Show("已有数据，是否修改？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql_2 = String.Format("update t_SalaryCategory set CategoryContent='{0}' where position='{1}'", categorycontent.Trim(), position);
                    int flag = DAO.ExecuteNonQuery(sql_2);

                    if (flag == 1)
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
            else//没有当下用户选择的职位的工资标准
            {
                string sql_2 = String.Format("insert into t_SalaryCategory values('{0}', '{1}')", categorycontent.Trim(), position);
                int flag = DAO.ExecuteNonQuery(sql_2);
                if (flag == -1)
                {
                    MessageBox.Show("插入成功！");
                }
                else
                {
                    MessageBox.Show("插入失败！");
                }
                return;
            }

        }

        private void cbSalary_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ob = new CheckBox();
            ob = (CheckBox)sender;
            if (ob.CheckState == CheckState.Checked && ExistText(ob.Text)<0)
            {
                this.listBox1.Items.Add(ob.Text);
            }
            else if (ob.CheckState == CheckState.Unchecked && ExistText(ob.Text)>=0)
            {
                this.listBox1.Items.Remove(ob.Text);
            }
        }

        private int ExistText( string text)
        {
            int index = this.listBox1.Items.IndexOf(text);
            return index;
            //新知识
            //string allText = txtSum.Text;
            //Regex reg = new Regex(text, RegexOptions.Multiline | RegexOptions.IgnoreCase);
            //if (reg.IsMatch(allText))
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
