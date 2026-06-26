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
//using Lms.DataAccess;
using System.Drawing.Imaging;
using System.Globalization;
using LibrarySystem.User;
using LibrarySystem.Business;

namespace LibrarySystem
{
    public partial class FrmBookBorrow : Form
    {
        public FrmBookBorrow()
        {
            InitializeComponent();
        }

        public static int inNum;
        public static int outNum;


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {//获取关键字
            string key = textKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {

            }
            BookService bookService = new BookService();
            DataTable dt = bookService.Search(key);
            dgvBook.DataSource = dt;

        }

        private void FrmBookBorrow_Load(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            DataTable book = bookService.GetAllBooks();
            dgvBook.DataSource = book;
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
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确定退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //退出
                this.Close();
            };
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //确认选中书籍
            if (labelID.Text == "NULL" || labelName.Text == "NULL")
            {
                MessageBox.Show("未选中书籍，请重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //借阅书籍数量限制
            inNum = int.Parse(dgvBook.CurrentRow.Cells[7].Value.ToString());
            outNum = int.Parse(dgvBook.CurrentRow.Cells[8].Value.ToString());
            //书籍库存小于需要量，显示库存量
            if (inNum <= int.Parse(textNum.Text))
            {
                MessageBox.Show($"库存不足，仅剩'{inNum}'本，请重试！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //图书馆数量修改
            DateTime date = DateTime.Now;
            int key = 0;
            BorrowService borrowService = new BorrowService();
            if (borrowService.Borrow(int.Parse(labelID.Text), labelName.Text, date, int.Parse(textNum.Text), false, FrmLog.id))
            {
                MessageBox.Show("借阅成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BookService bookService = new BookService();
                dgvBook.DataSource = null;
                DataTable dt = bookService.GetAllBooks();
                dgvBook.DataSource = dt;
            }
            else
            {
                MessageBox.Show("借阅失败！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIntro_Click(object sender, EventArgs e)
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

        private void btnMyBook_Click(object sender, EventArgs e)
        {

            FrmMyBook form = new FrmMyBook();
            form.ShowDialog();
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            BookService bookService = new BookService();
            dgvBook.DataSource = null;
            DataTable dt = bookService.GetAllBooks();
            dgvBook.DataSource = dt;

        }

        private void textKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }
    }
}
