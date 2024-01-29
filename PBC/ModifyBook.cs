using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBC
{
    public partial class ModifyBook : Form
    {
        public Book ModifiedBook { get; set; }
        public ModifyBook(Book selectedBook)
        {
            InitializeComponent();

            ModifiedBook = selectedBook;

            DisplayInfo();
        }

        private void DisplayInfo()
        {
            //  Display information from the selected ListBox item
            titleTextBox.Text = ModifiedBook.Title;
            yearTextBox.Text = ModifiedBook.Year.ToString();
            //authorComboBox.Text = ModifiedBook.Author;

            authorComboBox.Items.Clear();

            //  Counting the authors from the selected item
            for (int i = 0; i < ModifiedBook.Authors.Count; i++)
            {
                authorComboBox.Text += ModifiedBook.Authors[i];

                //  If there is more than one entry, add a "," inbetween them
                if (i + 1 < ModifiedBook.Authors.Count)
                {
                    authorComboBox.Text += ",";
                }
            }
            pagesTextBox.Text = ModifiedBook.Pages.ToString();
        }

        private void ChangeInfo()
        {
            //  Associate the new changes to the selected item coming from the TextBoxes
            ModifiedBook.Title = titleTextBox.Text;
            ModifiedBook.Year = int.Parse(yearTextBox.Text);
            //ModifiedBook.Author = authorComboBox.Text;

            //  Create string array from ComboBox and add delimiter for multiple subjects (,)
            string[] authorARR = authorComboBox.Text.Split(',');

            ModifiedBook.Authors.Clear();

            //  Counter associated with the array, adding the corresponding authors of the selected item to the ComboBox
            for (int i = 0; i < authorARR.Length; i++)
            {
                ModifiedBook.Authors.Add(authorARR[i]);
            }
            ModifiedBook.Pages = int.Parse(pagesTextBox.Text);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //  Call method to change/update the info
            ChangeInfo();

            //  Close the form
            this.Close();
        }
    }
}
