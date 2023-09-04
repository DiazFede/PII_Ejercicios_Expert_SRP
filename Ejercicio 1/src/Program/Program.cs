using System;
using System.Collections.Generic;

namespace SRP
{
    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns", "Erich Gamma & Others", "001-034");
            List<Book> bookList = new List<Book> { book1 };

            Shelve shelve = new Shelve();
            shelve.ActualShelve(bookList, 1);

            Console.WriteLine("Ejemplo de organización de libros:");
            Console.WriteLine($"Estantería: {shelve.Identifier}");
            Console.WriteLine("Libros en la estantería:");
            foreach (var book in shelve.BookList)
            {
                Console.WriteLine($"Título: {book.Title}, Autor: {book.Author}, Código: {book.Code}");
            }
        }
    }
}

