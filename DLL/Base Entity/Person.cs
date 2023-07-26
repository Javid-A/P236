using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Base_Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string Name;
        private protected string Lastname;
        protected internal string AnotherAssemblyProtectedInternal;
        protected string AnotherAssemblyProtected;
    }
}
