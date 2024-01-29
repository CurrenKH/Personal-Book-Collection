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
    public partial class ModifySeries : Form
    {
        public Series ModifiedSeries { get; set; }
        public ModifySeries(Series selectedSeries)
        {
            InitializeComponent();

            ModifiedSeries = selectedSeries;

            DisplayInfo();
        }

        private void DisplayInfo()
        {
            //  Display information from the selected ListBox item
            nameTextBox.Text = ModifiedSeries.Name;
            // subjectComboBox.Text = ModifiedSeries.Subject;

            //  Counting the subjects from the selected item
            for (int i = 0; i < ModifiedSeries.Subjects.Count; i++)
            {
                subjectComboBox.Text += ModifiedSeries.Subjects[i];

                //  If there is more than one entry, add a "," inbetween them
                if(i + 1 < ModifiedSeries.Subjects.Count)
                {
                    subjectComboBox.Text += ",";
                }
            }

            amountTextBox.Text = ModifiedSeries.Amount.ToString();
            publisherTextBox.Text = ModifiedSeries.Publisher;
        }

        private void ChangeInfo()
        {
            //  Associate the new changes to the selected item coming from the TextBoxes
            ModifiedSeries.Name = nameTextBox.Text;
            //ModifiedSeries.Subjects = subjectComboBox.Text;

            //  Create string array from ComboBox add delimiter for multiple subjects (,)
            string[] subjectsARR = subjectComboBox.Text.Split(',');

            ModifiedSeries.Subjects.Clear();

            //  Counter associated with the array, adding the corresponding subjects of the selected item to the ComboBox
            for (int i = 0; i < subjectsARR.Length; i++)
            {
                ModifiedSeries.Subjects.Add(subjectsARR[i]);
            }

            ModifiedSeries.Amount = int.Parse(amountTextBox.Text);
            ModifiedSeries.Publisher = publisherTextBox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //  Call method to change/update the info
            ChangeInfo();

            //  Close the form
            this.Close();
        }
    }
}
