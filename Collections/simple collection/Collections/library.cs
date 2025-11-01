using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class library
    {
        List<Book> books = new List<Book>();
        Dictionary<string, Member> _dics = new Dictionary<string, Member>();

        public void AddBook(string title, string author)
        {
            books.Add(new Book(title, author));
            Console.WriteLine("Book " + title + " added.");
        }

        public void RemoveBook(string title, string author)
        {
            Book bookToRemove = books.Find(b => b.Title == title && b.Author == author);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book " + title + " removed.");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        public void AddMember(string id, string name)
        {
            if (!_dics.ContainsKey(id))
            {
                _dics.Add(id, new Member(id, name));
                Console.WriteLine("Member " + name + " registered.");
            }
            else
            {
                Console.WriteLine("Member ID already exists!");
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("All Books:");
            foreach (var book in books)
            {
                Console.WriteLine(book.Title+" by "+book.Author);
            }
        }

           public void DisplayAllMembers()
            {
                Console.WriteLine("All Members:");
                foreach (var member in _dics.Values)
                {
                    Console.WriteLine(member.MemberId+" : "+member.Family);
                }
            }
    }
}
