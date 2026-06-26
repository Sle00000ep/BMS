using LibrarySystem.Business;
using LibrarySystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Forms.Admin
{
    public partial class FrmUsersAdd : Form
    {
        public FrmUsersAdd()
        {
            InitializeComponent();
        }

        private void cmbType1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void btnRegisterOk_Click(object sender, EventArgs e)
        {

            //先判断文本框是否为空
            if (textIDcard.Text == ""
                || textName.Text == ""
                || textPassword.Text == ""
                || textPasswordAgain.Text == ""
                || textTel.Text == ""
                || comboSex.Items == null
                || cmbType1.Items == null
                || cmbType2.Items == null)
            {
                //若有空项，则提示并返回
                MessageBox.Show("有未填写的项", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textPassword.Text.Length != 6 ||
                textPasswordAgain.Text.Length !=6||
               textIDcard.Text.Length != 18)
            {
                MessageBox.Show("填写不符合格式", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //再检查两次密码填写是否一致
            if (textPassword.Text.Trim() != textPasswordAgain.Text.Trim())
            {
                //不一致则提示并返回
                MessageBox.Show("两次密码不一致", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UserService userService = new UserService();

            if (userService.Add(textPassword.Text, textName.Text, comboSex.Text, textIDcard.Text, textTel.Text, true, cmbType2.Text, cmbType1.Text))
            {
                //成功
                MessageBox.Show($"添加成功!该用户的账号为{UserData.newUserId}", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                //失败
                MessageBox.Show("添加失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbType1_SelectedValueChanged(object sender, EventArgs e)
        {
            string Choice = cmbType1.SelectedItem.ToString();
            cmbType2.Text = null;
            cmbType2.Items.Clear();
            UserTypeService userTypeService = new UserTypeService();
            DataTable type = userTypeService.GetAllType(Choice);

            if (type != null && type.Rows.Count > 0)
            {
                foreach (DataRow row in type.Rows)
                {
                    cmbType2.Items.Add(row["Type"].ToString());
                }
            }
        }
    }
}
