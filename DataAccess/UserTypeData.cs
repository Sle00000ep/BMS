using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.DataAccess
{
    public class UserTypeData
    {
        //显示
        public DataTable GetStudentType()
        {
            string sql = "select * from Table_StudentType";
            return SqlHelper.ExecuteDataSet(CommandType.Text, sql).Tables[0];
        }
        public DataTable GetTeacherType()
        {
            string sql = "select * from Table_TeacherType";
            return SqlHelper.ExecuteDataSet(CommandType.Text, sql).Tables[0];
        }
        public DataTable GetSocietyType()
        {
            string sql = "select * from Table_SocietyType";
            return SqlHelper.ExecuteDataSet(CommandType.Text, sql).Tables[0];
        }
        //增加
        public bool AddStudent(string type)
        {
            string sql = $"insert into Table_StudentType values('{type}')";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        public bool AddTeacher(string type)
        {
            string sql = $"insert into Table_TeacherType values('{type}')";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        public bool AddSociety(string type)
        {
            string sql = $"insert into Table_SocietyType values('{type}')";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        //删除
        public bool DeleteStudent(string type)
        {
            string sql = $"delete from Table_StudentType where Type = '{type}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        public bool DeleteTeacher(string type)
        {
            string sql = $"delete from Table_TeacherType where Type = '{type}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        public bool DeleteSociety(string type)
        {
            string sql = $"delete from Table_SocietyType where Type = '{type}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }

        //修改
        public bool UpdateStudent(string type, string pre_type)
        {
            string sql = $"update Table_StudentType set Type='{type}' where Type='{pre_type}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        public bool UpdateTeacher(string type, string pre_type)
        {
            string sql = $"update Table_TeacherType set Type='{type}' where Type='{pre_type}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }
        public bool UpdateSociety(string type, string pre_type)
        {
            string sql = $"update Table_SocietyType set Type='{type}' where Type='{pre_type}'";
            return SqlHelper.ExecuteNonQuery(CommandType.Text, sql) > 0;
        }

        //查
        public DataTable SearchStudent(string key)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from Table_StudentType where Type like '%{key}%'";
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
        public DataTable SearchTeacher(string key)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from Table_TeacherType where Type like '%{key}%'";
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
        public DataTable SearchSociety(string key)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from Table_SocietyType where Type like '%{key}%'";
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
