using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers__Encapsulation
{
    internal class Eatable:Product
    {
        public string Nutrition;
        public Eatable(string barcode, string name, string brand, double price, byte discount,string nutrition):base(barcode,name,brand,price,discount)
        {
            Nutrition = nutrition;
        }
    }
}
