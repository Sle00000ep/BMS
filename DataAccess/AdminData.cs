using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.DataAccess
{
    public class AdminData
    {
        //修改密码
        public bool AlterPwd(string pre_pwd,string pwd)
        {
            string sql = $"update Table_Administer set AdministerPassword='{pwd}' where AdministerPassword='{pre_pwd}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql)>0;
        }
    }
}
