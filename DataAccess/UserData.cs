using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LibrarySystem.DataAccess
{
    public class UserData
    {
        public static string newUserId;
        //显示
        public DataTable GetAllUsers()
        {
            string sql = "select * from Table_User";
            return SqlHelper.ExecuteDataSet(CommandType.Text, sql).Tables[0];
        }
        //注册
        public bool Register(string pwd, string name, string sex, string IDcard, string tel, string type2,string type1)
        {

            string connectionString = "Server=127.0.0.1;Database=XQLibrary;User Id=sa;Password=sa;";
            string sql_account = "SELECT MAX(cast(UserID as bigint)) FROM Table_User"; // 定义 SQL 查询命令文本，使用 MAX 函数获取 UserID 的最大值
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                object result = SqlHelper.ExecuteScalar(connection, CommandType.Text, sql_account);   // 执行 SQL 查询并返回单个值
                long numericMaxUserId = (long)result;
                long newNumericUserId = numericMaxUserId + 1;
                newUserId = newNumericUserId.ToString("D12"); // 确保新 UserID 的长度为 12，不足部分用 0 填充
                string sql_register = $"insert into Table_User values('{newUserId}','{pwd}','{name}','{sex}','{IDcard}','{tel}','1','{type2}','{type1}')";
                return SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql_register) > 0;
            }
        }
        //删除
        public bool Delete(int userid)
        {
            string sql = $"delete from Table_User where UserID = '{userid}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;

        }
        //修改
        public bool Update(string id,string pwd, string name, string sex, string IDcard, string tel, bool status, string type1, string type2)
        {
            string sql = $"update Table_User set UserName='{name}'," +
                $"UserPassword='{pwd}',UserSex='{sex}'," +
                $"UserIDcard='{IDcard}',AllType='{type1}'," +
                $"UserStatus='{status}',UserTel='{tel}'," +
                $"UserType='{type2}' where UserID ='{id}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        //查询
        public DataTable Search(string key)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from Table_User where UserName like '%{key}%' or " +
              $"UserType like '%{key}%' or AllType like '%{key}%' or UserID='{key}'";
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
        //修改密码
        public bool AlterPwd(string pre_pwd, string pwd)
        {
            string sql = $"update Table_User set UserPassword='{pwd}' where UserPassword='{pre_pwd}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
    }
}
