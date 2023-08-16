using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class AgeOutOfRangeException:System.Exception
    {
        const string _message = "Age was outside the bounds of rules";
        public AgeOutOfRangeException(string message=_message):base(message)
        {
            
        }
    }
}
