namespace LibrarySystem.Book
{
    partial class FrmBookAlter
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
            textIntro = new TextBox();
            label6 = new Label();
            textoutNum = new TextBox();
            label7 = new Label();
            textinNum = new TextBox();
            label8 = new Label();
            textPrice = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label1 = new Label();
            textPress = new TextBox();
            labelPress = new Label();
            textAuthor = new TextBox();
            labelAuthor = new Label();
            textBookName = new TextBox();
            labelBookName = new Label();
            textBookID = new TextBox();
            labelBookID = new Label();
            dtpPressDate = new DateTimePicker();
            cmbType = new ComboBox();
            btnYes = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // textIntro
            // 
            textIntro.Location = new Point(642, 359);
            textIntro.Multiline = true;
            textIntro.Name = "textIntro";
            textIntro.Size = new Size(255, 122);
            textIntro.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(566, 362);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 18;
            label6.Text = "简介";
            // 
            // textoutNum
            // 
            textoutNum.Location = new Point(831, 270);
            textoutNum.Name = "textoutNum";
            textoutNum.Size = new Size(66, 27);
            textoutNum.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(759, 277);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 16;
            label7.Text = "借出";
            // 
            // textinNum
            // 
            textinNum.Location = new Point(642, 274);
            textinNum.Name = "textinNum";
            textinNum.Size = new Size(66, 27);
            textinNum.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(566, 277);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 14;
            label8.Text = "馆藏";
            // 
            // textPrice
            // 
            textPrice.Location = new Point(642, 182);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(255, 27);
            textPrice.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(566, 185);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 12;
            label9.Text = "价格";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(566, 100);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 10;
            label10.Text = "类型";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 454);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 28;
            label1.Text = "出版日期";
            // 
            // textPress
            // 
            textPress.Location = new Point(244, 359);
            textPress.Name = "textPress";
            textPress.Size = new Size(255, 27);
            textPress.TabIndex = 27;
            // 
            // labelPress
            // 
            labelPress.AutoSize = true;
            labelPress.Location = new Point(153, 359);
            labelPress.Name = "labelPress";
            labelPress.Size = new Size(54, 20);
            labelPress.TabIndex = 26;
            labelPress.Text = "出版社";
            // 
            // textAuthor
            // 
            textAuthor.Location = new Point(244, 274);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(255, 27);
            textAuthor.TabIndex = 25;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new Point(168, 277);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(39, 20);
            labelAuthor.TabIndex = 24;
            labelAuthor.Text = "作者";
            // 
            // textBookName
            // 
            textBookName.Location = new Point(244, 182);
            textBookName.Name = "textBookName";
            textBookName.Size = new Size(255, 27);
            textBookName.TabIndex = 23;
            // 
            // labelBookName
            // 
            labelBookName.AutoSize = true;
            labelBookName.Location = new Point(168, 185);
            labelBookName.Name = "labelBookName";
            labelBookName.Size = new Size(39, 20);
            labelBookName.TabIndex = 22;
            labelBookName.Text = "书名";
            // 
            // textBookID
            // 
            textBookID.Location = new Point(244, 97);
            textBookID.Name = "textBookID";
            textBookID.Size = new Size(255, 27);
            textBookID.TabIndex = 21;
            // 
            // labelBookID
            // 
            labelBookID.AutoSize = true;
            labelBookID.Location = new Point(168, 100);
            labelBookID.Name = "labelBookID";
            labelBookID.Size = new Size(39, 20);
            labelBookID.TabIndex = 20;
            labelBookID.Text = "书号";
            // 
            // dtpPressDate
            // 
            dtpPressDate.Location = new Point(244, 454);
            dtpPressDate.Name = "dtpPressDate";
            dtpPressDate.Size = new Size(255, 27);
            dtpPressDate.TabIndex = 29;
            // 
            // cmbType
            // 
            cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(642, 97);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(255, 28);
            cmbType.TabIndex = 30;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.OldLace;
            btnYes.Location = new Point(297, 610);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(119, 45);
            btnYes.TabIndex = 31;
            btnYes.Text = "确定";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.LavenderBlush;
            btnNo.Location = new Point(598, 610);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(119, 45);
            btnNo.TabIndex = 32;
            btnNo.Text = "取消";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // FrmBookAlter
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1091, 747);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(cmbType);
            Controls.Add(dtpPressDate);
            Controls.Add(label1);
            Controls.Add(textPress);
            Controls.Add(labelPress);
            Controls.Add(textAuthor);
            Controls.Add(labelAuthor);
            Controls.Add(textBookName);
            Controls.Add(labelBookName);
            Controls.Add(textBookID);
            Controls.Add(labelBookID);
            Controls.Add(textIntro);
            Controls.Add(label6);
            Controls.Add(textoutNum);
            Controls.Add(label7);
            Controls.Add(textinNum);
            Controls.Add(label8);
            Controls.Add(textPrice);
            Controls.Add(label9);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBookAlter";
            Text = "FrmBookAlter";
            Load += FrmBookAlter_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textIntro;
        private Label label6;
        private TextBox textoutNum;
        private Label label7;
        private TextBox textinNum;
        private Label label8;
        private TextBox textPrice;
        private Label label9;
        private TextBox textBox10;
        private Label label10;
        private TextBox textBox1;
        private Label label1;
        private TextBox textPress;
        private Label labelPress;
        private TextBox textAuthor;
        private Label labelAuthor;
        private TextBox textBookName;
        private Label labelBookName;
        private TextBox textBookID;
        private Label labelBookID;
        private DateTimePicker dtpPressDate;
        private ComboBox cmbType;
        private Button btnYes;
        private Button btnNo;
    }
}