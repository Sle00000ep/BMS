namespace LibrarySystem.User
{
    partial class FrmMyBook
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
            dgvBorrow = new DataGridView();
            label1 = new Label();
            textSearch = new TextBox();
            btnSearch = new Button();
            btnReturn = new Button();
            btnCancel = new Button();
            labelName = new Label();
            label3 = new Label();
            labelID = new Label();
            label2 = new Label();
            labelKey = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrow
            // 
            dgvBorrow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrow.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBorrow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrow.GridColor = SystemColors.ButtonShadow;
            dgvBorrow.Location = new Point(41, 134);
            dgvBorrow.Name = "dgvBorrow";
            dgvBorrow.ReadOnly = true;
            dgvBorrow.RowHeadersWidth = 51;
            dgvBorrow.RowTemplate.Height = 29;
            dgvBorrow.Size = new Size(986, 447);
            dgvBorrow.TabIndex = 0;
            dgvBorrow.CellClick += dgvBorrow_CellClick;
            dgvBorrow.CellContentClick += dgvBorrow_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(666, 84);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "关键字";
            // 
            // textSearch
            // 
            textSearch.Location = new Point(741, 81);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(186, 27);
            textSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGoldenrodYellow;
            btnSearch.Location = new Point(933, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "检索";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.LavenderBlush;
            btnReturn.Location = new Point(349, 647);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "归还";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.AliceBlue;
            btnCancel.Location = new Point(654, 647);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "返回";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(516, 84);
            labelName.Name = "labelName";
            labelName.Size = new Size(48, 20);
            labelName.TabIndex = 15;
            labelName.Text = "NULL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 84);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 14;
            label3.Text = "书名：";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(336, 84);
            labelID.Name = "labelID";
            labelID.Size = new Size(48, 20);
            labelID.TabIndex = 17;
            labelID.Text = "NULL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 16;
            label2.Text = "书号：";
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Location = new Point(160, 84);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(48, 20);
            labelKey.TabIndex = 19;
            labelKey.Text = "NULL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 84);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 18;
            label4.Text = "键：";
            // 
            // FrmMyBook
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.sdu4;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1096, 725);
            Controls.Add(labelKey);
            Controls.Add(label4);
            Controls.Add(labelID);
            Controls.Add(label2);
            Controls.Add(labelName);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnReturn);
            Controls.Add(btnSearch);
            Controls.Add(textSearch);
            Controls.Add(label1);
            Controls.Add(dgvBorrow);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMyBook";
            Text = "FrmMyBook";
            Load += FrmMyBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrow;
        private Label label1;
        private TextBox textSearch;
        private Button btnSearch;
        private Button btnReturn;
        private Button btnCancel;
        private Label labelName;
        private Label label3;
        private Label labelID;
        private Label label2;
        private Label labelKey;
        private Label label4;
    }
}