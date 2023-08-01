using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class B : Tank, IFireTankable
    {
        public int GetId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Fire()
        {
            Console.WriteLine("B type tank fire");
        }
    }
}
