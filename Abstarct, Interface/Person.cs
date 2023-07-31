using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Interface
{
    internal abstract class Person
    {
        public string Firstname;
        public string Lastname;



        public void GetInfo()
        {
            Console.WriteLine($"{Firstname} {Lastname}");
        }

        public virtual void GetRoutin()
        {
            Console.WriteLine("Yemek yeyir");
            Console.WriteLine("Yatir");
        }


        public abstract void Think();


    }
}
