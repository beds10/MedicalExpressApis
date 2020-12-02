using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class Profile
    {
        public Profile()
        {
            UserProfile = new HashSet<User>();
        }

        public int ProfileId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> UserProfile { get; set; }
    }
}
