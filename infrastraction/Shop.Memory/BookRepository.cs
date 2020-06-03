using StoreBook;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = {
            new Book(1, "ISBN 12345-56432", "D. Khurt", "Art of Programming", "«Искусство программирования» (англ. The Art of Computer Programming)" +
                                                                              " фундаментальная монография известного американского математика и специалиста в области компьютерных наук" +
                                                                              " Дональда Кнута," +
                                                                              " посвященная рассмотрению и анализу важнейших алгоритмов, используемых в информатике." +
                                                                              " В 1999 году книга была признана одной из двенадцати лучших физико-математических монографий столетия", 7.19m),

            new Book(2, "ISBN 45673-56422", "M. Folwer", "Refactoring","Основу книги составляет подробный перечень более 70 методов рефакторинга," +
                                                                              " для каждого из которых описываются мотивация и техника испытанного на практике преобразования кода с примерами на Java." +
                                                                              " Рассмотренные в книге методы позволяют поэтапно модифицировать код, внося каждый раз небольшие изменения," +
                                                                              " благодаря чему снижается риск, связанный с развитием проекта.", 12.45m ),

            new Book(3, "ISBN 66665-95544", "B. Kernighan", "Programming Language", "Донован А. Керниган Б. - Язык Программирования Go" +
                                                                                    " (Программирование Для Профессионалов", 14.98m )
        };

        public Book[] AllByIsbn(string isbn)
        {
            return books.Where(book => book.ISbn == isbn).ToArray();
        }

        public IEnumerable<Book> GetAllByIds(IEnumerable<int> bookIds)
        {

            var foundBooks = from book in books
                             join bookId in bookIds on book.Id equals bookId
                             select book;
            return foundBooks.ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                       || book.Title.Contains(query))
                .ToArray();
        }

        public Book GtById(int id)
        {
            return books.Single(book=>book.Id==id);
        }
    }
}
