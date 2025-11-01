using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new library();

            library.AddBook("Pride and Prejudice", "Jane Austen");
            library.AddBook("The Lord of the Rings", "J.R.R. Tolkien");

            library.AddMember("M001", "Ali Rezaei");
            library.AddMember("M002", "Sara Mohammadi");

            library.DisplayAllBooks();
            library.DisplayAllMembers();

            library.RemoveBook("Pride and Prejudice", "Jane Austen");
            library.DisplayAllBooks();

            Console.ReadLine();
        }
    }
}
