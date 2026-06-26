using LibrarySystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Business
{
    public class LoginService
    {
        //登录
        public bool Login(string id,string password,int mode,ref string result)
        {
            string DBpwd=string.Empty;
            if (LoginData.Login(id,mode,ref DBpwd,ref result))
            {
                if(password == DBpwd)
                {
                    return true;
                }
                else
                {
                    result = "账号或密码错误！";
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
