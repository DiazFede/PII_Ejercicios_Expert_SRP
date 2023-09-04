using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public List<Book> BookList { get;  set; }
        public int Identifier { get;  set; }

        public void ActualShelve(List<Book> bookList, int identifier)
        {
            BookList = bookList;
            Identifier = identifier;
        }
    }
}


