using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class DivByZeroException : Exception
    {
        public DivByZeroException(string message) : base(message) { }
        
        public override string ToString()
        {
            return $"Custom exception: {Message}";
        }

    }
}
