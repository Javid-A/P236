using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class C : Tank, INonFireTankable
    {
       
        public void Discover(string a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
