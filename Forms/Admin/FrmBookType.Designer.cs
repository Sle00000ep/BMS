namespace LibrarySystem
{
    partial class FrmBookType
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
            textAlter = new TextBox();
            btnDelete = new Button();
            btnAlter = new Button();
            label3 = new Label();
            textAdd = new TextBox();
            labelType = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnFresh = new Button();
            btnBack = new Button();
            btnSearch = new Button();
            textKey = new TextBox();
            label1 = new Label();
            dgvBookType = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBookType).BeginInit();
            SuspendLayout();
            // 
            // textAlter
            // 
            textAlter.Location = new Point(573, 200);
            textAlter.Name = "textAlter";
            textAlter.Size = new Size(155, 27);
            textAlter.TabIndex = 32;
            textAlter.TextChanged += textAlter_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MintCream;
            btnDelete.Location = new Point(779, 153);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "删除";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAlter
            // 
            btnAlter.BackColor = Color.LightYellow;
            btnAlter.Location = new Point(779, 200);
            btnAlter.Name = "btnAlter";
            btnAlter.Size = new Size(94, 27);
            btnAlter.TabIndex = 30;
            btnAlter.Text = "修改";
            btnAlter.UseVisualStyleBackColor = false;
            btnAlter.Click += btnAlter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 94);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 29;
            label3.Text = "添加项";
            // 
            // textAdd
            // 
            textAdd.Location = new Point(573, 91);
            textAdd.Name = "textAdd";
            textAdd.Size = new Size(155, 27);
            textAdd.TabIndex = 28;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(573, 157);
            labelType.Name = "labelType";
            labelType.Size = new Size(48, 20);
            labelType.TabIndex = 27;
            labelType.Text = "NULL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 157);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 26;
            label2.Text = "当前选中：";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LavenderBlush;
            btnAdd.Location = new Point(779, 91);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 28);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "添加";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFresh
            // 
            btnFresh.BackColor = Color.Linen;
            btnFresh.Location = new Point(779, 569);
            btnFresh.Name = "btnFresh";
            btnFresh.Size = new Size(94, 29);
            btnFresh.TabIndex = 24;
            btnFresh.Text = "刷新";
            btnFresh.UseVisualStyleBackColor = false;
            btnFresh.Click += btnFresh_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OldLace;
            btnBack.Location = new Point(634, 569);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 31);
            btnBack.TabIndex = 23;
            btnBack.Text = "返回";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.AliceBlue;
            btnSearch.Location = new Point(305, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(57, 29);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "速览";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textKey
            // 
            textKey.Location = new Point(83, 95);
            textKey.Name = "textKey";
            textKey.Size = new Size(202, 27);
            textKey.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 98);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 20;
            label1.Text = "关键词";
            // 
            // dgvBookType
            // 
            dgvBookType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookType.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBookType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookType.Location = new Point(23, 142);
            dgvBookType.Name = "dgvBookType";
            dgvBookType.ReadOnly = true;
            dgvBookType.RowHeadersWidth = 51;
            dgvBookType.RowTemplate.Height = 29;
            dgvBookType.Size = new Size(339, 458);
            dgvBookType.TabIndex = 19;
            dgvBookType.CellClick += dgvBookType_CellClick;
            dgvBookType.CellContentClick += dgvBookType_CellContentClick_1;
            // 
            // FrmBookType
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(896, 690);
            Controls.Add(textAlter);
            Controls.Add(btnDelete);
            Controls.Add(btnAlter);
            Controls.Add(label3);
            Controls.Add(textAdd);
            Controls.Add(labelType);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(btnFresh);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(textKey);
            Controls.Add(label1);
            Controls.Add(dgvBookType);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBookType";
            Text = "图书类别管理";
            Load += FrmBookType_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAlter;
        private Button btnDelete;
        private Button btnAlter;
        private Label label3;
        private TextBox textAdd;
        private Label labelType;
        private Label label2;
        private Button btnAdd;
        private Button btnFresh;
        private Button btnBack;
        private Button btnSearch;
        private TextBox textKey;
        private Label label1;
        private DataGridView dgvBookType;
    }
}