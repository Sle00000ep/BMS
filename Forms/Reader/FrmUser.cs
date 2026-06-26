using LibrarySystem.Forms.Reader;
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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //退出
                this.Close();
              
            };
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            this.labelUser.Text = $"用户：{FrmLog.name} {FrmLog.id}";
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void 图书借阅管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBookBorrow form = new FrmBookBorrow();
            form.ShowDialog();
        }

        private void 注销账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlterUserPwd form = new FrmAlterUserPwd();
            form.ShowDialog();
        }
    }
}
