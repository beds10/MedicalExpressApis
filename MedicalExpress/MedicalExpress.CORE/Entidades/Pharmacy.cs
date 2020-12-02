using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entidades
{
    public partial class Pharmacy
    {
        public Pharmacy()
        {
            AlarmP = new HashSet<Alarm>();
            OrderP = new HashSet<Order>();
            ProductP = new HashSet<Product>();
        }

        public int PharmaId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public virtual ICollection<Alarm> AlarmP { get; set; }
        public virtual ICollection<Order> OrderP { get; set; }
        public virtual ICollection<Product> ProductP { get; set; }
    }
}
