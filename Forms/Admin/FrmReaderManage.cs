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
using LibrarySystem.Business;
using LibrarySystem.Forms.Admin;
using System.Diagnostics;
using System.Net;

namespace LibrarySystem
{
    public partial class FrmReaderManage : Form
    {
        public static string id;
        public static string pwd;
        public static string name;
        public static string sex;
        public static string IDcard;
        public static string tel;
        public static bool status;
        public static string type1;
        public static string type2;


        public FrmReaderManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUsersAdd form = new FrmUsersAdd();
            form.ShowDialog();
        }

        private void FrmReader_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = null;
            UserService userService = new UserService();
            DataTable user = userService.GetAllUsers();
            dgvUser.DataSource = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //获取关键字
            string key = textKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {

            }
            UserService userService = new UserService();
            DataTable dt = userService.Search(key);
            dgvUser.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //获取到当前选中的图书编号，以编号为key
            if (labelID.Text == "NULL")
            {
                MessageBox.Show("未选中用户", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserService userService = new UserService();
            if (userService.Delete(int.Parse(labelID.Text)))
            {
                MessageBox.Show("删除成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUser.DataSource = null;
                DataTable dt = userService.GetAllUsers();
                dgvUser.DataSource = dt;
                labelID.Text = "NULL";
                labelName.Text = "NULL";
            }
            else
            {
                MessageBox.Show("删除失败：", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //当点击任意单元格时
            if (dgvUser.CurrentRow == null || dgvUser.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            labelID.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            labelName.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();

            id = dgvUser.CurrentRow.Cells[0].Value.ToString();
            pwd = dgvUser.CurrentRow.Cells[1].Value.ToString();
            name = dgvUser.CurrentRow.Cells[2].Value.ToString();
            sex = dgvUser.CurrentRow.Cells[3].Value.ToString();
            IDcard = dgvUser.CurrentRow.Cells[4].Value.ToString();
            tel = dgvUser.CurrentRow.Cells[5].Value.ToString();
            status = bool.Parse(dgvUser.CurrentRow.Cells[6].Value.ToString());
            type2 = dgvUser.CurrentRow.Cells[7].Value.ToString();
            type1 = dgvUser.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "NULL")
            {
                MessageBox.Show("未选中用户", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FrmUserAlter form = new FrmUserAlter();
            form.ShowDialog();
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = null;
            UserService userService = new UserService();
            DataTable dt = userService.GetAllUsers();
            dgvUser.DataSource = dt;
        }
    }
}
