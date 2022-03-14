using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Devices.Domain.Enum.GeneralEnum;

namespace Devices.Domain.Entities
{
    public class Device:BaseEntity
    {
        public string Name { get; set; }
        public DeviceStatusEnum Status { get; set; }
        public string Temperature { get; set; }
        public string Usage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateddAt { get; set; }
    }
}
