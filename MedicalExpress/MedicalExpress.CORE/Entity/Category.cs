using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class Category
    {
        public Category()
        {
            Productos = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Productos { get; set; }
    }
}
