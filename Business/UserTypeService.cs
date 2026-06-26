using LibrarySystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Business
{
    public class UserTypeService
    {

        private UserTypeData typedata = new UserTypeData();
        //显示
        public DataTable GetAllType(string type1)
        {
            switch (type1)
            {
                case "教师":

                    return typedata.GetTeacherType();
                    
                case "学生":
                    return typedata.GetStudentType();
                    
                case "社会人员":
                    return typedata.GetSocietyType();
                default:return null;    
            }
            
        }
       //添加
        public bool Add(string type1,string type)
        {
            switch(type1)
            {
                case "教师":
                   return typedata.AddTeacher(type);

                case "学生":
                    return typedata.AddStudent(type);

                case "社会人员":
                    return typedata.AddSociety(type);

                default: return false;
            }
        }
        //删除
        public bool Delete(string type1,string type)
        {
            switch (type1)
            {
                case "教师":
                    return typedata.DeleteTeacher(type);

                case "学生":
                    return typedata.DeleteStudent(type);

                case "社会人员":
                    return typedata.DeleteSociety(type);

                default: return false;
            }
        }
        //修改
        public bool Update(string type1,string type, string pre_type)
        {

            switch (type1)
            {
                case "教师":
                    return typedata.UpdateTeacher(type,pre_type);

                case "学生":
                    return typedata.UpdateStudent(type, pre_type);

                case "社会人员":
                    return typedata.UpdateSociety(type, pre_type);

                default: return false;
            }
           
        }
        //查询
        public DataTable Search(string type1,string key)
        {
            switch (type1)
            {
                case "教师":
                    return typedata.SearchTeacher(key);

                case "学生":
                    return typedata.SearchStudent(key);

                case "社会人员":
                    return typedata.SearchSociety(key);

                default: 
                    
                    return null;
            }
           
        }
  
    }
}
