using System;
using System.Collections.Generic;

namespace MedicalExpress.CORE.Entidades
{
    public partial class User
    {
        public User()
        {
            AlarmU = new HashSet<Alarm>();
            PhotouserU = new HashSet<PhotoUser>();
            OrderU = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public int PerfilIdU { get; set; }

        public virtual Profile ProfileU { get; set; }
        public virtual ICollection<Alarm> AlarmU { get; set; }
        public virtual ICollection<PhotoUser> PhotouserU { get; set; }
        public virtual ICollection<Order> OrderU { get; set; }
    }
}
