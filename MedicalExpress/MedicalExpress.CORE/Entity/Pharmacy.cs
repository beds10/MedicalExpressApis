using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class Pharmacy
    {
        public Pharmacy()
        {
            OrderP = new HashSet<Order>();
            ProductPh = new HashSet<Product>();
        }



        public int PharmaId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int StatusPId { get; set; }

        public virtual Status StatusP { get; set; }
        public virtual ICollection<Order> OrderP { get; set; }
        public virtual ICollection<Product> ProductPh { get; set; }
      
    }
}
