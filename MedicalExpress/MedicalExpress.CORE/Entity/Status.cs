using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class Status
    {
        public Status()
        {
            PharmacyS = new HashSet<Pharmacy>();
            OrderS = new HashSet<Order>();
            ProductS = new HashSet<Product>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Pharmacy> PharmacyS { get; set; }
        public virtual ICollection<Order> OrderS { get; set; }
        public virtual ICollection<Product> ProductS { get; set; }
    }
}
