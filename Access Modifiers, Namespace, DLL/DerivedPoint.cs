using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Namespace__DLL
{
    public class DerivedPoint:Point
    {
        public DerivedPoint()
        {
        }

        static void Test()
        {
            Point point = new Point();
            DerivedPoint derived = new DerivedPoint();
        }
    }
}
