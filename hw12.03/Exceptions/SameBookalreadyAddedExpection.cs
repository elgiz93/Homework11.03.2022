using System;
using System.Collections.Generic;
using System.Text;

namespace hw12._03.Exceptions
{
    internal class SameBookalreadyAddedException : Exception
    {
        public SameBookalreadyAddedException(string message):base(message)
        {

        }
    }
}
