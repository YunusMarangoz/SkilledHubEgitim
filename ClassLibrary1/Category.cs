using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Product>? Products { get; set; }//Category ile Product arasında 1 e 1 ilişki kurduk. 1 kategoride 1 den çok ürün bulunabilir.
    }
}
