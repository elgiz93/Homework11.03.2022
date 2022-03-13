using System;
using System.Collections.Generic;
using System.Text;
using hw12._03.Enums;
using hw12._03.Exceptions;
using hw12._03.Interfaces;
using hw12._03.Models;

namespace hw12._03.Services
{
    internal class Services : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public Services()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (_books.Exists(m => m.Name == book.Name))
            {
                throw new SameBookalreadyAddedException("Bu adda Book artiq movcuddur");
            }
            _books.Add(book);
        }

        public List<Book> Filter(string author, Genre genre)
        {
            return _books.FindAll(d => d.Author == author && d.Genre == genre);
        }

        public List<Book> Search(string value)
        {
            return _books.FindAll(d => d.Name.Contains(value));
        }

        public Book ShowInfo(string ad)
        {
            if (_books.Find(n => n.Name == ad) != null)
            {
                return _books.Find(n => n.Name == ad);
            }
            throw new BookNotFoundException("Daxil edilen adda Book yoxdur");
        }
    }
}
