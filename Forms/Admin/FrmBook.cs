using LibrarySystem.Book;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using LibrarySystem.Business;

namespace LibrarySystem
{
    public partial class FrmBook : Form
    {
        public FrmBook()
        {
            InitializeComponent();
        }

        //图书信息 修改图书功能
        public static int BookID;
        public static string BookName;
        public static string Author;
        public static string Press;
        public static string Type;
        public static string Introduction;
        public static string PressDate;
        public static int inNum;
        public static int outNum;
        public static float Price;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBookAdd form = new FrmBookAdd();
            form.ShowDialog();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "NULL")
            {
                MessageBox.Show("未选中图书", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmBookAlter form = new FrmBookAlter();
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //获取到当前选中的图书编号，以编号为key
            if (labelID.Text == "NULL")
            {
                MessageBox.Show("未选中图书", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //删除key对应的数据
            BookService bookService = new BookService();
            if (bookService.Delete(int.Parse(labelID.Text)))
            {
                MessageBox.Show("删除成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelID.Text = "NULL";
                labelName.Text = "NULL";

                // 更新表格数据//?
               
                //dgvBook.Rows.Clear();
                dgvBook.DataSource = null;
                DataTable book = bookService.GetAllBooks();
                dgvBook.DataSource = book;

            }
            else
            {
                MessageBox.Show("删除失败：", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            //获取关键字
            string key = textKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {

            }
            BookService bookService = new BookService();
            DataTable dt = bookService.Search(key);
            dgvBook.DataSource = dt;

            //结果显示到表格中
        }

        private void FrmBook_Load(object sender, EventArgs e)
        {
            //在窗体加载的同时，将数据库中的图书信息显示到网格控件中
            BookService bookService = new BookService();
            DataTable book = bookService.GetAllBooks();
            dgvBook.DataSource = book;
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //当点击任意单元格时
            if (dgvBook.CurrentRow == null || dgvBook.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgvBook.CurrentRow.Cells[0].Value.ToString();
            string name = dgvBook.CurrentRow.Cells[1].Value.ToString();
            labelID.Text = id;
            labelName.Text = name;

            //为了修改
            BookID = int.Parse(dgvBook.CurrentRow.Cells[0].Value.ToString());
            BookName = dgvBook.CurrentRow.Cells[1].Value.ToString();
            Author = dgvBook.CurrentRow.Cells[2].Value.ToString();
            Press = dgvBook.CurrentRow.Cells[3].Value.ToString();
            PressDate = dgvBook.CurrentRow.Cells[4].Value.ToString();
            Type = dgvBook.CurrentRow.Cells[5].Value.ToString();
            Price = float.Parse(dgvBook.CurrentRow.Cells[6].Value.ToString());
            inNum = int.Parse(dgvBook.CurrentRow.Cells[7].Value.ToString());
            outNum = int.Parse(dgvBook.CurrentRow.Cells[8].Value.ToString());
            Introduction = dgvBook.CurrentRow.Cells[9].Value.ToString();


        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            //先清空再刷新
            BookService bookService = new BookService();
            dgvBook.DataSource = null;
            DataTable dt = bookService.GetAllBooks();
            dgvBook.DataSource = dt;
        }

        private void btnViewIntro_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "NULL")
            {
                MessageBox.Show("未选中图书，请重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //获取图书编号
            BookService bookService = new BookService();
            bookService.ViewIntro(labelName.Text, int.Parse(labelID.Text));




        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
