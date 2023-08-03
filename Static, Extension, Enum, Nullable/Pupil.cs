using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extension__Enum__Nullable
{
    internal class Pupil
    {
        public string Firstname;
        public string Lastname;
        public string FatherName;
        public static string SchoolNo;

        public Pupil(string firstname, string lastname, string fatherName)
        {
            Firstname = firstname;
            Lastname = lastname;
            FatherName = fatherName;
        }
    }
}
