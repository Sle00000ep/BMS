using LibrarySystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Business
{
    public class UserService
    {
        private UserData userdata = new UserData();
        //用户功能
        //注册
        public bool Register(string pwd, string name, string sex, string IDcard, string tel, string type2,string type1)
        { 
            return userdata.Register(pwd, name, sex, IDcard, tel, type2,type1);
        }
        //管理用户功能
       //显示
        public DataTable GetAllUsers()
        {
            return userdata.GetAllUsers();
        }
        //添加
        public bool Add( string pwd, string name, string sex, string IDcard, string tel, bool status, string type2,string type1)
        {
            return userdata.Register( pwd, name, sex, IDcard,  tel, type2,type1);
        }
        //删除
        public bool Delete(int userid)
        {
            return userdata.Delete(userid);
        }
        //修改
        public bool Update(string id,string pwd, string name, string sex, string IDcard, string tel, bool status, string type1, string type2)
        {
            return userdata.Update(id,pwd,  name,  sex,  IDcard,  tel,  status,  type1,  type2);
        }
        //查询
        public DataTable Search(string key)
        {
            return userdata.Search(key);
        }
        //修改密码
        public bool AlterPwd(string pre_pwd, string pwd)
        {
            return userdata.AlterPwd(pre_pwd, pwd);
        }
    }
}
