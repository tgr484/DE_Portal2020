using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CustomMonitoringAlertRules
    {
        public int Id { get; set; }
        public int MessageTypeId { get; set; }
        public int DeviceId { get; set; }
        public string EmailFrom { get; set; }
        public string EmailSubject { get; set; }
        public byte Enabled { get; set; }
        public string Comments { get; set; }
        public int? CriticalCount { get; set; }
        public int? ScheduleWeekDayMask { get; set; }
        public DateTime? ScheduleStartTime { get; set; }
        public DateTime? ScheduleEndTime { get; set; }
        public int? AlertTimeoutMinutes { get; set; }
        public DateTime Ts { get; set; }
        public string EmailBody { get; set; }
        public string DoesNotContain { get; set; }
        public int GenerateTicket { get; set; }
    }
}
