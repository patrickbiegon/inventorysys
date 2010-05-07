 
using System;
using System.Collections.Generic;
using System.Text;

namespace Template1
{
    class clsDB
    {
        public clsADO ADO()
        {
            string connstr = "file name=" + System.Windows.Forms.Application.StartupPath + "\\Database\\connudl.udl";
            return new clsADO(connstr);
        }
    }
}
