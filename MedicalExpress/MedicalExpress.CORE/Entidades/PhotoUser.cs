using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entidades
{
    public partial class PhotoUser
    {
        public int PhotoId { get; set; }
        public string Name { get; set; }
        public int UserIdP { get; set; }

        public virtual User UserP { get; set; }
    }
}
