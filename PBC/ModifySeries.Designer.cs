
namespace PBC
{
    partial class ModifySeries
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
            this.modifySeriesLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.subjectinfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifySeriesLabel
            // 
            this.modifySeriesLabel.AutoSize = true;
            this.modifySeriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifySeriesLabel.Location = new System.Drawing.Point(174, 27);
            this.modifySeriesLabel.Name = "modifySeriesLabel";
            this.modifySeriesLabel.Size = new System.Drawing.Size(136, 24);
            this.modifySeriesLabel.TabIndex = 1;
            this.modifySeriesLabel.Text = "Modify Series";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(165, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(165, 171);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(154, 20);
            this.publisherTextBox.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(121, 68);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "Name:";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(113, 103);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 13;
            this.subjectLabel.Text = "Subject:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(113, 138);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 14;
            this.amountLabel.Text = "Amount:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(95, 174);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(64, 13);
            this.publisherLabel.TabIndex = 15;
            this.publisherLabel.Text = "Publisher(s):";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(188, 209);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 42);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Save and Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(165, 135);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(154, 20);
            this.amountTextBox.TabIndex = 10;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(165, 101);
            this.subjectComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(154, 21);
            this.subjectComboBox.TabIndex = 18;
            // 
            // subjectinfoLabel
            // 
            this.subjectinfoLabel.AutoSize = true;
            this.subjectinfoLabel.Location = new System.Drawing.Point(324, 104);
            this.subjectinfoLabel.Name = "subjectinfoLabel";
            this.subjectinfoLabel.Size = new System.Drawing.Size(150, 13);
            this.subjectinfoLabel.TabIndex = 19;
            this.subjectinfoLabel.Text = "Add \"-\" between each subject";
            // 
            // ModifySeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 283);
            this.Controls.Add(this.subjectinfoLabel);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.modifySeriesLabel);
            this.Name = "ModifySeries";
            this.Text = "ModifySeries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modifySeriesLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label subjectinfoLabel;
    }
}