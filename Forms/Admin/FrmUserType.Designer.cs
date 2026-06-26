namespace LibrarySystem
{
    partial class FrmUserType
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
            btnFresh = new Button();
            btnBack = new Button();
            dgvUserType = new DataGridView();
            cmbType1 = new ComboBox();
            label4 = new Label();
            textAlter = new TextBox();
            btnDelete = new Button();
            btnAlter = new Button();
            label3 = new Label();
            textAdd = new TextBox();
            labelType = new Label();
            label2 = new Label();
            btnAdd = new Button();
            label5 = new Label();
            btnSearch = new Button();
            textKey = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUserType).BeginInit();
            SuspendLayout();
            // 
            // btnFresh
            // 
            btnFresh.BackColor = Color.MintCream;
            btnFresh.Location = new Point(772, 657);
            btnFresh.Name = "btnFresh";
            btnFresh.Size = new Size(94, 28);
            btnFresh.TabIndex = 24;
            btnFresh.Text = "刷新";
            btnFresh.UseVisualStyleBackColor = false;
            btnFresh.Click += btnFresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.AliceBlue;
            btnBack.Location = new Point(773, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 31);
            btnBack.TabIndex = 23;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvUserType
            // 
            dgvUserType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserType.BackgroundColor = SystemColors.ButtonHighlight;
            dgvUserType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserType.Location = new Point(22, 208);
            dgvUserType.Name = "dgvUserType";
            dgvUserType.ReadOnly = true;
            dgvUserType.RowHeadersWidth = 51;
            dgvUserType.RowTemplate.Height = 29;
            dgvUserType.Size = new Size(332, 477);
            dgvUserType.TabIndex = 19;
            dgvUserType.CellClick += dgvUserType_CellClick;
            dgvUserType.CellContentClick += dgvUserType_CellContentClick;
            // 
            // cmbType1
            // 
            cmbType1.FormattingEnabled = true;
            cmbType1.Items.AddRange(new object[] { "教师", "学生", "社会人员" });
            cmbType1.Location = new Point(76, 148);
            cmbType1.Name = "cmbType1";
            cmbType1.Size = new Size(278, 28);
            cmbType1.TabIndex = 41;
            cmbType1.SelectedValueChanged += cmbType1_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 151);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 42;
            label4.Text = "类别";
            // 
            // textAlter
            // 
            textAlter.Location = new Point(470, 345);
            textAlter.Name = "textAlter";
            textAlter.Size = new Size(263, 27);
            textAlter.TabIndex = 53;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SeaShell;
            btnDelete.Location = new Point(772, 437);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 52;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnAlter
            // 
            btnAlter.BackColor = Color.LightYellow;
            btnAlter.Location = new Point(773, 345);
            btnAlter.Name = "btnAlter";
            btnAlter.Size = new Size(94, 27);
            btnAlter.TabIndex = 51;
            btnAlter.Text = "修改";
            btnAlter.UseVisualStyleBackColor = false;
            btnAlter.Click += btnAlter_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 253);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 50;
            label3.Text = "添加项";
            // 
            // textAdd
            // 
            textAdd.Location = new Point(470, 249);
            textAdd.Name = "textAdd";
            textAdd.Size = new Size(263, 27);
            textAdd.TabIndex = 49;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(482, 441);
            labelType.Name = "labelType";
            labelType.Size = new Size(48, 20);
            labelType.TabIndex = 48;
            labelType.Text = "NULL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 441);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 47;
            label2.Text = "当前选中：";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Honeydew;
            btnAdd.Location = new Point(772, 249);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 28);
            btnAdd.TabIndex = 46;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 345);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 54;
            label5.Text = "修改项";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LavenderBlush;
            btnSearch.Location = new Point(772, 147);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 55;
            btnSearch.Text = "查询";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textKey
            // 
            textKey.Location = new Point(470, 148);
            textKey.Name = "textKey";
            textKey.Size = new Size(263, 27);
            textKey.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 151);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 57;
            label1.Text = "关键词";
            // 
            // FrmUserType
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(878, 724);
            Controls.Add(label1);
            Controls.Add(textKey);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(textAlter);
            Controls.Add(btnDelete);
            Controls.Add(btnAlter);
            Controls.Add(label3);
            Controls.Add(textAdd);
            Controls.Add(labelType);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(cmbType1);
            Controls.Add(btnFresh);
            Controls.Add(btnBack);
            Controls.Add(dgvUserType);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUserType";
            Text = "读者类别管理";
            Load += FrmReaderType_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFresh;
        private Button btnBack;
        private DataGridView dgvUserType;
        private ComboBox cmbType1;
        private Label label4;
        private TextBox textAlter;
        private Button btnDelete;
        private Button btnAlter;
        private Label label3;
        private TextBox textAdd;
        private Label labelType;
        private Label label2;
        private Button btnAdd;
        private Label label5;
        private Button btnSearch;
        private TextBox textKey;
        private Label label1;
    }
}