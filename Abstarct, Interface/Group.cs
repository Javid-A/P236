using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Interface
{
    internal class Group
    {
        string _no;
        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                if(value.Length != 4 || !char.IsLetter(value[0]))
                {
                    Console.WriteLine("Problem occurs");
                    return;
                }

                //P236
                for (int i = 1; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        Console.WriteLine("Problem occurs");
                        return;
                    }
                }
                _no = value;
                

            }
        }

        public byte AvgPoint;
    }
}
