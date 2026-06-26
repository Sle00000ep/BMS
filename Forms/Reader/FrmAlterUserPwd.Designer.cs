namespace LibrarySystem.Forms.Reader
{
    partial class FrmAlterUserPwd
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
            btnNo = new Button();
            btnYes = new Button();
            textnewpwd = new TextBox();
            label2 = new Label();
            textpwdagain = new TextBox();
            label3 = new Label();
            textpre_pwd = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.MintCream;
            btnNo.Location = new Point(293, 291);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 40);
            btnNo.TabIndex = 11;
            btnNo.Text = "取消";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.MintCream;
            btnYes.Location = new Point(124, 291);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 40);
            btnYes.TabIndex = 10;
            btnYes.Text = "确定";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // textnewpwd
            // 
            textnewpwd.Location = new Point(145, 157);
            textnewpwd.Name = "textnewpwd";
            textnewpwd.Size = new Size(252, 27);
            textnewpwd.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 157);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 22;
            label2.Text = "新密码";
            // 
            // textpwdagain
            // 
            textpwdagain.Location = new Point(145, 222);
            textpwdagain.Name = "textpwdagain";
            textpwdagain.Size = new Size(252, 27);
            textpwdagain.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 225);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 20;
            label3.Text = "再输一次";
            // 
            // textpre_pwd
            // 
            textpre_pwd.Location = new Point(145, 92);
            textpre_pwd.Name = "textpre_pwd";
            textpre_pwd.Size = new Size(252, 27);
            textpre_pwd.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 92);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 18;
            label1.Text = "原密码";
            // 
            // FrmAlterUserPwd
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(455, 354);
            Controls.Add(textnewpwd);
            Controls.Add(label2);
            Controls.Add(textpwdagain);
            Controls.Add(label3);
            Controls.Add(textpre_pwd);
            Controls.Add(label1);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAlterUserPwd";
            Text = "FrmAlterUserPwd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNo;
        private Button btnYes;
        private TextBox textnewpwd;
        private Label label2;
        private TextBox textpwdagain;
        private Label label3;
        private TextBox textpre_pwd;
        private Label label1;
    }
}