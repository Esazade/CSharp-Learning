using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Book
    {
        public string Title { get; set; }   
        public string Author { get; set; }  

        public Book(string myTitle, string myAuthor)
        {
            Title = myTitle;
            Author = myAuthor;
        }

        public override string ToString()
        {
            return "Title: " + Title + ", Author: " + Author;
        }
    }
}
