using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IFireTankable
    {
        public int GetId { get; set; }
        void Fire();

        //public IFireTankable() Interface-in constructoru olmur! ! !
        //{

        //}
    }
}
