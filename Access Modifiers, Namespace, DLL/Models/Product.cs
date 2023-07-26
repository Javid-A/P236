using System.Text;

namespace Access_Modifiers__Namespace__DLL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected string SameAssemblyBarcode { get; set; }
        protected internal bool SameAssemblyProtectedInternal;
    }
}
