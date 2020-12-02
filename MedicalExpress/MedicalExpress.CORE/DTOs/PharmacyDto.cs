using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.CORE.DTOs
{
    public class PharmacyDto
    {
        public int PharmaId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int StatusPId { get; set; }

    }
}
