using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBC
{
    public class Book
    {

        //  Property for type
        public string Type { get; set; }

        //  Property for name
        public string Title { get; set; }

        //  Property for year
        public int Year { get; set; }

        //  Property for author
        public List<string> Authors { get; set; }

        //  Property for pages
        public int Pages { get; set; }


        //  Default constructor
        public Book()
        {
            Type = "";
            Title = "";
            Year = 0;
            //Author = "";
            Authors = new List<string>();
            Pages = 0;
        }

        //  Overload Constructor
        public Book(string type, string title, int year, string author, int pages)
        {
            Type = type;
            Title = title;
            Year = year;
            //Author = author;
            Authors = new List<string>();
            Pages = pages;
        }

        //  String override for book information when ToString is called
        /*public override string ToString()
        {
            return "Title: " + Title + "\nYear: " + Year + "\nAuthor: " + Author + "\nPages: " + Pages;
        }*/
    }
}
