using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entidades
{
    public partial class Product
    {
        public int ProductoId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Stock { get; set; }
        public int PharIdP { get; set; }
        public int CatIdP { get; set; }

        public virtual Category CategoryP { get; set; }
        public virtual Pharmacy PharmacyP { get; set; }
    }
}
