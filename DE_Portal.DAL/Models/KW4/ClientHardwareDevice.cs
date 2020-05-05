using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientHardwareDevice
    {
        public int Id { get; set; }
        public int ClientHardware { get; set; }
        public int Device { get; set; }
        public DateTime? EndOfLifeDate { get; set; }

        public virtual ClientHardware ClientHardwareNavigation { get; set; }
        public virtual Device DeviceNavigation { get; set; }
    }
}
