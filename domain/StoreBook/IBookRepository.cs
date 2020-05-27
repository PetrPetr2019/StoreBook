using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBook
{
    public  interface IBookRepository
    {
        Book[] GetAllByTitle(string title);
        
    }
    
}
