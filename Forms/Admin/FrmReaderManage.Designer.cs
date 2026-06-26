namespace LibrarySystem
{
    partial class FrmReaderManage
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
            dgvUser = new DataGridView();
            label1 = new Label();
            textKey = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnAlter = new Button();
            btnDelete = new Button();
            btnFresh = new Button();
            labelID = new Label();
            label2 = new Label();
            btnBack = new Button();
            labelName = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = SystemColors.ControlLightLight;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(97, 162);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.Size = new Size(881, 404);
            dgvUser.TabIndex = 0;
            dgvUser.CellClick += dgvUser_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(606, 115);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "关键词";
            // 
            // textKey
            // 
            textKey.Location = new Point(677, 111);
            textKey.Name = "textKey";
            textKey.Size = new Size(187, 27);
            textKey.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MintCream;
            btnSearch.Location = new Point(884, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "查找";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Honeydew;
            btnAdd.Location = new Point(727, 613);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAlter
            // 
            btnAlter.BackColor = Color.LavenderBlush;
            btnAlter.Location = new Point(97, 613);
            btnAlter.Name = "btnAlter";
            btnAlter.Size = new Size(94, 29);
            btnAlter.TabIndex = 5;
            btnAlter.Text = "修改";
            btnAlter.UseVisualStyleBackColor = false;
            btnAlter.Click += btnAlter_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.Location = new Point(240, 613);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFresh
            // 
            btnFresh.BackColor = Color.LightGoldenrodYellow;
            btnFresh.Location = new Point(884, 613);
            btnFresh.Name = "btnFresh";
            btnFresh.Size = new Size(94, 29);
            btnFresh.TabIndex = 7;
            btnFresh.Text = "刷新";
            btnFresh.UseVisualStyleBackColor = false;
            btnFresh.Click += btnFresh_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(176, 111);
            labelID.Name = "labelID";
            labelID.Size = new Size(48, 20);
            labelID.TabIndex = 17;
            labelID.Text = "NULL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 111);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 16;
            label2.Text = "当前选中：";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Cornsilk;
            btnBack.Location = new Point(884, 43);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 22;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(415, 111);
            labelName.Name = "labelName";
            labelName.Size = new Size(48, 20);
            labelName.TabIndex = 24;
            labelName.Text = "NULL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 111);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 23;
            label3.Text = "当前选中：";
            // 
            // FrmReaderManage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1069, 700);
            Controls.Add(labelName);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(labelID);
            Controls.Add(label2);
            Controls.Add(btnFresh);
            Controls.Add(btnDelete);
            Controls.Add(btnAlter);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(textKey);
            Controls.Add(label1);
            Controls.Add(dgvUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReaderManage";
            Text = "读者管理";
            Load += FrmReader_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private Label label1;
        private TextBox textKey;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnAlter;
        private Button btnDelete;
        private Button btnFresh;
        private Label labelID;
        private Label label2;
        private Button btnBack;
        private Label labelName;
        private Label label3;
    }
}