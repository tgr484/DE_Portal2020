using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceAuditAlertFollowupHistory
    {
        public int Id { get; set; }
        public int AuditAlertId { get; set; }
        public DateTime FollowUpDate { get; set; }
        public string FollowUpMessage { get; set; }
        public DateTime Ts { get; set; }
    }
}
