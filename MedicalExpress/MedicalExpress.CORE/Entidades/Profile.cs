using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entidades
{
    public partial class Profile
    {
        public Profile()
        {
            UserP = new HashSet<User>();
        }

        public int ProfileId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> UserP { get; set; }
    }
}
