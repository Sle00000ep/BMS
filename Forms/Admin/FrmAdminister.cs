using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class FrmAdminister : Form
    {
        public FrmAdminister()
        {
            InitializeComponent();
        }

        private void 添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminister_Load(object sender, EventArgs e)
        {
            this.labelAdminister.Text = $"管理员：{FrmLog.name} {FrmLog.id}";
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                FrmLog.Pwd = string.Empty;
                this.Close();
            };
        }

        private void labelAdminister_Click(object sender, EventArgs e)
        {

        }

        private void 图书类别管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBookType form = new FrmBookType();
            form.ShowDialog();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBook form = new FrmBook();
            form.ShowDialog();
        }

        private void 读者类别管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserType form = new FrmUserType();
            form.ShowDialog();
        }

        private void 读者管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReaderManage form = new FrmReaderManage();
            form.ShowDialog();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterAdminPwd form = new FrmAlterAdminPwd();
            form.ShowDialog();
        }

        private void 个人信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
