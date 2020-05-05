using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceAuditItem
    {
        public DeviceAuditItem()
        {
            DeviceAuditFollowUp = new HashSet<DeviceAuditFollowUp>();
        }

        public int Id { get; set; }
        public int DeviceAuditId { get; set; }
        public int DeviceId { get; set; }
        public bool Ok { get; set; }
        public bool Attention { get; set; }
        public bool NotAvaible { get; set; }
        public bool HardDrive { get; set; }
        public bool PowerSupply { get; set; }
        public string Note { get; set; }
        public bool? IsResolved { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public bool Missed { get; set; }

        public virtual Device Device { get; set; }
        public virtual DeviceAudit DeviceAudit { get; set; }
        public virtual ICollection<DeviceAuditFollowUp> DeviceAuditFollowUp { get; set; }
    }
}
