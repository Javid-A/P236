using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Upcasting__Downcasting
{
    internal class Lionfish : Fish
    {
        public string Poison;
        public override void Eat()
        {
            Console.WriteLine("Small fishes");
        }

        public override void Flake()
        {
            Console.WriteLine("A few");
        }

        public override void Swim()
        {
            Console.WriteLine("Medium speed");
        }
    }
}
