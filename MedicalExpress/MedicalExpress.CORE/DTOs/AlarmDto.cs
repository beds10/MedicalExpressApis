using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.CORE.DTOs
{
    public class AlarmDto
    {
        public int AlarmId { get; set; }
        public int OrderId { get; set; }
        public int UserId { get; set; }
    }
}
