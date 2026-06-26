using LibrarySystem.DataAccess;
//using Lms.DataAccess;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Business
{
    public class BorrowService
    {
        private BorrowData borrowData = new BorrowData();
        //借阅
        public bool Borrow(int bookid, string bookname, DateTime date, int num, bool status,string userid)
        {
             int key = borrowData.GetKey();
            if (borrowData.UpdateLibrary(num, bookid) && borrowData.InsertBorrowRecord(bookid, bookname, date, num, status, key,userid))
            {
                return true;
            }
            else
            {
                // Log the exception
                return false;
            }
        }
       
        public bool ReturnBook(int key, int id)
        { 
            return borrowData.ReturnBook(key, id);
        }
        public DataTable GetBorrow(string userid)
        {
            return borrowData.GetBorrow(userid);
        }
        public DataTable Search(string userid,string key)
        {
            return borrowData.Search(userid,key);
        }
    }
}
