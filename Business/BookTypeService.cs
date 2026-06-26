using LibrarySystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Business
{
    public class BookTypeService
    {
        private BookTypeData typedata = new BookTypeData();
        //显示
        public DataTable GetAllType()
        { 
            return typedata.GetAllType();
        }
        //添加
        public bool Add(string type)
        { 
            return typedata.Add(type);
        }
       //删除
        public bool Delete(string type)
        {
            return typedata.Delete(type);
        }
        //修改
        public bool Update(string type,string pre_type)
        {
            return typedata.Update(type,pre_type);
        }
        //查询
        public DataTable Search(string key)
        {
            return typedata.Search(key);
        }
    }
}
