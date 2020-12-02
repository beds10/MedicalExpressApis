using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.CORE.DTOs
{
    public class DetailordDto
    {
        public int DetailId { get; set; }
        public int quantity { get; set; }
        public decimal totalprice { get; set; }
        public int ProductDId { get; set; }
        public int OrderDId { get; set; }
        public int PaymentMethodDId { get; set; }
    }
}
