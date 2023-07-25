using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers__Encapsulation
{
    internal class Meat:Eatable
    {
        public string Type;

        public Meat(string barcode, string name, string brand, double price, byte discount,string type,string nutrition):base(barcode,name,brand,price,discount, nutrition)
        {
            Type = type;
        }
    }
}
