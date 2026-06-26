using LibrarySystem.Book;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem.DataAccess
{
    public class BookData
    {
        //显示
        public DataTable GetAllBooks()
        {
            string sql = "select * from Table_Book";
            return SqlHelper.ExecuteDataSet(CommandType.Text, sql).Tables[0];
        }
        //添加
        public bool Add(int id,string name,string author,string press,DateTime date,string type,float price,int innum,int outnum,string intro)
        {
            string sql = $"insert into Table_Book values('{id}','{name}','{author}'," +
                $"'{press}','{date}','{type}','{price}','{innum}','{outnum}', '{intro}')";
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql)>0;
        }
        //删除
        public bool Delete(int bookid)
        {
            string sql = $"delete from Table_Book where BookID = '{bookid}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
            
        }
        //修改
        public bool Update(int id, string name, string author, string press,DateTime date, string type, float price, int innum, int outnum, string intro)
        {
            string sql = $"update Table_Book set BookName='{name}'," +
                $"Author='{author}',Press='{press}'," +
                $"PressDate='{date}',Type='{type}'," +
                $"Price='{price}',inNum='{innum}'," +
                $"outNum='{outnum}'," +
                $"Introduction='{intro}'" +
                $"where BookID ='{id}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text,sql) > 0;
        }
        //查询
        public DataTable Search(string key)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from Table_Book where BookName like '%{key}%' or " +
              $"Press like '%{key}%' or Author like '%{key}%'";
            DataSet ds = SqlHelper.ExecuteDataSet(CommandType.Text , sql);
            if(ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            else
            {
                return new DataTable();
            }
        }
        //查看简介
        public string ViewIntro(string name,int bookid)
        {
            string connectionString = "Server=127.0.0.1;Database=XQLibrary;User Id=sa;Password=sa;";
            string commandText = $"select Introduction from Table_Book where BookID = '{bookid}'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    // 使用 ExecuteReader 执行查询
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        string intro = reader[0].ToString();
                        return intro;
                       
                    }
                }
            }                          
        }
    }
}
