using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Upcasting__Downcasting
{
    internal static class Treatment
    {
        public static void Treat(this Dog dog)
        {
            Console.WriteLine($"Treatment start for {dog.GetType().Name}");
            if(dog is IShaveable shaveable)
            {
                shaveable.Shave();
            }
            Console.WriteLine($"Treatment done for {dog.GetType().Name}");
        }
        
        public static void Treat(this Lionfish lionfish)
        {
            Console.WriteLine("Treatment for lionfish");
        }
    }
}
