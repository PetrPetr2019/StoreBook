using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBook
{
    public  interface IBookRepository
    {
        Book[] AllByIsbn(string isbn);
        Book[] GetAllByTitleOrAuthor(string query);
        
    }
    
}
