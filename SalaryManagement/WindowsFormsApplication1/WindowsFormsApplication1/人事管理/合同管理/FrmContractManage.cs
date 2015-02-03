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
    public partial class FrmContractManage : Form
    {
        int frmtype = 0;//0为增加，1为修改
        int contractypeno = 0;
        int eno = 0;
        int deptno = 0;
        string jobposition = "";
        string ename = "";
        int gender = 0; //0为女 1为男
        string eid = "";
        string etel = "";

        public FrmContractManage(int p_type)
        {
            InitializeComponent();
            frmtype = p_type;
        }

        private void FrmContractManage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (frmtype == 0)//新增
            {
                this.lblContractNo.Visible = false;
                this.txtContractNo.Visible = false;
                this.btnChooseContract.Visible = false;
                this.Text = "新增合同";
            }
            else
            {
                this.lblContractNo.Visible = true;
                this.txtContractNo.Visible = true;
                this.btnChooseContract.Visible = true;
                this.Text = "修改合同";
            }
        }
        /// <summary>
        /// 初始化表面数据
        /// </summary>
        /// <param name="eno"></param>
        /// <param name="cno"></param>
        private void InitializeData(int eno, int cno)
        {
            if (eno == 0)//没有编号
            {
                string sql_0 = String.Format("select count(*) from t_ContractDetail where ContractNo='{0}'", cno);
                int count_0 = (int)DAO.ExecuteScalar(sql_0);
                if (count_0 > 0)
                {
                    MessageBox.Show("数据不正确！");
                    return;
                }
                else 
                {
                    string sql_1 = String.Format("select * from t_ContractDetail where ContractNo='{0}'", cno);
                    DataTable dt = DAO.GetTable(sql_1);
                    string[] contract = new string[10];
                    for (int i = 0; i < 10; i++)
                    {
                        contract[i] = dt.Rows[0][i].ToString();
                    }
                    LoadData(contract);
                }
            }
            else
            {
                string sql_0 = String.Format("select count(*) from t_ContractDetail where Eno ='{0}' and ContractNo='{1}'", eno, cno);
                int count_0 = (int)DAO.ExecuteScalar(sql_0);
                if (count_0 > 0)
                {
                    MessageBox.Show("数据不正确！");
                    return;
                }
                else
                {
                    string sql_1 = String.Format("select * from t_ContractDetail where ContractNo='{0}' and Eno='{1}'", cno, eno);
                    DataTable dt = DAO.GetTable(sql_1);
                    string[] contract = new string[10];
                    for (int i = 0; i < 10; i++)
                    {
                        contract[i] = dt.Rows[0][i].ToString();
                    }
                    LoadData(contract);
                }
            }
        }
        /// <summary>
        /// 加载数据库数据
        /// </summary>
        /// <param name="contract"></param>
        private void LoadData(string[] contract)
        {
            int count =0;
            for (int i = 0; i < contract.Length; i++)
            {
                if (contract[i]=="")
                {
                    count++;
                }
            }
            if (count>0)
            {
                MessageBox.Show("数据不完整！");
                return;
            }
            else
            {
                txtContractNo.Text = contract[0];
                cmbContractType.SelectedIndex = int.Parse(contract[1])-1;
                txtEno.Text = contract[2];
                cmbDepartment.SelectedIndex = int.Parse(contract[3])-1;
                cmbJobPosition.SelectedIndex= cmbJobPosition.Items.IndexOf(contract[4]);
                txtName.Text = contract[5];
                if (int.Parse(contract[6]) == 1)
                {
                    rdoMale.Checked = true;
                    rdoFemale.Checked = false;
                }
                else
                {
                    rdoMale.Checked = false;
                    rdoFemale.Checked = true;
                }
                txtID.Text = contract[7];
                txtPhoneNumber.Text = contract[8];
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckData() == false)
            {
                MessageBox.Show("请填写完整！");
                return;
            }
            else
            {
                string datetime = DateTime.Now.ToString();
                if (rdoFemale.Checked == true)
                {
                    gender = 0;
                }
                else
                {
                    gender = 1;
                }
                string sql_0 = String.Format("select count(*) from t_ContractDetail where eno ='{0}'", int.Parse(txtEno.Text));
                int count_0 = (int)DAO.ExecuteScalar(sql_0);
                string sql_5 = String.Format("select count(*) from t_employee where eno='{0}'", int.Parse(txtEno.Text));
                int count_5 = (int)DAO.ExecuteNonQuery(sql_5);
                if (frmtype == 0)//新增保存
                {
                    if (count_0 >0 || count_5 >0)
                    {
                        MessageBox.Show("已有此编号的员工，请重试！！");
                        return;
                    }
                    else
                    {
                        eno = int.Parse(txtEno.Text);
                        contractypeno = cmbContractType.SelectedIndex + 1;
                        deptno = cmbDepartment.SelectedIndex + 1;
                        jobposition = cmbJobPosition.SelectedItem.ToString();
                        ename =  txtName.Text;
                        eid = txtID.Text;
                        etel = txtPhoneNumber.Text;
                        int levelno = cmbJobPosition.SelectedIndex+1;
                        string sql_1 = String.Format("insert into dbo.t_ContractDetail values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", contractypeno, eno,deptno ,jobposition ,ename, gender, eid, etel, datetime);
                        int flag_1 = DAO.ExecuteNonQuery(sql_1);
                        string sql_2 = String.Format("insert into t_Employee (Eno, DeptNo, LevelNo, EName, EGender, EId, ETel) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", eno, deptno, levelno, ename, gender, eid, etel);
                        int flag_2 = DAO.ExecuteNonQuery(sql_2);
                        if (flag_1 != 0 && flag_2!=0)
                        {
                            MessageBox.Show("新增成功");
                            ClearData();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("新增失败");
                            ClearData();
                            return;
                        }
                    }
                }
                else//修改保存
                {
                    if (count_0 <=0)
                    {
                        MessageBox.Show("没有此员工信息！");
                        return;
                    }
                    else
                    {
                                                eno = int.Parse(txtEno.Text);
                        contractypeno = cmbContractType.SelectedIndex + 1;
                        deptno = cmbDepartment.SelectedIndex + 1;
                        jobposition = cmbJobPosition.SelectedItem.ToString();
                        ename =  txtName.Text;
                        eid = txtID.Text;
                        etel = txtPhoneNumber.Text;
                        int levelno = cmbJobPosition.SelectedIndex+1;
                        string sql = String.Format("update t_ContractDetail set ContractTypeNo='{0}', Eno='{1}',deptno='{2}',jobposition='{3}', ename='{4}',egender='{5}', eid='{6}',etel='{7}',effecttime='{8}'where contractno='{9}'", contractypeno, eno, deptno, jobposition, ename, gender, eid, etel, datetime, int.Parse(txtContractNo.Text.ToString()));
                        int flag = DAO.ExecuteNonQuery(sql);
                        string sql_3 = String.Format("update t_Employee set DeptNo='{0}', LevelNo='{1}',EName='{2}',EGender='{3}',EId='{4}',ETel='{5}' where Eno='{6}'", deptno, levelno, ename, gender, eid, etel, eno);
                        int flag_3 = DAO.ExecuteNonQuery(sql_3);
                        if (flag != 0 && flag_3!=0)
                        {
                            MessageBox.Show("修改成功");
                            ClearData();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("修改失败");
                            ClearData();
                            return;
                        }
                    }

                }

            }
        }

        private void ClearData()
        {
            txtContractNo.Text = "";
            cmbContractType.SelectedIndex = 0;
            txtEno.Text = "";
            cmbDepartment.SelectedIndex = 0;
            cmbJobPosition.SelectedIndex = 0;
            txtName.Text = "";

            rdoMale.Checked = true;
            rdoFemale.Checked = false;

            txtID.Text = "";
            txtPhoneNumber.Text = "";
        }

        private Boolean CheckData()
        {
            int count = 0;
            if (cmbContractType.SelectedIndex == -1 || cmbDepartment.SelectedIndex == -1 || cmbJobPosition.SelectedIndex == -1)
            {
                count++;
            }
            if (txtEno.Text == "" || txtName.Text == "" || txtPhoneNumber.Text == "" || txtID.Text == "")
            {
                count++;
            }
            if (rdoFemale.Checked == false && rdoMale.Checked == false)
            {
                count++;
            }

            if (count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnChooseContract_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            FrmBrowseContract frm = new FrmBrowseContract(user);
            frm.ShowDialog();
            if (user.Cno!=0)
            {
                string sql_1 = String.Format("select * from t_ContractDetail where ContractNo='{0}'", user.Cno);
                DataTable dt = DAO.GetTable(sql_1);
                string[] contract = new string[10];
                for (int i = 0; i < 10; i++)
                {
                    contract[i] = dt.Rows[0][i].ToString();
                }
                LoadData(contract);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.sslblTimeShow.Text = dt.ToString();
        }
    }
}
