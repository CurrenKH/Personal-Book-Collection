
namespace PBC
{
    partial class PBC
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
            this.label1 = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addSeriesButton = new System.Windows.Forms.Button();
            this.deleteSeriesButton = new System.Windows.Forms.Button();
            this.seriesListBox = new System.Windows.Forms.ListBox();
            this.modifyBookButton = new System.Windows.Forms.Button();
            this.modifySeriesButton = new System.Windows.Forms.Button();
            this.seriesLabel = new System.Windows.Forms.Label();
            this.booksLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.bookTitleInfoLabel = new System.Windows.Forms.Label();
            this.titleInfoLabel = new System.Windows.Forms.Label();
            this.subjectTitleInfoLabel = new System.Windows.Forms.Label();
            this.publisherInfoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountInfoLabel = new System.Windows.Forms.Label();
            this.amountLabel2 = new System.Windows.Forms.Label();
            this.subjectLabel2 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.nameInfoLabel = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.yearLabel2 = new System.Windows.Forms.Label();
            this.authorLabel2 = new System.Windows.Forms.Label();
            this.pagesLabel2 = new System.Windows.Forms.Label();
            this.pagesInfoLabel = new System.Windows.Forms.Label();
            this.yearInfoLabel = new System.Windows.Forms.Label();
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.authorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Book Collection";
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.Location = new System.Drawing.Point(344, 84);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(291, 264);
            this.booksListBox.TabIndex = 1;
            this.booksListBox.SelectedIndexChanged += new System.EventHandler(this.booksListBox_SelectedIndexChanged);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(535, 353);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(99, 41);
            this.addBookButton.TabIndex = 2;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.Location = new System.Drawing.Point(535, 445);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(99, 41);
            this.deleteBookButton.TabIndex = 3;
            this.deleteBookButton.Text = "Delete Book";
            this.deleteBookButton.UseVisualStyleBackColor = true;
            this.deleteBookButton.Click += new System.EventHandler(this.deleteBookButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(714, 449);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 61);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addSeriesButton
            // 
            this.addSeriesButton.Location = new System.Drawing.Point(223, 353);
            this.addSeriesButton.Name = "addSeriesButton";
            this.addSeriesButton.Size = new System.Drawing.Size(99, 41);
            this.addSeriesButton.TabIndex = 5;
            this.addSeriesButton.Text = "Add Series";
            this.addSeriesButton.UseVisualStyleBackColor = true;
            this.addSeriesButton.Click += new System.EventHandler(this.addSeriesButton_Click);
            // 
            // deleteSeriesButton
            // 
            this.deleteSeriesButton.Location = new System.Drawing.Point(223, 445);
            this.deleteSeriesButton.Name = "deleteSeriesButton";
            this.deleteSeriesButton.Size = new System.Drawing.Size(99, 41);
            this.deleteSeriesButton.TabIndex = 6;
            this.deleteSeriesButton.Text = "Delete Series";
            this.deleteSeriesButton.UseVisualStyleBackColor = true;
            this.deleteSeriesButton.Click += new System.EventHandler(this.deleteSeriesButton_Click);
            // 
            // seriesListBox
            // 
            this.seriesListBox.FormattingEnabled = true;
            this.seriesListBox.Location = new System.Drawing.Point(12, 84);
            this.seriesListBox.Name = "seriesListBox";
            this.seriesListBox.Size = new System.Drawing.Size(311, 264);
            this.seriesListBox.TabIndex = 7;
            this.seriesListBox.SelectedIndexChanged += new System.EventHandler(this.seriesListBox_SelectedIndexChanged);
            // 
            // modifyBookButton
            // 
            this.modifyBookButton.Location = new System.Drawing.Point(535, 398);
            this.modifyBookButton.Name = "modifyBookButton";
            this.modifyBookButton.Size = new System.Drawing.Size(99, 41);
            this.modifyBookButton.TabIndex = 8;
            this.modifyBookButton.Text = "Modify Book";
            this.modifyBookButton.UseVisualStyleBackColor = true;
            this.modifyBookButton.Click += new System.EventHandler(this.ModifyBookButton_Click);
            // 
            // modifySeriesButton
            // 
            this.modifySeriesButton.Location = new System.Drawing.Point(223, 398);
            this.modifySeriesButton.Name = "modifySeriesButton";
            this.modifySeriesButton.Size = new System.Drawing.Size(99, 41);
            this.modifySeriesButton.TabIndex = 9;
            this.modifySeriesButton.Text = "Modify Series";
            this.modifySeriesButton.UseVisualStyleBackColor = true;
            this.modifySeriesButton.Click += new System.EventHandler(this.ModifySeriesButton_Click);
            // 
            // seriesLabel
            // 
            this.seriesLabel.AutoSize = true;
            this.seriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seriesLabel.Location = new System.Drawing.Point(23, 60);
            this.seriesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seriesLabel.Name = "seriesLabel";
            this.seriesLabel.Size = new System.Drawing.Size(65, 20);
            this.seriesLabel.TabIndex = 10;
            this.seriesLabel.Text = "Series:";
            // 
            // booksLabel
            // 
            this.booksLabel.AutoSize = true;
            this.booksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksLabel.Location = new System.Drawing.Point(359, 60);
            this.booksLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.booksLabel.Name = "booksLabel";
            this.booksLabel.Size = new System.Drawing.Size(64, 20);
            this.booksLabel.TabIndex = 11;
            this.booksLabel.Text = "Books:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(342, 358);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Title:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(338, 386);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "Year:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(329, 421);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 14;
            this.authorLabel.Text = "Author:";
            // 
            // pagesLabel
            // 
            this.pagesLabel.AutoSize = true;
            this.pagesLabel.Location = new System.Drawing.Point(332, 452);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(40, 13);
            this.pagesLabel.TabIndex = 15;
            this.pagesLabel.Text = "Pages:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(376, 353);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(154, 20);
            this.titleTextBox.TabIndex = 16;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(376, 384);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(154, 20);
            this.yearTextBox.TabIndex = 17;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.Location = new System.Drawing.Point(376, 449);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(154, 20);
            this.pagesTextBox.TabIndex = 19;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(29, 356);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(72, 353);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(146, 20);
            this.nameTextBox.TabIndex = 21;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(22, 386);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 22;
            this.subjectLabel.Text = "Subject:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(21, 421);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 24;
            this.amountLabel.Text = "Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(72, 418);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(146, 20);
            this.amountTextBox.TabIndex = 25;
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(0, 452);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(64, 13);
            this.publisherLabel.TabIndex = 26;
            this.publisherLabel.Text = "Publisher(s):";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(72, 449);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(146, 20);
            this.publisherTextBox.TabIndex = 27;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(71, 384);
            this.subjectComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(147, 21);
            this.subjectComboBox.TabIndex = 28;
            // 
            // authorComboBox
            // 
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Items.AddRange(new object[] {
            "J. K. Rowling",
            "Michael Chabon",
            "Zadie Smith",
            "Jonathan Franzen",
            "Alice Munro",
            "David Mitchell"});
            this.authorComboBox.Location = new System.Drawing.Point(375, 418);
            this.authorComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(155, 21);
            this.authorComboBox.TabIndex = 29;
            // 
            // bookTitleInfoLabel
            // 
            this.bookTitleInfoLabel.AutoSize = true;
            this.bookTitleInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleInfoLabel.Location = new System.Drawing.Point(676, 22);
            this.bookTitleInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookTitleInfoLabel.Name = "bookTitleInfoLabel";
            this.bookTitleInfoLabel.Size = new System.Drawing.Size(92, 20);
            this.bookTitleInfoLabel.TabIndex = 30;
            this.bookTitleInfoLabel.Text = "Book Info:";
            // 
            // titleInfoLabel
            // 
            this.titleInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleInfoLabel.Location = new System.Drawing.Point(712, 49);
            this.titleInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleInfoLabel.Name = "titleInfoLabel";
            this.titleInfoLabel.Size = new System.Drawing.Size(134, 19);
            this.titleInfoLabel.TabIndex = 35;
            // 
            // subjectTitleInfoLabel
            // 
            this.subjectTitleInfoLabel.AutoSize = true;
            this.subjectTitleInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTitleInfoLabel.Location = new System.Drawing.Point(660, 216);
            this.subjectTitleInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subjectTitleInfoLabel.Name = "subjectTitleInfoLabel";
            this.subjectTitleInfoLabel.Size = new System.Drawing.Size(112, 20);
            this.subjectTitleInfoLabel.TabIndex = 39;
            this.subjectTitleInfoLabel.Text = "Subject Info:";
            // 
            // publisherInfoLabel
            // 
            this.publisherInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.publisherInfoLabel.Location = new System.Drawing.Point(714, 386);
            this.publisherInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.publisherInfoLabel.Name = "publisherInfoLabel";
            this.publisherInfoLabel.Size = new System.Drawing.Size(132, 19);
            this.publisherInfoLabel.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Publisher(s):";
            // 
            // amountInfoLabel
            // 
            this.amountInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountInfoLabel.Location = new System.Drawing.Point(712, 354);
            this.amountInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountInfoLabel.Name = "amountInfoLabel";
            this.amountInfoLabel.Size = new System.Drawing.Size(134, 19);
            this.amountInfoLabel.TabIndex = 46;
            // 
            // amountLabel2
            // 
            this.amountLabel2.AutoSize = true;
            this.amountLabel2.Location = new System.Drawing.Point(661, 360);
            this.amountLabel2.Name = "amountLabel2";
            this.amountLabel2.Size = new System.Drawing.Size(46, 13);
            this.amountLabel2.TabIndex = 43;
            this.amountLabel2.Text = "Amount:";
            // 
            // subjectLabel2
            // 
            this.subjectLabel2.AutoSize = true;
            this.subjectLabel2.Location = new System.Drawing.Point(664, 275);
            this.subjectLabel2.Name = "subjectLabel2";
            this.subjectLabel2.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel2.TabIndex = 42;
            this.subjectLabel2.Text = "Subject:";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(672, 247);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(38, 13);
            this.nameLabel2.TabIndex = 40;
            this.nameLabel2.Text = "Name:";
            // 
            // nameInfoLabel
            // 
            this.nameInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInfoLabel.Location = new System.Drawing.Point(712, 247);
            this.nameInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameInfoLabel.Name = "nameInfoLabel";
            this.nameInfoLabel.Size = new System.Drawing.Size(134, 19);
            this.nameInfoLabel.TabIndex = 41;
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Location = new System.Drawing.Point(677, 50);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(30, 13);
            this.titleLabel2.TabIndex = 31;
            this.titleLabel2.Text = "Title:";
            // 
            // yearLabel2
            // 
            this.yearLabel2.AutoSize = true;
            this.yearLabel2.Location = new System.Drawing.Point(675, 78);
            this.yearLabel2.Name = "yearLabel2";
            this.yearLabel2.Size = new System.Drawing.Size(32, 13);
            this.yearLabel2.TabIndex = 32;
            this.yearLabel2.Text = "Year:";
            // 
            // authorLabel2
            // 
            this.authorLabel2.AutoSize = true;
            this.authorLabel2.Location = new System.Drawing.Point(666, 107);
            this.authorLabel2.Name = "authorLabel2";
            this.authorLabel2.Size = new System.Drawing.Size(41, 13);
            this.authorLabel2.TabIndex = 33;
            this.authorLabel2.Text = "Author:";
            // 
            // pagesLabel2
            // 
            this.pagesLabel2.AutoSize = true;
            this.pagesLabel2.Location = new System.Drawing.Point(667, 183);
            this.pagesLabel2.Name = "pagesLabel2";
            this.pagesLabel2.Size = new System.Drawing.Size(40, 13);
            this.pagesLabel2.TabIndex = 34;
            this.pagesLabel2.Text = "Pages:";
            // 
            // pagesInfoLabel
            // 
            this.pagesInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pagesInfoLabel.Location = new System.Drawing.Point(712, 182);
            this.pagesInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pagesInfoLabel.Name = "pagesInfoLabel";
            this.pagesInfoLabel.Size = new System.Drawing.Size(134, 19);
            this.pagesInfoLabel.TabIndex = 38;
            // 
            // yearInfoLabel
            // 
            this.yearInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearInfoLabel.Location = new System.Drawing.Point(712, 77);
            this.yearInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.yearInfoLabel.Name = "yearInfoLabel";
            this.yearInfoLabel.Size = new System.Drawing.Size(134, 19);
            this.yearInfoLabel.TabIndex = 36;
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.Location = new System.Drawing.Point(712, 275);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.Size = new System.Drawing.Size(134, 69);
            this.subjectListBox.TabIndex = 48;
            // 
            // authorListBox
            // 
            this.authorListBox.FormattingEnabled = true;
            this.authorListBox.Location = new System.Drawing.Point(712, 107);
            this.authorListBox.Name = "authorListBox";
            this.authorListBox.Size = new System.Drawing.Size(134, 69);
            this.authorListBox.TabIndex = 49;
            // 
            // PBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 529);
            this.Controls.Add(this.authorListBox);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.publisherInfoLabel);
            this.Controls.Add(this.amountInfoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountLabel2);
            this.Controls.Add(this.subjectLabel2);
            this.Controls.Add(this.nameInfoLabel);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.subjectTitleInfoLabel);
            this.Controls.Add(this.pagesInfoLabel);
            this.Controls.Add(this.yearInfoLabel);
            this.Controls.Add(this.titleInfoLabel);
            this.Controls.Add(this.pagesLabel2);
            this.Controls.Add(this.authorLabel2);
            this.Controls.Add(this.yearLabel2);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.bookTitleInfoLabel);
            this.Controls.Add(this.authorComboBox);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pagesTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.pagesLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.booksLabel);
            this.Controls.Add(this.seriesLabel);
            this.Controls.Add(this.modifySeriesButton);
            this.Controls.Add(this.modifyBookButton);
            this.Controls.Add(this.seriesListBox);
            this.Controls.Add(this.deleteSeriesButton);
            this.Controls.Add(this.addSeriesButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.label1);
            this.Name = "PBC";
            this.Text = "PBC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addSeriesButton;
        private System.Windows.Forms.Button deleteSeriesButton;
        private System.Windows.Forms.ListBox seriesListBox;
        private System.Windows.Forms.Button modifyBookButton;
        private System.Windows.Forms.Button modifySeriesButton;
        private System.Windows.Forms.Label seriesLabel;
        private System.Windows.Forms.Label booksLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.Label bookTitleInfoLabel;
        private System.Windows.Forms.Label titleInfoLabel;
        private System.Windows.Forms.Label subjectTitleInfoLabel;
        private System.Windows.Forms.Label publisherInfoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label amountInfoLabel;
        private System.Windows.Forms.Label amountLabel2;
        private System.Windows.Forms.Label subjectLabel2;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label nameInfoLabel;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label yearLabel2;
        private System.Windows.Forms.Label authorLabel2;
        private System.Windows.Forms.Label pagesLabel2;
        private System.Windows.Forms.Label pagesInfoLabel;
        private System.Windows.Forms.Label yearInfoLabel;
        private System.Windows.Forms.ListBox subjectListBox;
        private System.Windows.Forms.ListBox authorListBox;
    }
}

