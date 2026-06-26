namespace LibrarySystem
{
    partial class FrmAlterAdminPwd
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
            btnYes = new Button();
            btnNo = new Button();
            textnewpwd = new TextBox();
            label2 = new Label();
            textpwdagain = new TextBox();
            label3 = new Label();
            textpre_pwd = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.MintCream;
            btnYes.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnYes.ForeColor = SystemColors.ActiveCaptionText;
            btnYes.Location = new Point(132, 302);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 38);
            btnYes.TabIndex = 0;
            btnYes.Text = "确定";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.MintCream;
            btnNo.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNo.Location = new Point(325, 302);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 38);
            btnNo.TabIndex = 1;
            btnNo.Text = "取消";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // textnewpwd
            // 
            textnewpwd.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textnewpwd.Location = new Point(167, 169);
            textnewpwd.Name = "textnewpwd";
            textnewpwd.Size = new Size(252, 31);
            textnewpwd.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 169);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 14;
            label2.Text = "新密码";
            // 
            // textpwdagain
            // 
            textpwdagain.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textpwdagain.Location = new Point(167, 234);
            textpwdagain.Name = "textpwdagain";
            textpwdagain.Size = new Size(252, 31);
            textpwdagain.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 237);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 12;
            label3.Text = "再输一次";
            // 
            // textpre_pwd
            // 
            textpre_pwd.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textpre_pwd.Location = new Point(167, 104);
            textpre_pwd.Name = "textpre_pwd";
            textpre_pwd.Size = new Size(252, 31);
            textpre_pwd.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 104);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 10;
            label1.Text = "原密码";
            // 
            // FrmAlterAdminPwd
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(512, 387);
            Controls.Add(textnewpwd);
            Controls.Add(label2);
            Controls.Add(textpwdagain);
            Controls.Add(label3);
            Controls.Add(textpre_pwd);
            Controls.Add(label1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAlterAdminPwd";
            Text = "修改密码";
            Load += FrmAlterAdminPwd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYes;
        private Button btnNo;
        private TextBox textnewpwd;
        private Label label2;
        private TextBox textpwdagain;
        private Label label3;
        private TextBox textpre_pwd;
        private Label label1;
    }
}