using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers__Encapsulation
{
    internal class NonEatable:Product
    {
        public string Dimensions;

        public NonEatable(string barcode, string name, string brand, double price, byte discount,string dimensions) : base(barcode, name, brand, price, discount)
        {
            Dimensions = dimensions;
        }
    }
}
