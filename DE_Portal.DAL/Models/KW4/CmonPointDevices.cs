using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CmonPointDevices
    {
        public int PointId { get; set; }
        public int? DeviceId { get; set; }
        public string EscalationProcedure { get; set; }
    }
}
