using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            clsUser user = new clsUser();
           FrmLogin frmLogin = new FrmLogin(user);
           DialogResult dr = frmLogin.ShowDialog();
            if (dr == DialogResult.OK)
            {
            Application.Run(new FrmMain(user.Eno, user.Authority));
            }

        }
    }
}
