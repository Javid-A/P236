using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Interface
{
    internal class Student:Person
    {
        public byte Grade;
        public override void GetRoutin()
        {
            Console.WriteLine("Yuxudan duran kimi linkleri oxumalidir");
            Console.WriteLine("Oxudugunu praktika etmelidir");
            Console.WriteLine("Suallari oldugu zaman qeyd aparmalidir");
            Console.WriteLine("Program.cs-de qeyd olunan teacher obyektine datalar oturulmelidir");
        }

        public override void Think()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
