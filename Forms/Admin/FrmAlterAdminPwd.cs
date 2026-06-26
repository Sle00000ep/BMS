using LibrarySystem.Business;
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
    public partial class FrmAlterAdminPwd : Form
    {
        public FrmAlterAdminPwd()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (textpre_pwd.Text == "" || textnewpwd.Text == "" || textpwdagain.Text == "")
            {
                MessageBox.Show("有未填完的项!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textnewpwd.Text.Length != 6 || textpre_pwd.Text.Length != 6 || textpwdagain.Text.Length != 6)
            {

                MessageBox.Show("填写不符合格式", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (textnewpwd.Text != textpwdagain.Text)
            {
                MessageBox.Show("两次密码输入不一致!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textpre_pwd.Text != FrmLog.Pwd)
            {
                MessageBox.Show("原密码输入错误!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //修改
            AdminService adminService = new AdminService();
            if (adminService.AlterPwd(textpre_pwd.Text, textnewpwd.Text))
            {
                MessageBox.Show("修改成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLog.Pwd = textnewpwd.Text;
                this.Close();
            }

        }

        private void FrmAlterAdminPwd_Load(object sender, EventArgs e)
        {

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
