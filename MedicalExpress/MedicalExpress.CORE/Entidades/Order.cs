using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entidades
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int PharmOId { get; set; }
        public int UserOId { get; set; }

        public virtual Pharmacy PharmacyO { get; set; }
        public virtual User UserO { get; set; }
    }
}
