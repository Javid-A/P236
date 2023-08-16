using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Village:Settlement
    {
        public string Farm { get; set; }
        public Village(string name, uint population) : base(name, population)
        {
            Farm = "Animal husbandry";
        }
    }
}
