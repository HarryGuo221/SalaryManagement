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
    public partial class FrmMain : Form
    {
        public int Eno;
        int Authority = 0;//用户权限：0为最高，2为最低
        public FrmMain(int p_Eno, int p_authority)
        {
            Eno = p_Eno;
            Authority = p_authority;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                if (item.DropDownItems.Count > 0)
                {
                    foreach (ToolStripItem subitem in item.DropDownItems)
                    {
                        if (int.Parse(subitem.Tag.ToString()) >= Authority)//需要权限值大于当下权限值
                        {
                            subitem.Enabled = true ;
                        }
                        else
                        {
                            subitem.Enabled = false;
                        }
                    }
                }
            }
        }

        private void 工资栏目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryCategory frm1 = new SalaryCategory();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void 奖惩标准ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAwd_PunStandard frm1 = new FrmAwd_PunStandard();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void 用户基本信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserBasicInfo frm1 = new FrmUserBasicInfo(Eno, Authority);
            frm1.ShowDialog();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSalary frm = new FrmAddSalary(Eno, 0);
            frm.ShowDialog();
        }

        private void 奖惩记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAwd_Pun frm = new FrmAwd_Pun();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            string sql = "select count(*) from t_salary";
            count = (int)DAO.ExecuteScalar(sql);
            if (count<=0)
            {
                MessageBox.Show("无工资记录！");
                return;
            }
            else
            {
                FrmCheckAttendenceLog frm = new FrmCheckAttendenceLog(Eno, 2);
                frm.ShowDialog();
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddSalary frm = new FrmAddSalary(Eno, 1);
            frm.ShowDialog();
        }

        private void 新增合同ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContractManage frm = new FrmContractManage(0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 修改合同ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContractManage frm = new FrmContractManage(1);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 员工调动管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePosition frm = new FrmChangePosition();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 删除合同ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeleteContracts frm = new FrmDeleteContracts();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 工资汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllSumSalary frm = new FrmAllSumSalary();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 员工上离职管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOn_OffDuty frm = new FrmOn_OffDuty();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 工资ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBrowseSalary frm = new FrmBrowseSalary(Authority,Eno);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("如需帮助，请拨打管理员电话，谢谢！", "小提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("管理员电话：110");
            }
            else
            {
                return;
            }
        }

        private void 注销登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBrowsePresentUser frm = new FrmBrowsePresentUser(Eno);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 记录考勤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAttendenceRecord frm1 = new FrmAttendenceRecord(Eno);
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void 按年查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalSalaryBrowse frm = new FrmPersonalSalaryBrowse(Eno,0,0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 按月查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalSalaryBrowse frm = new FrmPersonalSalaryBrowse(Eno, 0, 1);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 按年ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalSalaryBrowse frm = new FrmPersonalSalaryBrowse(Eno, 1, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 按月ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalSalaryBrowse frm = new FrmPersonalSalaryBrowse(Eno, 1, 1);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 按年ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDeptSalaryBrowse frm = new FrmDeptSalaryBrowse(Eno, Authority+1, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 按月ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDeptSalaryBrowse frm = new FrmDeptSalaryBrowse(Eno, Authority + 1, 1);
            frm.MdiParent = this;
            frm.Show();
        }


        private void 按年ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCompanySalaryBrowse frm = new FrmCompanySalaryBrowse(0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 按月ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCompanySalaryBrowse frm = new FrmCompanySalaryBrowse(1);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 按年ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmDeptSalaryBrowse frm = new FrmDeptSalaryBrowse(Eno, Authority + 1, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void 按月ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmDeptSalaryBrowse frm = new FrmDeptSalaryBrowse(Eno, Authority + 1, 1);
            frm.MdiParent = this;
            frm.Show();
        }

    }
}