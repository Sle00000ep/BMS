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

namespace LibrarySystem.Forms.Admin
{
    public partial class FrmUserAlter : Form
    {
        public FrmUserAlter()
        {
            InitializeComponent();
        }

        private void FrmUserAlter_Load(object sender, EventArgs e)
        {
            labelID.Text = FrmReaderManage.id;
            textPwd.Text = FrmReaderManage.pwd;
            textName.Text = FrmReaderManage.name;
            textIDcard.Text = FrmReaderManage.IDcard;
            textTel.Text = FrmReaderManage.tel;
            cmbSex.Text = FrmReaderManage.sex;
            cmbStatus.Text = FrmReaderManage.status.ToString();
            cmbType1.Text = FrmReaderManage.type1;
            cmbType2.Text = FrmReaderManage.type2;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" ||
                textPwd.Text == "" ||
                textIDcard.Text == "" ||
                textTel.Text == "" ||
                cmbType1.Text == "" ||
                cmbType2.Text == "" ||
                cmbSex.Text == "")
            {
                MessageBox.Show("有未填的项！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(textPwd.Text.Length != 6||
                textIDcard.Text.Length !=18)
            {
                MessageBox.Show("填写不符合格式", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UserService userService = new UserService();
            if (userService.Update(labelID.Text, textPwd.Text, textName.Text, cmbSex.Text, textIDcard.Text, textTel.Text, bool.Parse(cmbStatus.Text), cmbType1.Text, cmbType2.Text))
            {
                MessageBox.Show("修改成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败：", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbType1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
