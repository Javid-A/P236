﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection__Filestream__Multi_task
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
