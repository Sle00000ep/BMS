namespace LibrarySystem
{
    partial class FrmBookBorrow
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
            dgvBook = new DataGridView();
            btnSearch = new Button();
            textKey = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelID = new Label();
            btnYes = new Button();
            btnNo = new Button();
            textNum = new TextBox();
            labelName = new Label();
            label6 = new Label();
            btnIntro = new Button();
            btnMyBook = new Button();
            btnFresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // dgvBook
            // 
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBook.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(62, 136);
            dgvBook.Name = "dgvBook";
            dgvBook.ReadOnly = true;
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 29;
            dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBook.Size = new Size(950, 476);
            dgvBook.TabIndex = 5;
            dgvBook.CellClick += dgvBook_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MintCream;
            btnSearch.Location = new Point(947, 79);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(65, 28);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "检索";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textKey
            // 
            textKey.Location = new Point(690, 80);
            textKey.Name = "textKey";
            textKey.Size = new Size(206, 27);
            textKey.TabIndex = 7;
            textKey.TextChanged += textKey_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(604, 83);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 6;
            label1.Text = "关键词";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 83);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 10;
            label3.Text = "当前选中：";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 650);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 11;
            label4.Text = "数量:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(492, 83);
            labelID.Name = "labelID";
            labelID.Size = new Size(48, 20);
            labelID.TabIndex = 12;
            labelID.Text = "NULL";
            labelID.Click += labelID_Click;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.LavenderBlush;
            btnYes.Location = new Point(506, 641);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 29);
            btnYes.TabIndex = 14;
            btnYes.Text = "确定";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.SeaShell;
            btnNo.Location = new Point(918, 641);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 29);
            btnNo.TabIndex = 15;
            btnNo.Text = "退出";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // textNum
            // 
            textNum.Location = new Point(206, 646);
            textNum.Name = "textNum";
            textNum.Size = new Size(125, 27);
            textNum.TabIndex = 16;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(310, 83);
            labelName.Name = "labelName";
            labelName.Size = new Size(48, 20);
            labelName.TabIndex = 18;
            labelName.Text = "NULL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 83);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 17;
            label6.Text = "当前选中：";
            // 
            // btnIntro
            // 
            btnIntro.BackColor = Color.OldLace;
            btnIntro.Location = new Point(651, 641);
            btnIntro.Name = "btnIntro";
            btnIntro.Size = new Size(94, 29);
            btnIntro.TabIndex = 19;
            btnIntro.Text = "查看简介";
            btnIntro.UseVisualStyleBackColor = false;
            btnIntro.Click += btnIntro_Click;
            // 
            // btnMyBook
            // 
            btnMyBook.BackColor = Color.Honeydew;
            btnMyBook.Location = new Point(947, 17);
            btnMyBook.Name = "btnMyBook";
            btnMyBook.Size = new Size(106, 29);
            btnMyBook.TabIndex = 20;
            btnMyBook.Text = "我的借阅";
            btnMyBook.UseVisualStyleBackColor = false;
            btnMyBook.Click += btnMyBook_Click;
            // 
            // btnFresh
            // 
            btnFresh.BackColor = Color.AliceBlue;
            btnFresh.Location = new Point(786, 641);
            btnFresh.Name = "btnFresh";
            btnFresh.Size = new Size(94, 29);
            btnFresh.TabIndex = 21;
            btnFresh.Text = "刷新";
            btnFresh.UseVisualStyleBackColor = false;
            btnFresh.Click += btnFresh_Click;
            // 
            // FrmBookBorrow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.sdu4;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1092, 734);
            Controls.Add(btnFresh);
            Controls.Add(btnMyBook);
            Controls.Add(btnIntro);
            Controls.Add(labelName);
            Controls.Add(label6);
            Controls.Add(textNum);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(labelID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSearch);
            Controls.Add(textKey);
            Controls.Add(label1);
            Controls.Add(dgvBook);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBookBorrow";
            Text = "图书借阅管理";
            Load += FrmBookBorrow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvBook;
        private Button btnSearch;
        private TextBox textKey;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label labelID;
        private Button btnYes;
        private Button btnNo;
        private TextBox textNum;
        private Label labelName;
        private Label label6;
        private Button btnIntro;
        private Button btnMyBook;
        private Button btnFresh;
    }
}