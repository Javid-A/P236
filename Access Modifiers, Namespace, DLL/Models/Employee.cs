using DLL.Base_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Namespace__DLL.Models
{
    internal class Employee:Person
    {
        public double Salary;

        public Employee()
        {
            Person person1 = new Person();
            AnotherAssemblyProtected = "";
            AnotherAssemblyProtectedInternal = "";
        }   
    }
}
