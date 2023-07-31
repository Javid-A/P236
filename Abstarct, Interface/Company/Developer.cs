using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Interface.Company
{
    internal class Developer : Employee
    {
        public override double WorkHours
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value * 30;
            }
        }

        public override void Test()
        {
            throw new NotImplementedException();
        }
    }
}
