using LibrarySystem.Business;
//using Lms.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystem.Book
{
    public partial class FrmBookAdd : Form
    {
        public FrmBookAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



      

        private void dtpPress_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmBookAdd_Load(object sender, EventArgs e)
        {
            BookTypeService bookTypeService = new BookTypeService();
            DataTable type = bookTypeService.GetAllType();
            if (type != null && type.Rows.Count > 0)
            {
                foreach (DataRow row in type.Rows)
                {
                    cmbType.Items.Add(row["BookType"].ToString());
                }
            }

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //若文本为空，则返回
            if (textBookID.Text.Trim() == ""
                || textBookName.Text.Trim() == ""
                || textAuthor.Text.Trim() == ""
                || textPress.Text.Trim() == ""
                || textNum.Text.Trim() == ""
                || textPrice.Text.Trim() == ""
                || textIntro.Text.Trim() == ""
                || cmbType.Text == ""
                || dtpPress.Text == ""
                )
            {
                MessageBox.Show("有未完成的项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //检验书名、编号是否存在



            //添加图书

            BookService bookService = new BookService();
            if (bookService.Add(int.Parse(textBookID.Text.Trim()), textBookName.Text.Trim(),
               textAuthor.Text.Trim(), textPress.Text.Trim(), dtpPress.Value.Date, cmbType.Text,
               float.Parse(textPrice.Text.Trim()), int.Parse(textNum.Text.Trim()), 0, textIntro.Text.Trim()))
            {
                MessageBox.Show($"添加成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                //要给dgv刷新

            }
            else
            {
                MessageBox.Show("添加失败，请检查信息", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //退出
                this.Close();
            };
        }
    }
}
