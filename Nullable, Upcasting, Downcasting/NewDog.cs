using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Upcasting__Downcasting
{
    internal class NewDog : Dog,IShaveable
    {
        public override void Bark()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Shave()
        {
            Console.WriteLine("Done shaving");
        }

        public override void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
