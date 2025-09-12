using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1StoreAndDisplayBookInformation
{
    internal class Program
    {
        public struct Book
        {
            public string Title;
            public string Author;
            public string Genre;
            public string PublicationYear;
        }

        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Enter book title");
            book.Title = Console.ReadLine();
            Console.WriteLine("enter book author");
            book.Author = Console.ReadLine();
            Console.WriteLine("enter book genre");
            book.Genre = Console.ReadLine();
            Console.WriteLine("enter publication year");
            book.PublicationYear = Console.ReadLine();
            Console.WriteLine($"\n your Book information: \nTitle: {book.Title}\nAuthor: {book.Author}\nGenre: {book.Genre}\nPublication year: {book.PublicationYear}");
        
        }
    } 
    
}
