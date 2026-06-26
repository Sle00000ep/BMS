using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.DataAccess
{
    public class LoginData
    {
        //登录
        public static bool Login(string id,int mode,ref string DBpwd,ref string result)
        {
            DBpwd=string.Empty;
            result=string.Empty;
            if(mode==1)
            {
                string sql= $"select AdministerPassword from Table_Administer where AdministerID ='{id}' ";
                DataSet ds = SqlHelper.ExecuteDataSet(CommandType.Text,sql);
                if(ds.Tables[0].Rows.Count>0 )
                {
                    DBpwd = ds.Tables[0].Rows[0]["AdministerPassword"].ToString();
                    FrmLog.Pwd = DBpwd;
                    return true;
                }
                else
                {
                    result = "该管理员不存在！";
                    return false;
                }
            }
            else
            {
                string sql = $"select UserPassword from Table_User where UserID='{id}'";
                DataSet ds = SqlHelper.ExecuteDataSet(CommandType.Text, sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DBpwd = ds.Tables[0].Rows[0]["UserPassword"].ToString();
                    FrmLog.Pwd = DBpwd;
                    return true;
                }
                else
                {
                    result = "该读者不存在！";
                    return false;
                }
            }
        }
    }
}
