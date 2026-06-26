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
using System.Diagnostics.Eventing.Reader;
using LibrarySystem.Business;

namespace LibrarySystem.User
{
    public partial class FrmMyBook : Form
    {
        public FrmMyBook()
        {
            InitializeComponent();
        }

        private void FrmMyBook_Load(object sender, EventArgs e)
        {
            BorrowService borrowService = new BorrowService();
            DataTable dt = borrowService.GetBorrow(FrmLog.id);
            dgvBorrow.DataSource = dt;
        }

        private void dgvBorrow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //获取关键字
            string key = textSearch.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {

            }
            BorrowService borrowService = new BorrowService();
            DataTable dt = borrowService.Search(FrmLog.id, key);
            dgvBorrow.DataSource= dt;
           

            

            //结果显示到表格中
        }

        private void dgvBorrow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //选中
            //当点击任意单元格时
            if (dgvBorrow.CurrentRow == null || dgvBorrow.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string key = dgvBorrow.CurrentRow.Cells[6].Value.ToString();
            string bookid = dgvBorrow.CurrentRow.Cells[1].Value.ToString();
            string bookname = dgvBorrow.CurrentRow.Cells[2].Value.ToString();
            
            labelKey.Text = key;
            labelID.Text = bookid;
            labelName.Text = bookname;



        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //若已归还，则提示，并返回
            string bookstatus = dgvBorrow.CurrentRow.Cells[5].Value.ToString();
            if (bookstatus == "True")
            {
                MessageBox.Show("已归还", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelID.Text = "NULL";
                labelName.Text = "NULL";
                return;
            }
            if (bookstatus == "False")
            {
                if (DialogResult.Yes == MessageBox.Show("确认归还吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    BorrowService borrowService = new BorrowService();
                    if (borrowService.ReturnBook(int.Parse(labelKey.Text), int.Parse(labelID.Text)))
                    {
                        MessageBox.Show("归还成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        labelID.Text = "NULL";
                        labelName.Text = "NULL";
                        DataTable dt = borrowService.GetBorrow(FrmLog.id);
                        dgvBorrow.DataSource = dt;
                    }

                    else
                    {
                        MessageBox.Show("归还失败，请重试", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 
                }
                else
                {
                    return;
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
