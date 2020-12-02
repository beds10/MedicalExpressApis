using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class MethodPayment
    {
        public MethodPayment()
        {
            DetailOrdM = new HashSet<Detailord>();
        }

        public int PaymentId { get; set; }
        public string MethodName { get; set; }

        public virtual ICollection<Detailord> DetailOrdM { get; set; }
    }
}
