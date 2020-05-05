using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SystemEventToDevice
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int SystemEventId { get; set; }
        public DateTime Ts { get; set; }
    }
}
