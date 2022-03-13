using System;
using System.Collections.Generic;
using System.Text;

namespace hw12._03.Exceptions
{
    internal class BookNotFoundException: Exception
    {
        public BookNotFoundException(string message):base(message)
        {

        }
    }
}
