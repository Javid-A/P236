using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Interface.Company
{
    internal abstract class Employee
    {
        protected double Salary;
        public abstract double WorkHours { get; set; }

        public abstract void Test();
    }
}
