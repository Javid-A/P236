using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type__Collections
{
    internal class CustomDictionary<K,T> where T : new()
    {
        public K Id { get; set; }
        public T  Quality{ get; set; }
    }
}
