using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Namespace__DLL
{
    internal class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string username, string password, bool isSuperAdmin, string section):base(username,password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Username}, {Password.GetHashCode()}, {(IsSuperAdmin ? "Super admindir":"Super Admin deyil")}, {Section}");
        }
    }
}
