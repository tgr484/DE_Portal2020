using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceHeartbeatAlertLevels
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public int? WarnCycleCount { get; set; }
        public int? CritAlertCount { get; set; }
    }
}
