using System;
using System.Collections.Generic;
using System.Text;
using hw12._03.Enums;
using hw12._03.Models;

namespace hw12._03.Interfaces
{
    internal interface ILibraryManager
    {
        List<Book> Books { get; }

        void Add(Book book);
        Book ShowInfo(string ad);
        List<Book> Search(string value);
        List<Book> Filter(string author, Genre genre);
    }
}
