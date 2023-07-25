using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers__Encapsulation
{
    internal class Milk:Eatable
    {
        public double Fat;

        public Milk(string barcode, string name, string brand, double price, byte discount, double fat,string nutrition) : base(barcode, name, brand, price, discount, nutrition)
        {
            Fat = fat;
        }

    }
}
