namespace LibrarySystem
{
    partial class FrmBook
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnAdd = new Button();
            btnAlter = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            dgvBook = new DataGridView();
            textKey = new TextBox();
            label1 = new Label();
            btnFresh = new Button();
            label2 = new Label();
            labelID = new Label();
            labelName = new Label();
            label5 = new Label();
            btnViewIntro = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Azure;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(737, 670);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAlter
            // 
            btnAlter.BackColor = Color.OldLace;
            btnAlter.ForeColor = SystemColors.ActiveCaptionText;
            btnAlter.Location = new Point(154, 670);
            btnAlter.Name = "btnAlter";
            btnAlter.Size = new Size(94, 29);
            btnAlter.TabIndex = 1;
            btnAlter.Text = "修改";
            btnAlter.UseVisualStyleBackColor = false;
            btnAlter.Click += btnAlter_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LavenderBlush;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(32, 670);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LemonChiffon;
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(868, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvBook
            // 
            dgvBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBook.BackgroundColor = SystemColors.ControlLightLight;
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBook.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBook.GridColor = SystemColors.ActiveCaptionText;
            dgvBook.Location = new Point(12, 103);
            dgvBook.Name = "dgvBook";
            dgvBook.ReadOnly = true;
            dgvBook.RowHeadersWidth = 51;
            dgvBook.RowTemplate.Height = 29;
            dgvBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBook.Size = new Size(933, 535);
            dgvBook.TabIndex = 4;
            dgvBook.CellClick += dgvBook_CellClick;
            dgvBook.CellContentClick += dgvBook_CellContentClick;
            // 
            // textKey
            // 
            textKey.Location = new Point(628, 57);
            textKey.Name = "textKey";
            textKey.Size = new Size(203, 27);
            textKey.TabIndex = 5;
            textKey.TextChanged += textKey_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 60);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 6;
            label1.Text = "关键字";
            // 
            // btnFresh
            // 
            btnFresh.BackColor = Color.GhostWhite;
            btnFresh.ForeColor = SystemColors.ActiveCaptionText;
            btnFresh.Location = new Point(851, 670);
            btnFresh.Name = "btnFresh";
            btnFresh.Size = new Size(94, 29);
            btnFresh.TabIndex = 7;
            btnFresh.Text = "刷新";
            btnFresh.UseVisualStyleBackColor = false;
            btnFresh.Click += btnFresh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(276, 21);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "当前选中";
            label2.Click += label2_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.ForeColor = SystemColors.ActiveCaptionText;
            labelID.Location = new Point(385, 21);
            labelID.Name = "labelID";
            labelID.Size = new Size(48, 20);
            labelID.TabIndex = 9;
            labelID.Text = "NULL";
            labelID.Click += labelID_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.ForeColor = SystemColors.ActiveCaptionText;
            labelName.Location = new Point(385, 65);
            labelName.Name = "labelName";
            labelName.Size = new Size(48, 20);
            labelName.TabIndex = 11;
            labelName.Text = "NULL";
            labelName.Click += labelName_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(276, 65);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "当前选中";
            // 
            // btnViewIntro
            // 
            btnViewIntro.BackColor = Color.MintCream;
            btnViewIntro.ForeColor = SystemColors.ActiveCaptionText;
            btnViewIntro.Location = new Point(276, 670);
            btnViewIntro.Name = "btnViewIntro";
            btnViewIntro.Size = new Size(94, 29);
            btnViewIntro.TabIndex = 12;
            btnViewIntro.Text = "查看简介";
            btnViewIntro.UseVisualStyleBackColor = false;
            btnViewIntro.Click += btnViewIntro_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.AliceBlue;
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(868, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 23;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FrmBook
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.sdu4;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(974, 753);
            Controls.Add(btnBack);
            Controls.Add(btnViewIntro);
            Controls.Add(labelName);
            Controls.Add(label5);
            Controls.Add(labelID);
            Controls.Add(label2);
            Controls.Add(btnFresh);
            Controls.Add(label1);
            Controls.Add(textKey);
            Controls.Add(dgvBook);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAlter);
            Controls.Add(btnAdd);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBook";
            Text = "图书管理";
            Load += FrmBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnAlter;
        private Button btnDelete;
        private Button btnSearch;
        private DataGridView dgvBook;
        private TextBox textKey;
        private Label label1;
        private Button btnFresh;
        private Label label2;
        private Label labelID;
        private Label labelName;
        private Label label5;
        private Button btnViewIntro;
        private Button btnBack;
    }
}