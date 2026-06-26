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
using System.Diagnostics;
using System.Net;
//using Lms.DataAccess;
using System.Drawing.Imaging;
using System.Globalization;
using LibrarySystem.Business;

namespace LibrarySystem
{
    public partial class FrmBookType : Form
    {
        public FrmBookType()
        {
            InitializeComponent();
        }

        private void FrmBookType_Load(object sender, EventArgs e)
        {
            BookTypeService bookTypeService = new BookTypeService();
            DataTable booktype = bookTypeService.GetAllType();
            dgvBookType.DataSource = booktype;
        }

     
        private void dgvBookType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //获取关键字
            string key = textKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {

            }
            BookTypeService bookTypeService = new BookTypeService();
            DataTable dt = bookTypeService.Search(key);
            dgvBookType.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //非空
            if (textAdd.Text == "")
            {
                MessageBox.Show("请添加内容！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //添加

            BookTypeService bookTypeService = new BookTypeService();
            if (bookTypeService.Add(textAdd.Text))
            {
                MessageBox.Show("添加成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBookType.DataSource = null;
                DataTable dt = bookTypeService.GetAllType();
                dgvBookType.DataSource = dt;
                textAdd.Text = null;
                return;
            }
            else
            {
                MessageBox.Show("添加失败，请检查信息", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //获取到当前选中的图书编号，以编号为key
            if (labelType.Text == "NULL")
            {
                MessageBox.Show("未选中图书", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //删除key对应的数据
            BookTypeService bookTypeService = new BookTypeService();
            if (bookTypeService.Delete(labelType.Text))
            {
                MessageBox.Show("删除成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBookType.DataSource = null;
                DataTable dt = bookTypeService.GetAllType();
                dgvBookType.DataSource = dt;
                labelType.Text = "NULL";
            }
            else
            {
                MessageBox.Show("删除失败：", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (labelType.Text == "")
            {
                MessageBox.Show("未选中！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BookTypeService bookTypeService = new BookTypeService();
                if (bookTypeService.Update(textAlter.Text, labelType.Text))
                {
                    MessageBox.Show("修改成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvBookType.DataSource = null;
                    DataTable dt = bookTypeService.GetAllType();
                    dgvBookType.DataSource = dt;
                    labelType.Text = "NULL";
                    textAlter.Text = "NULL";
                }
                else
                {
                    MessageBox.Show("修改失败：", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            // 更新表格数据
            BookTypeService bookTypeService = new BookTypeService();
            dgvBookType.DataSource = null;
            DataTable dt = bookTypeService.GetAllType();
            dgvBookType.DataSource = dt;
        }

        private void textAlter_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBookType_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBookType_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //当点击任意单元格时
            if (dgvBookType.CurrentRow == null || dgvBookType.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string type = dgvBookType.CurrentRow.Cells[0].Value.ToString();
            labelType.Text = type;
            textAlter.Text = type;

        }
    }
}
