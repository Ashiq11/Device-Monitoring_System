using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices.Domain.Entities
{
    public class AppUser : BaseEntity
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int UserDetailId { get; set; }
        public virtual UserDetail UserDetail { get; set; }
        public bool IsDisabled { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateddAt { get; set; }

    }
}
