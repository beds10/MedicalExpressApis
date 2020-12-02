using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class Detailord
    {
        public int DetailId { get; set; }
        public int quantity { get; set; }
        public decimal totalprice { get; set; }
        public int ProductDId { get; set; }
        public int OrderDId { get; set; }
        public int PaymentMethodDId { get; set; }

        public virtual MethodPayment MethodD { get; set; }
        public virtual Order OrderD { get; set; }
        public virtual Product ProductD { get; set; }
    }
}
