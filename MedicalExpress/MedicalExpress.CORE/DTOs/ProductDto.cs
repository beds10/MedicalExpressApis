using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.CORE.DTOs
{
    public class ProductDto
    {

        public int ProductoId { get; set; }
        public string ProductImage { get; set; }
        public string Name { get; set; }
        public decimal UPrice { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public int CategoryPrId { get; set; }
        public int StatusPrId { get; set; }
        public int PharmacyPrId { get; set; }
        public string Product_stripe { get; set; }
        public string Price_stripe { get; set; }
    }
}
