using System;

namespace StoreBook
{
    public class BookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book[] GetAllByQuery(string query)
        {
            if (Book.IsIsbn(query))
                return bookRepository.AllByIsbn(query);
            return bookRepository.GetAllByTitleOrAuthor(query);
        }
    }
}