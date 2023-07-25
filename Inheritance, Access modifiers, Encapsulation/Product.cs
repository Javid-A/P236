using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance__Access_modifiers__Encapsulation
{
    internal class Product
    {
        public string Barcode;
        public string Name;
        public string Brand;
        public double Price;
        public byte Discount;

        public Product(string barcode, string name, string brand, double price, byte discount)
        {
            Barcode = barcode;
            Name = name;
            Brand = brand;
            Price = price;
            Discount = discount;
        }
    }
}
