using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceCustomPerfCounter
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int CustomPerfCounterId { get; set; }
        public long? WarnLevel { get; set; }
        public long? CritLevel { get; set; }
        public DateTime Ts { get; set; }
    }
}
