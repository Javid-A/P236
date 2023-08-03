using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Upcasting__Downcasting
{
    internal class Samoyed : Dog,IShaveable
    {
        public string Fur;
        public override void Bark()
        {
            Console.WriteLine("Barking");
        }

        public override void Eat()
        {
            Console.WriteLine("Pedigree");
        }

        public void Shave()
        {
            Console.WriteLine("Done shaving");
        }

        public override void Walk()
        {
            Console.WriteLine("Walk");
        }
    }
}
