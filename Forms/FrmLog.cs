using LibrarySystem.Business;
//using Lms.DataAccess;
//using Microsoft.Identity.Client;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }
        public int mode;
        public static string Pwd;
        public static string id;
        public static string name;
        //管理员登录的方法
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
        private void FrmLog_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认退出吗？", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //退出
                this.Close();
            };
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //判断文本框是否有内容
            if (textAccount.Text == "" || textPassword.Text == "")
            {
                MessageBox.Show("有未填写的项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断文本输入是否符合格式（账号12位，密码6位）
            if(textAccount.Text.Length != 12 || textPassword.Text.Length != 6)
            {
                MessageBox.Show("填写不符合格式", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //判断登录对象
            if (rbtnAdminister.Checked == true)
            {
                mode = 1;

            }
            else if (rbtnUser.Checked == true)
            {
                mode = 2;

            }
            else
            {
                MessageBox.Show("请选择登录模式！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //将填入数据传给Business/LoginService

            string result = string.Empty;
            LoginService loginService = new LoginService();
            if (loginService.Login(textAccount.Text, textPassword.Text, mode, ref result))
            {
                id = textAccount.Text;
                DialogResult = DialogResult.OK;//在program.cs中确定登录管理员/读者界面
            }
            else
            {
                MessageBox.Show(result, "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            FrmRegister form = new FrmRegister();
            form.ShowDialog();
        }
    }
}
