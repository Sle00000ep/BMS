namespace LibrarySystem.Forms.Admin
{
    partial class FrmUserAlter
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
            label1 = new Label();
            labelID = new Label();
            label3 = new Label();
            textPwd = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            textTel = new TextBox();
            label6 = new Label();
            textIDcard = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textName = new TextBox();
            cmbSex = new ComboBox();
            cmbStatus = new ComboBox();
            cmbType2 = new ComboBox();
            btnYes = new Button();
            btnNo = new Button();
            cmbType1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 96);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "账号";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(145, 96);
            labelID.Name = "labelID";
            labelID.Size = new Size(53, 20);
            labelID.TabIndex = 1;
            labelID.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 173);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "密码";
            // 
            // textPwd
            // 
            textPwd.Location = new Point(145, 170);
            textPwd.Name = "textPwd";
            textPwd.Size = new Size(231, 27);
            textPwd.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 173);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 12;
            label8.Text = "状态";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(473, 248);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 14;
            label9.Text = "类型";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 251);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 18;
            label7.Text = "姓名";
            // 
            // textTel
            // 
            textTel.Location = new Point(145, 484);
            textTel.Name = "textTel";
            textTel.Size = new Size(231, 27);
            textTel.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 487);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 22;
            label6.Text = "电话";
            // 
            // textIDcard
            // 
            textIDcard.Location = new Point(145, 405);
            textIDcard.Name = "textIDcard";
            textIDcard.Size = new Size(231, 27);
            textIDcard.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 408);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 20;
            label5.Text = "身份证号";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 329);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 24;
            label4.Text = "性别";
            // 
            // textName
            // 
            textName.Location = new Point(145, 248);
            textName.Name = "textName";
            textName.Size = new Size(231, 27);
            textName.TabIndex = 19;
            // 
            // cmbSex
            // 
            cmbSex.FormattingEnabled = true;
            cmbSex.Items.AddRange(new object[] { "女", "男" });
            cmbSex.Location = new Point(145, 329);
            cmbSex.Name = "cmbSex";
            cmbSex.Size = new Size(231, 28);
            cmbSex.TabIndex = 25;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "0", "1" });
            cmbStatus.Location = new Point(571, 165);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(254, 28);
            cmbStatus.TabIndex = 26;
            // 
            // cmbType2
            // 
            cmbType2.FormattingEnabled = true;
            cmbType2.Location = new Point(690, 248);
            cmbType2.Name = "cmbType2";
            cmbType2.Size = new Size(135, 28);
            cmbType2.TabIndex = 28;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FloralWhite;
            btnYes.Location = new Point(533, 484);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 29);
            btnYes.TabIndex = 29;
            btnYes.Text = "确定";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Lavender;
            btnNo.Location = new Point(731, 484);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 29);
            btnNo.TabIndex = 30;
            btnNo.Text = "取消";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // cmbType1
            // 
            cmbType1.FormattingEnabled = true;
            cmbType1.Items.AddRange(new object[] { "教师", "学生", "社会人员" });
            cmbType1.Location = new Point(571, 248);
            cmbType1.Name = "cmbType1";
            cmbType1.Size = new Size(88, 28);
            cmbType1.TabIndex = 31;
            cmbType1.SelectedIndexChanged += cmbType1_SelectedIndexChanged;
            cmbType1.SelectedValueChanged += cmbType1_SelectedValueChanged;
            // 
            // FrmUserAlter
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(863, 583);
            Controls.Add(cmbType1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(cmbType2);
            Controls.Add(cmbStatus);
            Controls.Add(cmbSex);
            Controls.Add(label4);
            Controls.Add(textTel);
            Controls.Add(label6);
            Controls.Add(textIDcard);
            Controls.Add(label5);
            Controls.Add(textName);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textPwd);
            Controls.Add(label3);
            Controls.Add(labelID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUserAlter";
            Text = "FrmUserAlter";
            Load += FrmUserAlter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelID;
        private Label label3;
        private TextBox textPwd;
        private Label label8;
        private Label label9;
        private Label label7;
        private TextBox textTel;
        private Label label6;
        private TextBox textIDcard;
        private Label label5;
        private Label label4;
        private TextBox textName;
        private ComboBox cmbSex;
        private ComboBox cmbStatus;
        private ComboBox cmbType2;
        private Button btnYes;
        private Button btnNo;
        private ComboBox cmbType1;
    }
}