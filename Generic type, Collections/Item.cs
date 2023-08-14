using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_type__Collections
{
    internal class Item<T>
    {
        #region Worst case
        //public string Quality;
        //public byte quality;
        //public char _quality;

        //public Item(string quality)
        //{
        //    Quality = quality;
        //}

        //public Item(byte quality)
        //{
        //    this.quality = quality;
        //}

        //public Item(char quality)
        //{
        //    _quality = quality;
        //} 
        #endregion

        public T Quality;

        public Item(T quality)
        {
            Quality = quality;
        }
    }
}
