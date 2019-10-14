namespace BookService
{
    partial class BookForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.displayBooksBtn = new System.Windows.Forms.Button();
            this.displayAuthorsBtn = new System.Windows.Forms.Button();
            this.bookAuthorSearchBtn = new System.Windows.Forms.Button();
            this.bookYearSearchBtn = new System.Windows.Forms.Button();
            this.bookAuthorSearchText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.bookAddBtn = new System.Windows.Forms.Button();
            this.authorAddBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newBookErr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yearPubText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.newAuthErr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.authorNameText = new System.Windows.Forms.TextBox();
            this.linkErr = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ascendingBtn = new System.Windows.Forms.Button();
            this.descendingBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.topRatedNumber = new System.Windows.Forms.NumericUpDown();
            this.topRatedBtn = new System.Windows.Forms.Button();
            this.leastFavBtn = new System.Windows.Forms.Button();
            this.betweenYearsBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxYears = new System.Windows.Forms.NumericUpDown();
            this.minYears = new System.Windows.Forms.NumericUpDown();
            this.bookYearSearchInt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookFilterText = new System.Windows.Forms.TextBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topRatedNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookYearSearchInt)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 17);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(189, 303);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // displayBooksBtn
            // 
            this.displayBooksBtn.Location = new System.Drawing.Point(8, 38);
            this.displayBooksBtn.Name = "displayBooksBtn";
            this.displayBooksBtn.Size = new System.Drawing.Size(79, 23);
            this.displayBooksBtn.TabIndex = 1;
            this.displayBooksBtn.Text = "All Books";
            this.displayBooksBtn.UseVisualStyleBackColor = true;
            this.displayBooksBtn.Click += new System.EventHandler(this.displayBooksBtn_Click);
            // 
            // displayAuthorsBtn
            // 
            this.displayAuthorsBtn.Location = new System.Drawing.Point(93, 38);
            this.displayAuthorsBtn.Name = "displayAuthorsBtn";
            this.displayAuthorsBtn.Size = new System.Drawing.Size(79, 23);
            this.displayAuthorsBtn.TabIndex = 2;
            this.displayAuthorsBtn.Text = "All Authors";
            this.displayAuthorsBtn.UseVisualStyleBackColor = true;
            this.displayAuthorsBtn.Click += new System.EventHandler(this.displayAuthorsBtn_Click);
            // 
            // bookAuthorSearchBtn
            // 
            this.bookAuthorSearchBtn.Location = new System.Drawing.Point(114, 149);
            this.bookAuthorSearchBtn.Name = "bookAuthorSearchBtn";
            this.bookAuthorSearchBtn.Size = new System.Drawing.Size(59, 23);
            this.bookAuthorSearchBtn.TabIndex = 3;
            this.bookAuthorSearchBtn.Text = "Search";
            this.bookAuthorSearchBtn.UseVisualStyleBackColor = true;
            this.bookAuthorSearchBtn.Click += new System.EventHandler(this.bookAuthorSearchBtn_Click);
            // 
            // bookYearSearchBtn
            // 
            this.bookYearSearchBtn.Location = new System.Drawing.Point(114, 193);
            this.bookYearSearchBtn.Name = "bookYearSearchBtn";
            this.bookYearSearchBtn.Size = new System.Drawing.Size(59, 23);
            this.bookYearSearchBtn.TabIndex = 4;
            this.bookYearSearchBtn.Text = "Search";
            this.bookYearSearchBtn.UseVisualStyleBackColor = true;
            this.bookYearSearchBtn.Click += new System.EventHandler(this.bookYearSearchBtn_Click);
            // 
            // bookAuthorSearchText
            // 
            this.bookAuthorSearchText.Location = new System.Drawing.Point(11, 151);
            this.bookAuthorSearchText.Name = "bookAuthorSearchText";
            this.bookAuthorSearchText.Size = new System.Drawing.Size(97, 20);
            this.bookAuthorSearchText.TabIndex = 5;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(41, 18);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(102, 20);
            this.titleText.TabIndex = 7;
            // 
            // bookAddBtn
            // 
            this.bookAddBtn.Location = new System.Drawing.Point(90, 100);
            this.bookAddBtn.Name = "bookAddBtn";
            this.bookAddBtn.Size = new System.Drawing.Size(53, 23);
            this.bookAddBtn.TabIndex = 8;
            this.bookAddBtn.Text = "Add";
            this.bookAddBtn.UseVisualStyleBackColor = true;
            this.bookAddBtn.Click += new System.EventHandler(this.bookAddBtn_Click);
            // 
            // authorAddBtn
            // 
            this.authorAddBtn.Location = new System.Drawing.Point(100, 43);
            this.authorAddBtn.Name = "authorAddBtn";
            this.authorAddBtn.Size = new System.Drawing.Size(43, 23);
            this.authorAddBtn.TabIndex = 14;
            this.authorAddBtn.Text = "Add";
            this.authorAddBtn.UseVisualStyleBackColor = true;
            this.authorAddBtn.Click += new System.EventHandler(this.authorAddBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newBookErr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.yearPubText);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.isbnText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titleText);
            this.groupBox1.Controls.Add(this.bookAddBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 148);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Book";
            // 
            // newBookErr
            // 
            this.newBookErr.AutoSize = true;
            this.newBookErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newBookErr.Location = new System.Drawing.Point(6, 126);
            this.newBookErr.Name = "newBookErr";
            this.newBookErr.Size = new System.Drawing.Size(117, 13);
            this.newBookErr.TabIndex = 14;
            this.newBookErr.Text = "Error adding new book.";
            this.newBookErr.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Publication year";
            // 
            // yearPubText
            // 
            this.yearPubText.Location = new System.Drawing.Point(90, 74);
            this.yearPubText.Name = "yearPubText";
            this.yearPubText.Size = new System.Drawing.Size(53, 20);
            this.yearPubText.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ISBN";
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(41, 46);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(102, 20);
            this.isbnText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.newAuthErr);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nameText);
            this.groupBox2.Controls.Add(this.authorAddBtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 148);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Author";
            // 
            // newAuthErr
            // 
            this.newAuthErr.AutoSize = true;
            this.newAuthErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newAuthErr.Location = new System.Drawing.Point(6, 132);
            this.newAuthErr.Name = "newAuthErr";
            this.newAuthErr.Size = new System.Drawing.Size(123, 13);
            this.newAuthErr.TabIndex = 17;
            this.newAuthErr.Text = "Error adding new author.";
            this.newAuthErr.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(47, 17);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(96, 20);
            this.nameText.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.authorNameText);
            this.groupBox3.Controls.Add(this.linkErr);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.bookNameText);
            this.groupBox3.Controls.Add(this.mergeBtn);
            this.groupBox3.Location = new System.Drawing.Point(6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 148);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Link Book and Author";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Author name";
            // 
            // authorNameText
            // 
            this.authorNameText.Location = new System.Drawing.Point(6, 82);
            this.authorNameText.Name = "authorNameText";
            this.authorNameText.Size = new System.Drawing.Size(137, 20);
            this.authorNameText.TabIndex = 18;
            // 
            // linkErr
            // 
            this.linkErr.AutoSize = true;
            this.linkErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkErr.Location = new System.Drawing.Point(3, 132);
            this.linkErr.Name = "linkErr";
            this.linkErr.Size = new System.Drawing.Size(103, 13);
            this.linkErr.TabIndex = 17;
            this.linkErr.Text = "Error performing link.";
            this.linkErr.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Book name";
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(6, 39);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(137, 20);
            this.bookNameText.TabIndex = 15;
            // 
            // mergeBtn
            // 
            this.mergeBtn.Location = new System.Drawing.Point(89, 108);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(54, 23);
            this.mergeBtn.TabIndex = 14;
            this.mergeBtn.Text = "Link";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.topRatedNumber);
            this.groupBox4.Controls.Add(this.topRatedBtn);
            this.groupBox4.Controls.Add(this.leastFavBtn);
            this.groupBox4.Controls.Add(this.betweenYearsBtn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label123);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.maxYears);
            this.groupBox4.Controls.Add(this.minYears);
            this.groupBox4.Controls.Add(this.bookYearSearchInt);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.displayBooksBtn);
            this.groupBox4.Controls.Add(this.displayAuthorsBtn);
            this.groupBox4.Controls.Add(this.bookAuthorSearchText);
            this.groupBox4.Controls.Add(this.bookAuthorSearchBtn);
            this.groupBox4.Controls.Add(this.bookYearSearchBtn);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 297);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search list";
            // 
            // ascendingBtn
            // 
            this.ascendingBtn.Location = new System.Drawing.Point(9, 225);
            this.ascendingBtn.Name = "ascendingBtn";
            this.ascendingBtn.Size = new System.Drawing.Size(75, 23);
            this.ascendingBtn.TabIndex = 36;
            this.ascendingBtn.Text = "Ascending";
            this.ascendingBtn.UseVisualStyleBackColor = true;
            this.ascendingBtn.Click += new System.EventHandler(this.ascendingBtn_Click);
            // 
            // descendingBtn
            // 
            this.descendingBtn.Location = new System.Drawing.Point(102, 225);
            this.descendingBtn.Name = "descendingBtn";
            this.descendingBtn.Size = new System.Drawing.Size(75, 23);
            this.descendingBtn.TabIndex = 35;
            this.descendingBtn.Text = "Descending";
            this.descendingBtn.UseVisualStyleBackColor = true;
            this.descendingBtn.Click += new System.EventHandler(this.descendingBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Search top rated books:";
            // 
            // topRatedNumber
            // 
            this.topRatedNumber.Location = new System.Drawing.Point(11, 109);
            this.topRatedNumber.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.topRatedNumber.Name = "topRatedNumber";
            this.topRatedNumber.Size = new System.Drawing.Size(64, 20);
            this.topRatedNumber.TabIndex = 32;
            this.topRatedNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // topRatedBtn
            // 
            this.topRatedBtn.Location = new System.Drawing.Point(107, 108);
            this.topRatedBtn.Name = "topRatedBtn";
            this.topRatedBtn.Size = new System.Drawing.Size(66, 23);
            this.topRatedBtn.TabIndex = 29;
            this.topRatedBtn.Text = "Display";
            this.topRatedBtn.UseVisualStyleBackColor = true;
            this.topRatedBtn.Click += new System.EventHandler(this.topRatedBtn_Click);
            // 
            // leastFavBtn
            // 
            this.leastFavBtn.Location = new System.Drawing.Point(9, 66);
            this.leastFavBtn.Name = "leastFavBtn";
            this.leastFavBtn.Size = new System.Drawing.Size(163, 22);
            this.leastFavBtn.TabIndex = 28;
            this.leastFavBtn.Text = "Display least Favourite books";
            this.leastFavBtn.UseVisualStyleBackColor = true;
            this.leastFavBtn.Click += new System.EventHandler(this.leastFavBtn_Click);
            // 
            // betweenYearsBtn
            // 
            this.betweenYearsBtn.Location = new System.Drawing.Point(124, 256);
            this.betweenYearsBtn.Name = "betweenYearsBtn";
            this.betweenYearsBtn.Size = new System.Drawing.Size(49, 23);
            this.betweenYearsBtn.TabIndex = 27;
            this.betweenYearsBtn.Text = "Search";
            this.betweenYearsBtn.UseVisualStyleBackColor = true;
            this.betweenYearsBtn.Click += new System.EventHandler(this.betweenYearsBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "End year";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(8, 240);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(52, 13);
            this.label123.TabIndex = 25;
            this.label123.Text = "Start year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Search book(s) between years:";
            // 
            // maxYears
            // 
            this.maxYears.Location = new System.Drawing.Point(70, 259);
            this.maxYears.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.maxYears.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxYears.Name = "maxYears";
            this.maxYears.Size = new System.Drawing.Size(47, 20);
            this.maxYears.TabIndex = 23;
            this.maxYears.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // minYears
            // 
            this.minYears.Location = new System.Drawing.Point(11, 259);
            this.minYears.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.minYears.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minYears.Name = "minYears";
            this.minYears.Size = new System.Drawing.Size(49, 20);
            this.minYears.TabIndex = 22;
            this.minYears.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // bookYearSearchInt
            // 
            this.bookYearSearchInt.Location = new System.Drawing.Point(11, 196);
            this.bookYearSearchInt.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.bookYearSearchInt.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bookYearSearchInt.Name = "bookYearSearchInt";
            this.bookYearSearchInt.Size = new System.Drawing.Size(61, 20);
            this.bookYearSearchInt.TabIndex = 21;
            this.bookYearSearchInt.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search book(s) by author:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Search book(s) by specific year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Filter list items by:";
            // 
            // bookFilterText
            // 
            this.bookFilterText.Location = new System.Drawing.Point(7, 41);
            this.bookFilterText.Name = "bookFilterText";
            this.bookFilterText.Size = new System.Drawing.Size(58, 20);
            this.bookFilterText.TabIndex = 31;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(6, 67);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(73, 23);
            this.filterBtn.TabIndex = 30;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox);
            this.groupBox5.Location = new System.Drawing.Point(181, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(201, 333);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Book service";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(6, 21);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save search as .txt";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(171, 186);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(163, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(163, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Author";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(163, 160);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Link";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // infoTextBox
            // 
            this.infoTextBox.AcceptsReturn = true;
            this.infoTextBox.Location = new System.Drawing.Point(4, 195);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTextBox.Size = new System.Drawing.Size(171, 144);
            this.infoTextBox.TabIndex = 21;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(388, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 336);
            this.tabControl2.TabIndex = 22;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(192, 310);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Search list";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox7);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(192, 310);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Filter list";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton6);
            this.groupBox7.Controls.Add(this.radioButton5);
            this.groupBox7.Controls.Add(this.ascendingBtn);
            this.groupBox7.Controls.Add(this.descendingBtn);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.radioButton4);
            this.groupBox7.Controls.Add(this.radioButton3);
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Controls.Add(this.filterBtn);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.bookFilterText);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(183, 298);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Filter list";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Sort list items by:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(109, 202);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 17);
            this.radioButton4.TabIndex = 39;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Rating";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 202);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(102, 17);
            this.radioButton3.TabIndex = 38;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Publication Year";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 179);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 37;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ISBN";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Book Title";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 310);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Manage Data";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.saveBtn);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 297);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data management";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load data from csv";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "(Reset Search)";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(109, 179);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton5.Size = new System.Drawing.Size(77, 17);
            this.radioButton5.TabIndex = 41;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "User Votes";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(109, 156);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton6.Size = new System.Drawing.Size(87, 17);
            this.radioButton6.TabIndex = 42;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Author Name";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 343);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topRatedNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookYearSearchInt)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button displayBooksBtn;
        private System.Windows.Forms.Button displayAuthorsBtn;
        private System.Windows.Forms.Button bookAuthorSearchBtn;
        private System.Windows.Forms.Button bookYearSearchBtn;
        private System.Windows.Forms.TextBox bookAuthorSearchText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Button bookAddBtn;
        private System.Windows.Forms.Button authorAddBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label newBookErr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yearPubText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label newAuthErr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox authorNameText;
        private System.Windows.Forms.Label linkErr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.Button mergeBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown bookYearSearchInt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxYears;
        private System.Windows.Forms.NumericUpDown minYears;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Button betweenYearsBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown topRatedNumber;
        private System.Windows.Forms.TextBox bookFilterText;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button topRatedBtn;
        private System.Windows.Forms.Button leastFavBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ascendingBtn;
        private System.Windows.Forms.Button descendingBtn;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}

