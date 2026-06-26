using LibrarySystem.DataAccess;
//using Lms.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Business
{
    public class BookService
    {
        private BookData bookdata = new BookData();
        //显示
        public DataTable GetAllBooks()
        {
            return bookdata.GetAllBooks();
        }
        //添加
        public bool Add(int id,string name,string author,string press,
            DateTime date,string type,float price,int innum,int outnum,string intro)
        {
            return bookdata.Add(id,name,author,press,date,type,price,innum,outnum,intro);
        }
        //删除
        public bool Delete(int bookid)
        { 
            return bookdata.Delete(bookid);
        }
        //修改
        public bool Update(int id, string name, string author, string press,
            DateTime date, string type, float price, int innum, int outnum, string intro) 
        {
            return bookdata.Update(id, name, author, press, date, type, price, innum, outnum, intro);
        }
        //查询
        public DataTable Search(string key)
        {
            return bookdata.Search(key);   
        }
        //查看简介
        public void ViewIntro(string name, int id)
        {
            string intro=bookdata.ViewIntro(name, id);
            MessageBox.Show(intro, $"{name}简介", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
