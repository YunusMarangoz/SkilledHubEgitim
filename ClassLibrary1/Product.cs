using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        

        public decimal Price { get; set; }
        public string? Brand { get; set; }
        public int stock { get; set; }
        public bool IsActive { get; set; }
        public Category? Category { get; set; }//Prodcut ile Category arasında 1 e 1 ilişki kurduk
        public int CategoryID { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
