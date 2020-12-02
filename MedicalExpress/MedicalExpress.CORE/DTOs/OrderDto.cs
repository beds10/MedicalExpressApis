using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.CORE.DTOs
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string Destination { get; set; }
        public string Session_token { get; set; }
        public decimal Total_compra { get; set; }
        public int PharmOId { get; set; }
        public int ProductOId { get; set; }
        public int UserOId { get; set; }
        public int StatusOId { get; set; }

    }
}
