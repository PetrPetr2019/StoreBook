using StoreBook;
using System;
using System.Linq;

namespace Shop.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12345-56432", " D.Khurt", "Art of Programming"),
            new Book(2, "ISBN 45673-56422", "M. Folwer", "Refactoring"),
            new Book(3, "ISBN 66665-95544", "B. Kernighan", "Programming Language")
        };

        public Book[] AllByIsbn(string isbn)
        {
            return books.Where(book => book.ISbn == isbn).ToArray();
        }

       

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                       || book.Title.Contains(query))
                .ToArray();
        }
    }
}
