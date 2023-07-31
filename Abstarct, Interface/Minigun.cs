using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Interface
{
    internal class Minigun:Gun
    {
        //public override void Fire()
        //{
        //    for (int i = 1; i <= 100; i++)
        //    {
        //        Console.WriteLine($"{i}.Fire");
        //    }
        //}

        public override void Fire()
        {
            Console.WriteLine("Another");
            base.Fire();
        }
        public override string ToString()
        {
            return "Test";
        }
    }
}
