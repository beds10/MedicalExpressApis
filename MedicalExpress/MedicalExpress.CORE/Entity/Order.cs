using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class Order
    {
        public Order()
        {
            AlarmO = new HashSet<Alarm>();
            DetailO = new HashSet<Detailord>();
        }

        public int OrderId { get; set; }
        public string Destination { get; set; }
        public string Session_token { get; set; }
        public decimal Total_compra { get; set; }
        public int PharmOId { get; set; }
        public int ProductOId { get; set; }
        public int UserOId { get; set; }
        public int StatusOId { get; set; }

        public virtual Status StatusO { get; set; }
        public virtual Pharmacy PharmacyO { get; set; }
        public virtual Product ProductO { get; set; }
        public virtual User UserO { get; set; }
        public virtual ICollection<Alarm> AlarmO { get; set; }
        public virtual ICollection<Detailord> DetailO { get; set; }
    }
}
