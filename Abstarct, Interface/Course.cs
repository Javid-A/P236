using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct__Interface
{
    internal class Course
    {
        public Group[] Groups;

        public Course()
        {
            Groups = new Group[3];
        }


        public void GetGroupByNo(string no)
        {
            foreach (Group group in Groups)
            {
                if (group.No == no)
                {
                    Console.WriteLine(group.No);
                }
            }
        }
        public void GetGroupsByPointRange(byte min, byte max)
        {
            foreach (Group group in Groups)
            {
                if(group.AvgPoint>=min && group.AvgPoint <= max)
                {
                    Console.WriteLine(group.No);
                }
            }
        }
    }
}
