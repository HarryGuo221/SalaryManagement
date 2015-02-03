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
    public partial class FrmDeleteContracts : Form
    {
        int Cno = 0;
        public FrmDeleteContracts()
        {
            InitializeComponent();
        }

        private void FrmDeleteContracts_Load(object sender, EventArgs e)
        {
            string sql_1 = "select * from t_ContractDetail";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(sql_1);
            InitialDatagridview(dgvContract, dt);
        }

        private void InitialDatagridview(DataGridView dgv, DataTable dt)
        {
            dgv.Columns.Clear();

            dgv.DataSource = dt.DefaultView;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;//不允许最后一行出现空白
            dgv.ReadOnly = true;
        }

        private void dgvContract_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = new DataGridView();
            dgv = (DataGridView)sender;
            if (dgv.CurrentRow != null)
            {
                int rowindex = dgv.CurrentRow.Index;
                Cno = int.Parse(dgv.Rows[rowindex].Cells[0].Value.ToString());
                this.txtCno.Text = Cno.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCno.Text =="")
            {
                MessageBox.Show("请输入或选择合同号！");
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("确定删除！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    Cno = int.Parse(txtCno.Text);
                    string sql = String.Format("delete from t_ContractDetail where ContractNo='{0}'", Cno);
                    int flag = DAO.ExecuteNonQuery(sql);
                    if (flag != 0)
                    {
                        MessageBox.Show("删除成功！");
                        this.Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
