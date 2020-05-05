using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Bpmheartbeat
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public string Guid { get; set; }
        public int TimeoutMinutes { get; set; }
        public string EscalationProcedure { get; set; }
        public DateTime? LastReportedTs { get; set; }
        public string LastReportedIp { get; set; }
        public string LastReportedPayload { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
