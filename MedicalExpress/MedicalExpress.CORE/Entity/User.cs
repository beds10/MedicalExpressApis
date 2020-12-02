using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entity
{
    public partial class User
    {
        public User()
        {
            AlarmU = new HashSet<Alarm>();
            PhotoUserU = new HashSet<PhotoUser>();
            OrderU = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Direction { get; set; }
        public string NumberCellphone { get; set; }
        public int ProfileId { get; set; }

        public virtual Profile IdPerfilNavigation { get; set; }
        public virtual ICollection<Alarm> AlarmU { get; set; }
        public virtual ICollection<PhotoUser> PhotoUserU { get; set; }
        public virtual ICollection<Order> OrderU { get; set; }
    }
}
