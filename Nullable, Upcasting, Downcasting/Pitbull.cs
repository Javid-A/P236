using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Upcasting__Downcasting
{
    internal class Pitbull : Dog
    {
        public string Bite;
        public override void Bark()
        {
            Console.WriteLine("Barking");
        }

        public override void Eat()
        {
            Console.WriteLine("Human");
        }

        public override void Walk()
        {
            Console.WriteLine("Runnig");
        }
    }
}
