using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extension__Enum__Nullable
{
    internal class Employee
    {
        public int Id;
        public string Profession;
        public static int Count;


        static Employee()
        {
            Console.WriteLine("Static constructor called");
        }
        public Employee(string profession)
        {
            this.Profession = profession;
            Id = ++Count;
            Console.WriteLine("Non-static constructor called");
        }
        public static void ShowCount()
        {
            Console.WriteLine(Count);
        }

        public void ShowCountWithoutStatic()
        {
            Console.WriteLine(Profession);
        }


        public static void ShowProfession()
        {
            Console.WriteLine();//Profession 
        }
    }
}
