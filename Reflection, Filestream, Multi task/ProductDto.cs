using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection__Filestream__Multi_task
{
    internal class ProductDto
    {
        string PrivateField;
        public string PublicField = "This is public field";
        public double Price { get; set; }
        public ProductDto(string privatefield)
        {
            PrivateField = privatefield;
        }
    }
}
