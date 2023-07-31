using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Namespace__DLL.Models
{
    public class Computer:Product
    {
        protected int Count;
        internal double Price;

        public Computer()
        {
        }
    }
}
