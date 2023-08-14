using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type__Collections
{
    internal class CustomList<T>
    {
        T[] _arr;
        public int Count
        {
            get
            {
                return _arr.Length;
            }
        }

        public CustomList()
        {
            _arr = Array.Empty<T>();
        }

        public void Add(T number)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = number;
        }

        public void ShowInside()
        {
            foreach (T item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
