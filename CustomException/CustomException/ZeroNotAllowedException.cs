using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class ZeroNotAllowedException : Exception
    {
        public ZeroNotAllowedException(string message):base(message) { }  //constructor

        public override string ToString()
        {
            return $"Custom exception: {Message}";
        }

    }
}
