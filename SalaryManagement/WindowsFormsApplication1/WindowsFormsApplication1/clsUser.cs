using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class clsUser
    {
        int eno = 0;
        int cno = 0;
        int authority = 0;
        public int Eno
        {
            get { return eno; }
            set { eno = value; }
        }

        public int Cno
        {
            get { return cno; }
            set { cno = value; }
        }

        public int Authority
        {
            get { return authority; }
            set { authority = value; }
        }
    }
}
