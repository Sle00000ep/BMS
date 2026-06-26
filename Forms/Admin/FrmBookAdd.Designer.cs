namespace LibrarySystem.Book
{
    partial class FrmBookAdd
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
            buttonCancel = new Button();
            buttonAdd = new Button();
            dtpPress = new DateTimePicker();
            cmbType = new ComboBox();
            textIntro = new TextBox();
            label9 = new Label();
            textNum = new TextBox();
            label5 = new Label();
            textPrice = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textPress = new TextBox();
            label3 = new Label();
            textAuthor = new TextBox();
            label4 = new Label();
            textBookName = new TextBox();
            label2 = new Label();
            textBookID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Honeydew;
            buttonCancel.Location = new Point(483, 677);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(95, 39);
            buttonCancel.TabIndex = 45;
            buttonCancel.Text = "取消";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Linen;
            buttonAdd.Location = new Point(197, 677);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(95, 39);
            buttonAdd.TabIndex = 44;
            buttonAdd.Text = "添加";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dtpPress
            // 
            dtpPress.Location = new Point(279, 296);
            dtpPress.Name = "dtpPress";
            dtpPress.Size = new Size(250, 27);
            dtpPress.TabIndex = 43;
            // 
            // cmbType
            // 
            cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbType.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(279, 351);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(250, 28);
            cmbType.TabIndex = 42;
            cmbType.UseWaitCursor = true;
            // 
            // textIntro
            // 
            textIntro.Location = new Point(279, 502);
            textIntro.MaxLength = 199;
            textIntro.Multiline = true;
            textIntro.Name = "textIntro";
            textIntro.Size = new Size(250, 115);
            textIntro.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(197, 502);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 40;
            label9.Text = "简介";
            // 
            // textNum
            // 
            textNum.Location = new Point(279, 451);
            textNum.Name = "textNum";
            textNum.Size = new Size(250, 27);
            textNum.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 454);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 38;
            label5.Text = "数量";
            // 
            // textPrice
            // 
            textPrice.Location = new Point(279, 401);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(250, 27);
            textPrice.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 404);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 36;
            label6.Text = "价格";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(197, 351);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 35;
            label7.Text = "类别";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(197, 301);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 34;
            label8.Text = "出版日期";
            // 
            // textPress
            // 
            textPress.Location = new Point(279, 245);
            textPress.Name = "textPress";
            textPress.Size = new Size(250, 27);
            textPress.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 248);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 32;
            label3.Text = "出版社";
            // 
            // textAuthor
            // 
            textAuthor.Location = new Point(279, 195);
            textAuthor.Name = "textAuthor";
            textAuthor.Size = new Size(250, 27);
            textAuthor.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 198);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 30;
            label4.Text = "作者";
            // 
            // textBookName
            // 
            textBookName.Location = new Point(279, 142);
            textBookName.Name = "textBookName";
            textBookName.Size = new Size(250, 27);
            textBookName.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 145);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 28;
            label2.Text = "书名";
            // 
            // textBookID
            // 
            textBookID.Location = new Point(279, 92);
            textBookID.Name = "textBookID";
            textBookID.Size = new Size(250, 27);
            textBookID.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 95);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 26;
            label1.Text = "编号";
            // 
            // FrmBookAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = Properties.Resources.SDU_2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 748);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAdd);
            Controls.Add(dtpPress);
            Controls.Add(cmbType);
            Controls.Add(textIntro);
            Controls.Add(label9);
            Controls.Add(textNum);
            Controls.Add(label5);
            Controls.Add(textPrice);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textPress);
            Controls.Add(label3);
            Controls.Add(textAuthor);
            Controls.Add(label4);
            Controls.Add(textBookName);
            Controls.Add(label2);
            Controls.Add(textBookID);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBookAdd";
            Text = "添加";
            Load += FrmBookAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancel;
        private Button buttonAdd;
        private DateTimePicker dtpPress;
        private ComboBox cmbType;
        private TextBox textIntro;
        private Label label9;
        private TextBox textNum;
        private Label label5;
        private TextBox textPrice;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textPress;
        private Label label3;
        private TextBox textAuthor;
        private Label label4;
        private TextBox textBookName;
        private Label label2;
        private TextBox textBookID;
        private Label label1;
    }
}