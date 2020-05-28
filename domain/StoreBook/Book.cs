using System;
using System.Text.RegularExpressions;

namespace StoreBook
{
    public class Book
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string ISbn { get; }
        public  string Author { get; }

        public Book(int id, string iSbn,  string author, string title)
        {
            Id = id;
            Title = title;
            ISbn = iSbn;
            Author = author;
        }

       internal  static  bool IsIsbn(string s)
       {
           if (s == null)
               return false;
           s = s.Replace("-", "")
               .Replace(" ", "");
           s.ToUpper();
           return Regex.IsMatch(s, "ISBN\\d{10}");
       }

    }
}
