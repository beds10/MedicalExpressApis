using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entidades
{
    public partial class Alarm
    {
        public int AlarmId { get; set; }
        public int UserId { get; set; }
        public int PharmacyAId { get; set; }

        public virtual Pharmacy PharmacyA { get; set; }
        public virtual User UserA { get; set; }
    }
}
