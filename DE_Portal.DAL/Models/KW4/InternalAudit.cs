using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InternalAudit
    {
        public int Id { get; set; }
        public string AuditName { get; set; }
        public string Description { get; set; }
        public int AuditPersonId { get; set; }
        public DateTime? StartAuditDate { get; set; }
        public DateTime LastAuditDate { get; set; }
        public int AuditCycleDays { get; set; }
        public DateTime Ts { get; set; }
        public int IsAudit { get; set; }
        public string Schedule { get; set; }
        public int? Client { get; set; }
        public DateTime? EndAfterDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual Client ClientNavigation { get; set; }
    }
}
