using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LibrarySystem.Book;
namespace LibrarySystem.DataAccess
{
    public class BookTypeData
    {
        //显示
        public DataTable GetAllType()
        {
            string sql = "select * from Table_BookType";
            return SqlHelper.ExecuteDataSet(CommandType.Text, sql).Tables[0];
        }
        //添加
        public bool Add(string type)
        {
            string sql = $"insert into Table_BookType values('{type}')";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        //删除
        public bool Delete(string type)
        {
            string sql = $"delete from Table_BookType where BookType = '{type}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        //修改
        public bool Update(string type,string pre_type)
        {
            string sql = $"update Table_BookType set BookType='{type}' where BookType='{pre_type}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        //查询
        public DataTable Search(string key)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from Table_BookType where BookType like '%{key}%'";
            DataSet ds = SqlHelper.ExecuteDataSet(CommandType.Text, sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }
    }
}
