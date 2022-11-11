using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopBDD.CustomExceptions
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string message) : base(message) { }
    }
}
