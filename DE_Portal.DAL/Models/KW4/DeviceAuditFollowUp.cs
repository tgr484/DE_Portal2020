using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceAuditFollowUp
    {
        public int Id { get; set; }
        public int DeviceAuditItemId { get; set; }
        public string Note { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Users CreatedUser { get; set; }
        public virtual DeviceAuditItem DeviceAuditItem { get; set; }
    }
}
