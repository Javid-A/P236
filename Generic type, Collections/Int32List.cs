using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type__Collections
{
    internal class Int32List
    {
        int[] _arr;
        public int Count
        {
            get
            {
                return _arr.Length;
            }
        }

        public Int32List()
        {
            _arr = Array.Empty<int>();
        }

        public void Add(int number)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = number;
        }

        public void ShowInside()
        {
            foreach (int item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
