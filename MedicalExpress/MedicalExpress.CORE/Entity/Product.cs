using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class Product
    {
        public Product()
        {
            DetailsPr = new HashSet<Detailord>();
            OrderPr = new HashSet<Order>();
        }

        public int ProductoId { get; set; }
        public string ProductImage { get; set; }

        public string Name { get; set; }
        public decimal UPrice { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string Product_stripe { get; set; }
        public string Price_stripe { get; set; }
        public int CategoryPrId { get; set; }
        public int StatusPrId { get; set; }
        public int PharmacyPrId { get; set; }

        public virtual Category CategoryPr { get; set; }
        public virtual Pharmacy PharmacyPr { get; set; }
        public virtual Status StatusPr { get; set; }
        public virtual ICollection<Detailord> DetailsPr { get; set; }
        public virtual ICollection<Order> OrderPr { get; set; }
    }
}
