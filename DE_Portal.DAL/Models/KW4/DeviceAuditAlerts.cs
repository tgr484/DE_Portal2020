using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceAuditAlerts
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public int? DeviceAlarmTypeId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime ScheduleFollowUp { get; set; }
        public string ResolutionNote { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public DateTime Ts { get; set; }
        public int? ClientId { get; set; }
        public bool? Main { get; set; }
        public bool? Na { get; set; }
        public bool? Ps { get; set; }
        public bool? Hd { get; set; }
        public string SubdeviceStatuses { get; set; }
    }
}
