using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extension__Enum__Nullable
{
    internal class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public static double Discount;

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public double GetPrice()
        {
            if (Discount > 0)
            {
                double result = Price - Price * Discount / 100;
                return result;
            }
            return Price;
        }
    }
}
