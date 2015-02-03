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
    public partial class FrmChangeUserInfo : Form
    {
        int status = 0;
        int Eno = 0;
        clsUser user;
        public FrmChangeUserInfo(int p_status)
        {
            status = p_status;
            InitializeComponent();
        }

        public FrmChangeUserInfo(int p_status, clsUser p_user)
        {
            status = p_status;
            user = p_user;
            InitializeComponent();
        }

        private void FrmChangeUserInfo_Load(object sender, EventArgs e)
        {
            if (status == 0)
            {
                this.btnDelete.Text = "修 改";
            }
            else
            {
                this.btnDelete.Text = "删 除";
            }

            string sql = "select * from t_Employee";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(sql);
            InitialDataGridView(dataGridView1, dt);
        }

        public void InitialDataGridView(DataGridView dgv, DataTable dt)
        {
            dgv.Columns.Clear();

            dgv.DataSource = dt.DefaultView;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;//不允许最后一行出现空白
            dgv.ReadOnly = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                int rowindex = dgv.CurrentRow.Index;
                Eno = int.Parse(dgv.Rows[rowindex].Cells[0].Value.ToString());
                this.txtEno.Text = Eno.ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Eno = int.Parse(this.txtEno.Text.Trim());
            Button btn = new Button();
            btn = (Button)sender;
            if (btn.Text == "修 改")
            {
                user.Eno = Eno;
                this.Close();
            }
            else if (btn.Text == "删 除")
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
        }


    }
}
