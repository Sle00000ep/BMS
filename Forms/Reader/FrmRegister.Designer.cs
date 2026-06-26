namespace LibrarySystem
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbType2 = new ComboBox();
            cmbType1 = new ComboBox();
            label7 = new Label();
            btnCancel = new Button();
            btnRegisterOk = new Button();
            textPasswordAgain = new TextBox();
            label6 = new Label();
            textPassword = new TextBox();
            label5 = new Label();
            comboSex = new ComboBox();
            textTel = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textName = new TextBox();
            label2 = new Label();
            textIDcard = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbType2
            // 
            cmbType2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbType2.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbType2.FormattingEnabled = true;
            cmbType2.Location = new Point(372, 532);
            cmbType2.Name = "cmbType2";
            cmbType2.Size = new Size(123, 28);
            cmbType2.TabIndex = 67;
            // 
            // cmbType1
            // 
            cmbType1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbType1.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbType1.FormattingEnabled = true;
            cmbType1.Items.AddRange(new object[] { "教师", "学生", "社会人员" });
            cmbType1.Location = new Point(252, 532);
            cmbType1.Name = "cmbType1";
            cmbType1.Size = new Size(98, 28);
            cmbType1.TabIndex = 66;
            cmbType1.SelectedIndexChanged += cmbType1_SelectedIndexChanged_1;
            cmbType1.SelectedValueChanged += cmbType1_SelectedValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(152, 532);
            label7.Name = "label7";
            label7.Size = new Size(82, 24);
            label7.TabIndex = 65;
            label7.Text = "身份选择";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Cornsilk;
            btnCancel.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(384, 612);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 40);
            btnCancel.TabIndex = 64;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRegisterOk
            // 
            btnRegisterOk.BackColor = Color.AliceBlue;
            btnRegisterOk.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterOk.Location = new Point(202, 612);
            btnRegisterOk.Name = "btnRegisterOk";
            btnRegisterOk.Size = new Size(94, 40);
            btnRegisterOk.TabIndex = 63;
            btnRegisterOk.Text = "确认注册";
            btnRegisterOk.UseVisualStyleBackColor = false;
            btnRegisterOk.Click += btnRegisterOk_Click;
            // 
            // textPasswordAgain
            // 
            textPasswordAgain.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textPasswordAgain.Location = new Point(252, 463);
            textPasswordAgain.Name = "textPasswordAgain";
            textPasswordAgain.Size = new Size(243, 31);
            textPasswordAgain.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(152, 463);
            label6.Name = "label6";
            label6.Size = new Size(82, 24);
            label6.TabIndex = 61;
            label6.Text = "确认密码";
            // 
            // textPassword
            // 
            textPassword.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(252, 398);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(243, 31);
            textPassword.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(152, 401);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 59;
            label5.Text = "密码";
            // 
            // comboSex
            // 
            comboSex.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboSex.FormattingEnabled = true;
            comboSex.Items.AddRange(new object[] { "女", "男" });
            comboSex.Location = new Point(252, 266);
            comboSex.Name = "comboSex";
            comboSex.Size = new Size(243, 32);
            comboSex.TabIndex = 58;
            // 
            // textTel
            // 
            textTel.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textTel.Location = new Point(252, 332);
            textTel.Name = "textTel";
            textTel.Size = new Size(243, 31);
            textTel.TabIndex = 57;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(152, 339);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 56;
            label3.Text = "手机号";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(152, 274);
            label4.Name = "label4";
            label4.Size = new Size(46, 24);
            label4.TabIndex = 55;
            label4.Text = "性别";
            // 
            // textName
            // 
            textName.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(252, 202);
            textName.Name = "textName";
            textName.Size = new Size(243, 31);
            textName.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(152, 209);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 53;
            label2.Text = "姓名";
            // 
            // textIDcard
            // 
            textIDcard.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textIDcard.Location = new Point(252, 141);
            textIDcard.Name = "textIDcard";
            textIDcard.Size = new Size(243, 31);
            textIDcard.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 144);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 51;
            label1.Text = "身份证";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(697, 732);
            Controls.Add(cmbType2);
            Controls.Add(cmbType1);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnRegisterOk);
            Controls.Add(textPasswordAgain);
            Controls.Add(label6);
            Controls.Add(textPassword);
            Controls.Add(label5);
            Controls.Add(comboSex);
            Controls.Add(textTel);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textName);
            Controls.Add(label2);
            Controls.Add(textIDcard);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRegister";
            Text = "用户注册";
            Load += FrmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbType2;
        private ComboBox cmbType1;
        private Label label7;
        private Button btnCancel;
        private Button btnRegisterOk;
        private TextBox textPasswordAgain;
        private Label label6;
        private TextBox textPassword;
        private Label label5;
        private ComboBox comboSex;
        private TextBox textTel;
        private Label label3;
        private Label label4;
        private TextBox textName;
        private Label label2;
        private TextBox textIDcard;
        private Label label1;
    }
}