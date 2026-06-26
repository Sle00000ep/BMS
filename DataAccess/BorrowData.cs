using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Transactions;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Emit;
namespace LibrarySystem.DataAccess
{
    public class BorrowData
    {
        public DataTable GetBorrow(string userid)
        {
            string sql = $"select * from Table_Borrow where UserID='{userid}'";
            return SqlHelper.ExecuteDataSet(CommandType.Text, sql).Tables[0];
        }
        //获取键
        public int GetKey()
        {
            int key = 0;
            string connectionString = "Server=127.0.0.1;Database=XQLibrary;User Id=sa;Password=sa;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string commandText = "SELECT COUNT(*) FROM Table_Borrow WHERE [Key] = @Key";
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    while (true)
                    {
                        key++;
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@Key", key);
                        int count = (int)command.ExecuteScalar();
                        if (count == 0)
                        {
                            break;
                        }
                    }
                }
            }
            return key;
        }
        //更新图书馆
        public bool UpdateLibrary(int num,int bookid)
        {
            string sql = $"update Table_Book set inNum=inNum-'{num}',outNum=outNum+'{num}' where BookID='{bookid}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;


        }
        //记录个人借阅图书
        public bool InsertBorrowRecord(int bookid,string bookname,DateTime date,int num,bool status,int key,string userid)
        {
            string sql = $"insert into Table_Borrow (UserID, BookID, BookName, Date, Num, Status,[Key]) " +
                $"values ('{userid}', '{bookid}','{bookname}','{date}','{num}', '{status}','{key}')";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        //查看简介
        public string ViewIntro(string name, int bookid)
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
        //归还
        public bool ReturnBook(int key,int id)
        {
            string connectionString = "Server=127.0.0.1;Database=XQLibrary;User Id=sa;Password=sa;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    // 开始事务
                    SqlTransaction transaction = connection.BeginTransaction();
                    command.Transaction = transaction;
                    try
                    {
                        // 使用参数化查询获取 Num
                        command.CommandText = "SELECT Num FROM Table_Borrow WHERE [Key] = @Key";
                        command.Parameters.AddWithValue("@Key", key);
                        int returnNum = 0;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int.TryParse(reader["Num"].ToString(), out returnNum);
                            }
                            reader.Close();
                        }

                        // 更新图书信息
                        command.CommandText = "UPDATE Table_Book SET inNum = inNum + @returnNum, outNum = outNum - @returnNum WHERE BookID = @BookID";
                        command.Parameters.AddWithValue("@returnNum", returnNum);
                        command.Parameters.AddWithValue("@BookID", id);
                        command.ExecuteNonQuery();

                        // 更新借阅信息
                        command.CommandText = "UPDATE Table_Borrow SET Status = 'True' WHERE [Key] = @Key";
                        command.ExecuteNonQuery();

                        // 提交事务
                        transaction.Commit();
                      
                        return true;
                    }
                    catch
                    {
                        // 回滚事务
                        transaction.Rollback();
                     
                        return false;
                    }
                }
            }
           
        }
        //查询
        public DataTable Search(string key,string userid)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from Table_Borrow where UserID='{userid}' and BookName like '%{key}%'";
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
