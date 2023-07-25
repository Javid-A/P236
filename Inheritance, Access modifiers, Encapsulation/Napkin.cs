using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers__Encapsulation
{
    internal class Napkin:NonEatable
    {
        public short Count;
        public string Thickness;
        public Napkin(string barcode, string name, string brand, double price, byte discount, string dimensions,short count,string thickness):base(barcode,name,brand,price,discount,dimensions)
        {
            Count = count;
            Thickness = thickness;
        }
    }
}
