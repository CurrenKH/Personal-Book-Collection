using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBC
{
    public class Series
    {

        //  Property for type
        public string Type { get; set; }

        //  Property for name
        public string Name { get; set; }

        //  Property for subject
        //  public string Subject { get; set; }

        public List<string> Subjects { get; set; }

        //  Property for author
        public int Amount { get; set; }

        //  Property for pages
        public string Publisher { get; set; }

        public List<Book> Books { get; set; }


        //  Default constructor
        public Series()
        {
            Type = "";
            Name = "";
            //Subject = "";
            Amount = 0;
            Publisher = "";
            Books = new List<Book>();
        }

        //  Overload constructor
        public Series(string type, string name, string subject, int amount, string publisher)
        {
            Type = type;
            Name = name;
            //Subject = subject;
            Amount = amount;
            Publisher = publisher;
            Books = new List<Book>();
        }

        //  String override for book information when ToString is called
        /*public override string ToString()
        {
            return "Name: " + Name + "\nSubject: " + Subject + "\nAmount: " + Amount + "\nPublisher(s): " + Publisher;
        }
        */
    }
}
