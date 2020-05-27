using StoreBook;
using System;
using System.Linq;

namespace Shop.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "Art of programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C# Programming Languages"),
        };

        public Book[] GetAllByTitle(string title)
        {
            return books.Where(book => book.Title.Contains(title)).ToArray();
        }
    }
}
