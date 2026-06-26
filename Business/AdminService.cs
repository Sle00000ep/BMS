using LibrarySystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Business
{
    public class AdminService
    {
        private AdminData data= new AdminData();
        public bool AlterPwd(string pre_pwd,string pwd)
        {
            return data.AlterPwd(pre_pwd, pwd);
        }
    }
}
