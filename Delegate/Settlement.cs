using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal abstract class Settlement
    {
        public string Name { get; set; }
        public uint Population { get; set; }

        public Settlement(string name, uint population)
        {
            Name = name;
            Population = population;
        }
       

    }
}
