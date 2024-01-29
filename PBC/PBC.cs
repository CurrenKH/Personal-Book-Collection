using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PBC
{
    public partial class PBC : Form
    {
        // Field to hold a list of objects.
        public List<Book> Books = new List<Book>();
        public List<Series> BookSeries = new List<Series>();
        public PBC()
        {
            InitializeComponent();
        }
        StreamReader inputFile;
        private void ReadFile()
        {
            try
            {
                //  StreamReader inputFile;
                string line;

                //  Lists to hold the products
                // Book thisBook = new Book();
                Book thisBook;
                Series thisSeries;

                //  Create a delimiter
                char[] delim = { ',' };
                char[] delim2 = { '-' };
                char[] delim3 = { '/' };

                //  Open input file
                inputFile = File.OpenText("myBooks.txt");

                //  Read lines
                while (!inputFile.EndOfStream)
                {
                    //  Read line from user
                    line = inputFile.ReadLine();

                    //  Tokenize
                    string[] tokens = line.Split(delim);
                    if (tokens[0] == "Book" || tokens[0] == "book")
                    {
                        //  Assign properties to book
                        thisBook = new Book();
                        thisBook.Type = tokens[0];

                        thisBook.Title = tokens[2];
                        thisBook.Year = int.Parse(tokens[3]);

                        //  Create string array with tokenized items
                        string[] authorTokens = tokens[4].Split(delim3);

                        //  Associate array with a list
                        List<string> authorList = new List<string>(authorTokens);

                        //  Authors variable from thisBook referred to list
                        thisBook.Authors = authorList;

                        //  thisBook.Author = tokens[3];
                        thisBook.Pages = int.Parse(tokens[5]);

                        //  Add the book to its list
                        //  Books.Add(thisBook);

                        //  Display the book in the booksListBox
                        //  booksListBox.Items.Add(thisBook.Title);

                        //  For each author, add it to the combo box
                        for (int i = 0; i < thisBook.Authors.Count; i++)
                        {
                            authorComboBox.Items.Add(thisBook.Authors[i]);
                        }

                        //  Count each book series that exists
                        for (int i = 0; i < BookSeries.Count; i++)
                        {
                            //  If the book series name is equal to the first token, add the book to the corresponding series
                            if (BookSeries[i].Name == tokens[1])
                            {
                                BookSeries[i].Books.Add(thisBook);
                            }
                        }
                    }

                    else if (tokens[0] == "Series" || tokens[0] == "series")
                    {
                        //  Assign properties to series
                        thisSeries = new Series();
                        thisSeries.Type = tokens[0];
                        thisSeries.Name = tokens[1];

                        //  Create string array with tokenized items
                        string[] subjectTokens = tokens[2].Split(delim2);

                        //  Associate array with a list
                        List<string> subjectList = new List<string>(subjectTokens);

                        //  Subjects variable from thisSeries referred to list
                        thisSeries.Subjects = subjectList;



                        //subjectTokens[0] = Fiction

                        Console.WriteLine("Count = " + thisSeries.Subjects.Count);

                        //thisSeries.Subject = tokens[2];
                        thisSeries.Amount = int.Parse(tokens[3]);
                        thisSeries.Publisher = tokens[4];

                        //  Display the series in the inventoryListBox
                        seriesListBox.Items.Add(thisSeries.Name);

                        //  Add series subjects to ComboBox
                        for (int i = 0; i < thisSeries.Subjects.Count; i++)
                        {
                            subjectComboBox.Items.Add(thisSeries.Subjects[i]);
                        }
                        BookSeries.Add(thisSeries);
                    }
                }
                    //  Close the file
                    inputFile.Close();
            }
            catch (Exception ex)
            {
                //  Close the file
                inputFile.Close();

                //  Display error message.
                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Call ReadFile method upon loading the form
            ReadFile();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //  Method to save text file
            SaveFile();

            //  Close the form
            this.Close();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            //  Check if the TextBoxes are empty
            if (titleTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must enter a book title.");
            }
            else if (yearTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must enter a year.");
            }
            else if (authorComboBox.Text == string.Empty)
            {
                MessageBox.Show("You must enter an author.");
            }
            else if (pagesTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must enter a page amount.");
            }
            else
            {
                // AddBook newBook = new AddBook();
                try
                {
                    //  Declare a StreamWriter variable.
                    StreamWriter outputFile;

                    //  Create a file and get a StreamWriter object.

                    Book thisBook = new Book();

                    outputFile = File.AppendText("myBooks.txt");

                    //  Assign properties to book
                    thisBook = new Book();
                    thisBook.Type = "Book";
                    thisBook.Title = titleTextBox.Text;
                    thisBook.Year = int.Parse(yearTextBox.Text);
                    //thisBook.Authors = authorComboBox.Text;

                    //  Create string array from ComboBox add delimiter for multiple subjects (,)
                    string[] authorARR = authorComboBox.Text.Split(',');

                    //  Counter associated with the array, adding the corresponding authors of the selected item to the ComboBox
                    for (int i = 0; i < authorARR.Length; i++)
                    {
                        Console.WriteLine(i);
                        thisBook.Authors.Add(authorARR[i]);
                    }
                    thisBook.Pages = int.Parse(pagesTextBox.Text);


                    //  Add book item to individual book series
                    BookSeries[0].Books.Add(thisBook);
                    //  Books.Add(thisBook);

                    //  Add title to ListBox
                    booksListBox.Items.Add(thisBook.Title);

                    //  booksListBox.Items.Add(thisBook.Title);

                    outputFile.WriteLine("Book" + "," + "Individual Books" + "," + titleTextBox.Text + "," + yearTextBox.Text + "," + authorComboBox.Text + "," + pagesTextBox.Text);

                    //  Close the file.
                    outputFile.Close();

                    //  Let the user know the name was written.
                    MessageBox.Show("The book has been added.");

                    //  Call text clear method
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    //  Display an error message.
                    MessageBox.Show(ex.Message);
                }
                //  Display AddBook form
                //  newBook.ShowDialog();
            }
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            //  If a book is not selected in the ListBox
            if (booksListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a book from the list.");
            }
            else
            {
                //  Remove selected item from ListBox
                string toRemove = booksListBox.SelectedItem.ToString();

                //  If book item equals selected item
                if (BookSeries[seriesListBox.SelectedIndex].Books[booksListBox.SelectedIndex].Title == toRemove)
                {
                    BookSeries[seriesListBox.SelectedIndex].Books.RemoveAt(booksListBox.SelectedIndex);
                    booksListBox.Items.RemoveAt(booksListBox.SelectedIndex);
                }
                ClearBookLabels();
            }
        }

        private void ClearBookLabels()
        {
            //  Clear target labels to empty strings
            titleInfoLabel.Text = "";
            yearInfoLabel.Text = "";
            //authorInfoLabel.Text = "";
            pagesInfoLabel.Text = "";
        }

        private void addSeriesButton_Click(object sender, EventArgs e)
        {
            //  Check if the TextBoxes are empty
            if (nameTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must enter a series name.");
            }
            else if (subjectComboBox.Text == string.Empty)
            {
                MessageBox.Show("You must enter a subject name.");
            }
            else if (amountTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must enter an amount.");
            }
            else if (publisherTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must enter publisher(s).");
            }
            else
            {
                try
                {
                    // Declare a StreamWriter variable.
                    StreamWriter outputFile;

                    // Create a file and get a StreamWriter object.

                    Series thisSeries = new Series();

                    outputFile = File.AppendText("myBooks.txt");

                    //  Assign properties to book
                    thisSeries = new Series();
                    thisSeries.Type = "Series";
                    thisSeries.Name = nameTextBox.Text;
                    //  thisSeries.Subject = subjectComboBox.Text;
                    thisSeries.Amount = int.Parse(amountTextBox.Text);
                    thisSeries.Publisher = publisherTextBox.Text;

                    BookSeries.Add(thisSeries);

                    //  Add title to ListBox
                    seriesListBox.Items.Add(thisSeries.Name);



                    outputFile.WriteLine("Series" + "," + nameTextBox.Text + "," + subjectComboBox.Text + "," + amountTextBox.Text + "," + publisherTextBox.Text);
                    // Close the file.
                    outputFile.Close();

                    // Let the user know the name was written.
                    MessageBox.Show("The series has been added.");

                    //  Call text clear method
                    ClearTextBoxes();
                }
                catch (Exception ex)
                {
                    // Display an error message.
                    MessageBox.Show(ex.Message);
                }

                //  Display AddSeries form
                //  newSeries.ShowDialog();
            }
        }

        private void ClearTextBoxes()
        {
            //  Clear all TextBoxes
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                tb.Text = string.Empty;

            //  Clear ComboBoxes
            authorComboBox.ResetText();
            subjectComboBox.ResetText();
        }

        private void deleteSeriesButton_Click(object sender, EventArgs e)
        {
            //  If a book is not selected in the ListBox
            if (seriesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a series from the list.");
            }
            else
            {
                //  Remove selected item from ListBox
                string toRemove = seriesListBox.SelectedItem.ToString();

                if (BookSeries[seriesListBox.SelectedIndex].Name == toRemove)
                {
                    BookSeries.RemoveAt(seriesListBox.SelectedIndex);
                    seriesListBox.Items.RemoveAt(seriesListBox.SelectedIndex);
                }
                //  Call method
                ClearSeriesLabels();
            }
        }

        private void ClearSeriesLabels()
        {
            //  Clear info labels
            nameInfoLabel.Text = "";
            //subjectInfoLabel.Text = "";
            amountInfoLabel.Text = "";
            publisherInfoLabel.Text = "";
        }

        private void booksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  Clear ListBox when selecting different book
            authorListBox.Items.Clear();

            //  MessageBox called to show class properties for selected item
            int index = booksListBox.SelectedIndex;

            //  if the selected index is not any value
            if (index != -1)
            {
                //  variable from Book to indicate seriesListBox selected item points to the booksListBox selected item
                Book currentBook = BookSeries[seriesListBox.SelectedIndex].Books[booksListBox.SelectedIndex];

                //  Show index of selected item
                titleInfoLabel.Text = currentBook.Title;
                yearInfoLabel.Text = currentBook.Year.ToString();

                        //  Counter to calculate authors and add to ListBox if there are multiple instances
                for (int i = 0; i < currentBook.Authors.Count; i++)
                {
                Console.WriteLine("Subject = " + currentBook.Authors[i]);
                authorListBox.Items.Add(currentBook.Authors[i]);
                }

                pagesInfoLabel.Text = currentBook.Pages.ToString();


            }

            //  Allows selected item in ListBox to display its information

        }
        public void DisplayBooksInSeries()
        {
            //  Clear booksListBox
            booksListBox.Items.Clear();
            string seriesName = seriesListBox.SelectedItem.ToString();

            //  Counter for the amount of series that exist
            for(int i = 0; i < BookSeries.Count; i++)
            {
                //  If the series selected item is equal to a series name, display the books within it
                if (seriesName == BookSeries[i].Name)
                {
                    for (int index = 0; index < BookSeries[i].Books.Count; index++)
                    {
                        //  Add the titles to booksListBox
                        booksListBox.Items.Add(BookSeries[i].Books[index].Title);
                    }
                }
            }
        }
        private void seriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Clear ListBox when selecting different series
            subjectListBox.Items.Clear();

            //  MessageBox called to show class properties for selected item
            int index = seriesListBox.SelectedIndex;

            //  if the selected index is not any value
            if (index != -1)
            {
                DisplayBooksInSeries();

                // Allows selected item in ListBox to display its information
                foreach (Series currentSeries in BookSeries)
                {
                    if (seriesListBox.SelectedItem.ToString() == currentSeries.Name)
                    {
                        //  Show index of selected item
                        nameInfoLabel.Text = currentSeries.Name;

                       

                        for (int i = 0; i < currentSeries.Subjects.Count; i++)
                        {
                            Console.WriteLine("Subject = " + currentSeries.Subjects[i]);


                            subjectListBox.Items.Add(currentSeries.Subjects[i]);
                        }

                        amountInfoLabel.Text = currentSeries.Amount.ToString();
                        publisherInfoLabel.Text = currentSeries.Publisher;
                    }
                }
            }
        }
        private void SaveFile()
        {

            //  Declare file destination and empty
            System.IO.File.WriteAllText("myBooks.txt", string.Empty);

            // Declare a StreamWriter variable.
            StreamWriter outputFile;

            // Create a file and get a StreamWriter object.
            outputFile = File.AppendText("myBooks.txt");

            //  For each series item existing, write the outputs
            for (int i = 0; i < BookSeries.Count; i++)
            {

                outputFile.WriteLine(BookSeries[i].Type + "," + BookSeries[i].Name + "," + getSubjects(BookSeries[i].Subjects) + "," + BookSeries[i].Amount
                    + "," + BookSeries[i].Publisher);

            }
            for (int i = 0; i < BookSeries.Count; i++)
            {

                //  For each book item existing, write the outputs
                for (int index = 0; index < BookSeries[i].Books.Count; index++)
                {
                    //  outputFile.WriteLine(index);
                    outputFile.WriteLine(BookSeries[i].Books[index].Type + "," + BookSeries[i].Name + "," + BookSeries[i].Books[index].Title + "," + BookSeries[i].Books[index].Year + "," + getAuthors(BookSeries[i].Books[index].Authors)
                        + "," + BookSeries[i].Books[index].Pages);
                }
            }

            //  Close the file
            outputFile.Close();
        }

        private string getAuthors(List<string> aList)
        {

            string elements = "";

            //  For each author found on the list of strings
            for (int i = 0; i < aList.Count; i++)
            {
                elements += aList[i];

                //  Add the delimiter symbol after each one (besides the last one)
                if(i + 1 < aList.Count)
                {
                    elements += "/";
                }
            }
            return elements;
        }

        private string getSubjects(List<string> aList)
        {

            string elements = "";

            //  For each subject found on the list of strings
            for (int i = 0; i < aList.Count; i++)
            {
                elements += aList[i];

                //  Add the delimiter symbol after each one (besides the last one)
                if (i + 1 < aList.Count)
                {
                    elements += "-";
                }

            }
            return elements;
        }

        public void AddNewBook()
        {

        }

        private void ModifySeriesButton_Click(object sender, EventArgs e)
        {
            //  If a series is not selected in the ListBox
            if (seriesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a series from the list.");
            }
            else
            {
                //  Take selected item from from ListBox and provide it to new form
                ModifySeries modifySeries = new ModifySeries(BookSeries[seriesListBox.SelectedIndex]);

                //  Show new form
                modifySeries.ShowDialog();

                //  Method to display updated series list in ListBox
                DisplaySeries();
            }
        }

        private void ModifyBookButton_Click(object sender, EventArgs e)
        {
            //  If a book is not selected in the ListBox
            if (booksListBox.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a book from the list.");
            }
            else
            {
                //  Take selected item from from ListBox and provide it to new form
                ModifyBook modifyBook = new ModifyBook(BookSeries[seriesListBox.SelectedIndex].Books[booksListBox.SelectedIndex]);

                //  Show new form
                modifyBook.ShowDialog();

                //  Method to display updated series list in ListBox
                DisplayBook();
            }
        }

        private void DisplayBook()
        {
            //  Clear ListBox
            booksListBox.Items.Clear();

            //  For each book item title add it to the ListBox
            for (int i = 0; i < Books.Count; i++)
            {
                booksListBox.Items.Add(Books[i].Title);
            }
        }

        private void DisplaySeries()
        {
            //  Clear ListBox
            seriesListBox.Items.Clear();

            //  For each series item name add it to the ListBox
            for (int i = 0; i < BookSeries.Count; i++)
            {
                seriesListBox.Items.Add(BookSeries[i].Name);
            }
        }
    }
}
