using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entidades
{
    public partial class Category
    {
        public Category()
        {
            ProductC = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> ProductC { get; set; }
    }
}
