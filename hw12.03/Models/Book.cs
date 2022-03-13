using System;
using System.Collections.Generic;
using System.Text;
using hw12._03.Enums;

namespace hw12._03.Models
{
    internal class Book
    {
        public string Name;
        public string Author;
        public int PageCount;
        public Genre Genre;

        public Book(string name, string author, int pagecount, Genre genre)
        {
            Name = name;
            Author = author;   
            PageCount = pagecount;
            Genre = genre;
            
        }


        public override string ToString()
        {
            return $"Adi:{Name} Author:{Author} Pagecount:{PageCount} Genre:{Genre}";
        }
    }
}
