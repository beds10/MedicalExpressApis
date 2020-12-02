using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalExpress.CORE.DTOs
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public string Direction { get; set; }
        public string NumberCellphone { get; set; }
        public int ProfileId { get; set; }
    }
}
