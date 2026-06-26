//using Lms.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LibrarySystem.Business;

namespace LibrarySystem.Book
{
    public partial class FrmBookAlter : Form
    {
        public static int bookid;
        public static string bookname;
        public static string author;
        public static string press;
        public static DateTime pressdate;
        public static string type;
        public static float price;
        public static int innum;
        public static int outnum;
        public static string introduction;
        public FrmBookAlter()
        {
            InitializeComponent();
        }
        private void LoadCmbType()
        {

            string connectionString = "Server=127.0.0.1;Database=XQLibrary;User Id=sa;Password=sa;";
            string commandText = "select * from Table_BookType";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 打开数据库连接
                connection.Open();

                // 创建 SqlCommand 对象并添加参数
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    // 使用 ExecuteReader 执行查询
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbType.Items.Add(reader["BookType"].ToString());
                         
                               
                        }
                        reader.Close();

                    }
                }
                // 注意：这里不需要手动关闭连接，因为 using 语句会自动处理
            }

        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void FrmBookAlter_Load(object sender, EventArgs e)
        {
            //加载原有
            textBookID.Text = FrmBook.BookID.ToString();
            textBookName.Text = FrmBook.BookName;
            textAuthor.Text = FrmBook.Author;
            textPress.Text = FrmBook.Press;
            dtpPressDate.Value = DateTime.Parse(FrmBook.PressDate);
            cmbType.Text = FrmBook.Type;
            textPrice.Text = FrmBook.Price.ToString();
            textinNum.Text = FrmBook.inNum.ToString();
            textoutNum.Text = FrmBook.outNum.ToString();
            textIntro.Text = FrmBook.Introduction;

            //combobox的items加载出来（来源于数据库）
           LoadCmbType();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //文本框是否全部有内容
            if (textBookID.Text == "" || textBookName.Text == ""
                || textAuthor.Text == "" || textPress.Text == ""
                || dtpPressDate.Text == "" || cmbType.Text == ""
                || textPrice.Text == "" || textinNum.Text == ""
                || textoutNum.Text == "" || textIntro.Text == "")
            {
                MessageBox.Show("有未填的项！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //修改图书信息

            BookService bookService = new BookService();
            if (bookService.Update(int.Parse(textBookID.Text.Trim()), textBookName.Text.Trim(), textAuthor.Text.Trim(), textPress.Text.Trim(),
                dtpPressDate.Value.Date, cmbType.Text, float.Parse(textPrice.Text), int.Parse(textinNum.Text.Trim()),
                int.Parse(textoutNum.Text.Trim()), textIntro.Text.Trim()))
            {
                MessageBox.Show("修改成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败：", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
