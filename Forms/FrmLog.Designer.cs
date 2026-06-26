namespace LibrarySystem
{
    partial class FrmLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogout = new Button();
            btnRegister = new Button();
            rbtnAdminister = new RadioButton();
            rbtnUser = new RadioButton();
            textPassword = new TextBox();
            label2 = new Label();
            textAccount = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MintCream;
            btnLogout.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(499, 25);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 44);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "退出";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightYellow;
            btnRegister.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(359, 371);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 44);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "注册";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // rbtnAdminister
            // 
            rbtnAdminister.AutoSize = true;
            rbtnAdminister.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnAdminister.Location = new Point(360, 300);
            rbtnAdminister.Name = "rbtnAdminister";
            rbtnAdminister.Size = new Size(93, 31);
            rbtnAdminister.TabIndex = 23;
            rbtnAdminister.Text = "管理员";
            rbtnAdminister.UseVisualStyleBackColor = true;
            // 
            // rbtnUser
            // 
            rbtnUser.AutoSize = true;
            rbtnUser.Checked = true;
            rbtnUser.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnUser.Location = new Point(188, 300);
            rbtnUser.Name = "rbtnUser";
            rbtnUser.Size = new Size(73, 31);
            rbtnUser.TabIndex = 22;
            rbtnUser.TabStop = true;
            rbtnUser.Text = "用户";
            rbtnUser.UseVisualStyleBackColor = true;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(234, 223);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(219, 34);
            textPassword.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(121, 223);
            label2.Name = "label2";
            label2.Size = new Size(52, 27);
            label2.TabIndex = 20;
            label2.Text = "密码";
            // 
            // textAccount
            // 
            textAccount.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textAccount.Location = new Point(234, 131);
            textAccount.Name = "textAccount";
            textAccount.Size = new Size(219, 34);
            textAccount.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(121, 134);
            label1.Name = "label1";
            label1.Size = new Size(52, 27);
            label1.TabIndex = 18;
            label1.Text = "账号";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Azure;
            btnLogin.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(188, 371);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 44);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLog
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(616, 467);
            Controls.Add(btnRegister);
            Controls.Add(rbtnAdminister);
            Controls.Add(rbtnUser);
            Controls.Add(textPassword);
            Controls.Add(label2);
            Controls.Add(textAccount);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLog";
            Text = "FrmLog";
            Load += FrmLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogout;
        private Button btnRegister;
        private RadioButton rbtnAdminister;
        private RadioButton rbtnUser;
        private TextBox textPassword;
        private Label label2;
        private TextBox textAccount;
        private Label label1;
        private Button btnLogin;
    }
}
