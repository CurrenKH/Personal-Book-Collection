
namespace PBC
{
    partial class ModifyBook
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
            this.modifyBookLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.subjectinfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyBookLabel
            // 
            this.modifyBookLabel.AutoSize = true;
            this.modifyBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBookLabel.Location = new System.Drawing.Point(201, 7);
            this.modifyBookLabel.Name = "modifyBookLabel";
            this.modifyBookLabel.Size = new System.Drawing.Size(124, 24);
            this.modifyBookLabel.TabIndex = 0;
            this.modifyBookLabel.Text = "Modify Book";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(154, 68);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(190, 65);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(154, 20);
            this.titleTextBox.TabIndex = 7;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(152, 102);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(190, 99);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(154, 20);
            this.yearTextBox.TabIndex = 9;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(143, 134);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 10;
            this.authorLabel.Text = "Author:";
            // 
            // pagesLabel
            // 
            this.pagesLabel.AutoSize = true;
            this.pagesLabel.Location = new System.Drawing.Point(144, 172);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(40, 13);
            this.pagesLabel.TabIndex = 12;
            this.pagesLabel.Text = "Pages:";
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.Location = new System.Drawing.Point(190, 169);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(154, 20);
            this.pagesTextBox.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(205, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 42);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Save and Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.authorComboBox.Location = new System.Drawing.Point(189, 132);
            this.authorComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(155, 21);
            this.authorComboBox.TabIndex = 16;
            // 
            // subjectinfoLabel
            // 
            this.subjectinfoLabel.AutoSize = true;
            this.subjectinfoLabel.Location = new System.Drawing.Point(349, 135);
            this.subjectinfoLabel.Name = "subjectinfoLabel";
            this.subjectinfoLabel.Size = new System.Drawing.Size(148, 13);
            this.subjectinfoLabel.TabIndex = 20;
            this.subjectinfoLabel.Text = "Add \"/\" between each author";
            // 
            // ModifyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 270);
            this.Controls.Add(this.subjectinfoLabel);
            this.Controls.Add(this.authorComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pagesTextBox);
            this.Controls.Add(this.pagesLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.modifyBookLabel);
            this.Name = "ModifyBook";
            this.Text = "ModifyBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifyBookLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox authorComboBox;
        private System.Windows.Forms.Label subjectinfoLabel;
    }
}