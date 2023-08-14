using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type__Collections
{
    internal class Group:ITestable
    {
        public string No { get; set; }
        public double Overall { get; set; }

        public Group(string no, double overall)
        {
            No = no;
            Overall = overall;
        }
        public Group()
        {
            
        }

        public override string ToString()
        {
            return $"{No}";
        }
    }
}
