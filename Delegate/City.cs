using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class City: Settlement
    {
        public string PoliceDepartment { get; set; }
        public City(string name, uint population) : base(name, population)
        {
            PoliceDepartment = "Nesimi polis bolmesi";
        }
    }
}
