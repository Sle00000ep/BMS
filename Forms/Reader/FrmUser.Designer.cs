namespace LibrarySystem
{
    partial class FrmUser
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
            menuStrip1 = new MenuStrip();
            个人信息ToolStripMenuItem = new ToolStripMenuItem();
            修改密码ToolStripMenuItem = new ToolStripMenuItem();
            图书借阅管理ToolStripMenuItem = new ToolStripMenuItem();
            退出登录ToolStripMenuItem = new ToolStripMenuItem();
            labelUser = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonHighlight;
            menuStrip1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 个人信息ToolStripMenuItem, 图书借阅管理ToolStripMenuItem, 退出登录ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(911, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 个人信息ToolStripMenuItem
            // 
            个人信息ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 修改密码ToolStripMenuItem });
            个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            个人信息ToolStripMenuItem.Size = new Size(146, 31);
            个人信息ToolStripMenuItem.Text = "个人信息管理";
            // 
            // 修改密码ToolStripMenuItem
            // 
            修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            修改密码ToolStripMenuItem.Size = new Size(178, 32);
            修改密码ToolStripMenuItem.Text = "修改密码";
            修改密码ToolStripMenuItem.Click += 修改密码ToolStripMenuItem_Click;
            // 
            // 图书借阅管理ToolStripMenuItem
            // 
            图书借阅管理ToolStripMenuItem.Name = "图书借阅管理ToolStripMenuItem";
            图书借阅管理ToolStripMenuItem.Size = new Size(146, 31);
            图书借阅管理ToolStripMenuItem.Text = "图书借阅管理";
            图书借阅管理ToolStripMenuItem.Click += 图书借阅管理ToolStripMenuItem_Click;
            // 
            // 退出登录ToolStripMenuItem
            // 
            退出登录ToolStripMenuItem.ForeColor = Color.IndianRed;
            退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            退出登录ToolStripMenuItem.Size = new Size(106, 31);
            退出登录ToolStripMenuItem.Text = "退出登录";
            退出登录ToolStripMenuItem.Click += 退出登录ToolStripMenuItem_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUser.ForeColor = Color.RosyBrown;
            labelUser.Location = new Point(12, 44);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(52, 27);
            labelUser.TabIndex = 1;
            labelUser.Text = "用户";
            labelUser.Click += labelUser_Click;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.SDU_WHITE;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(911, 543);
            Controls.Add(labelUser);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "FrmUser";
            Text = "FrmUser";
            Load += FrmUser_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 个人信息ToolStripMenuItem;
        private ToolStripMenuItem 修改密码ToolStripMenuItem;
        private ToolStripMenuItem 图书借阅管理ToolStripMenuItem;
        private ToolStripMenuItem 退出登录ToolStripMenuItem;
        private Label labelUser;
    }
}