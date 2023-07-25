using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers__Encapsulation
{
    internal class Drink:Eatable
    {
        public byte Alcohol;

        public Drink(string barcode, string name, string brand, double price, byte discount,byte alcohol,string nutrition):base(barcode,name,brand,price,discount, nutrition)
        {
            Alcohol = alcohol;
        }
    }
}
