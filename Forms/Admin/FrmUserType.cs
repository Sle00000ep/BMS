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
//using Lms.DataAccess;
using LibrarySystem.Business;

namespace LibrarySystem
{
    public partial class FrmUserType : Form
    {
        public FrmUserType()
        {
            InitializeComponent();
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {

        }

        private void dgvUserType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textAdd_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReaderType_Load(object sender, EventArgs e)
        {
             
        }

        private void dgvUserType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //当点击任意单元格时
            if (dgvUserType.CurrentRow == null || dgvUserType.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("选中无效数据！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string type = dgvUserType.CurrentRow.Cells[0].Value.ToString();
            labelType.Text = type;
            textAlter.Text = type;
        }

        private void cmbType1_SelectedValueChanged(object sender, EventArgs e)
        {
            dgvUserType.DataSource = null;
            string Choice = cmbType1.SelectedItem.ToString();
            UserTypeService userTypeService = new UserTypeService();
            DataTable type = userTypeService.GetAllType(Choice);
            dgvUserType.DataSource = type;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //已选择第一类
            if (cmbType1.Text == "")
            {
                MessageBox.Show("请选择用户类型！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //非空
            if (textAdd.Text == "")
            {
                MessageBox.Show("请添加内容！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //查重
            UserTypeService userTypeService = new UserTypeService();
            if (userTypeService.Add(cmbType1.Text.ToString(), textAdd.Text.ToString()))
            {
                MessageBox.Show("添加成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUserType.DataSource = null;
                DataTable dt=userTypeService.GetAllType(cmbType1.Text);
                dgvUserType.DataSource= dt;
            }
            else
            {
                //注册失败
                MessageBox.Show("添加失败，请检查信息", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnAlter_Click_1(object sender, EventArgs e)
        {

            if (labelType.Text == "")
            {
                MessageBox.Show("未选中！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UserTypeService typeService = new UserTypeService();
            if (typeService.Update(cmbType1.Text, textAlter.Text, labelType.Text))
            {
                MessageBox.Show("修改成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //清空选中
                dgvUserType.DataSource = null;
                DataTable dt = typeService.GetAllType(cmbType1.Text);
                dgvUserType.DataSource = dt;
                labelType.Text = "NULL";
                textAlter.Text = "NULL";
            }
            else
            {
                MessageBox.Show("修改失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            //获取到当前选中的图书编号，以编号为key
            if (labelType.Text == "NULL")
            {
                MessageBox.Show("未选中用户", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //删除key对应的数据
            UserTypeService userTypeService = new UserTypeService();
            if (userTypeService.Delete(cmbType1.Text, labelType.Text))
            {
                MessageBox.Show("删除成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUserType.DataSource = null;
                DataTable dt = userTypeService.GetAllType(cmbType1.Text);
                dgvUserType.DataSource = dt;
                labelType.Text = "NULL";
            }
            else
            {
                MessageBox.Show("删除失败：", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmbType1.Text=="")
            {
                MessageBox.Show("请先选择第一类！","消息",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            //获取关键字
            
            string key = textKey.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {

            }
            UserTypeService userTypeService = new UserTypeService();
            DataTable type = userTypeService.Search(cmbType1.Text.ToString(),key);
            dgvUserType.DataSource = type;
        }
    }
}
