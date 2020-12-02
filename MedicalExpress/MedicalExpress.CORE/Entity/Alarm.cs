using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class Alarm
    {
        public int AlarmId { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }

        public virtual Order OrderA { get; set; }
        public virtual User UserA { get; set; }
    }
}
