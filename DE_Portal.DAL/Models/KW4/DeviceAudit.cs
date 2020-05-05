using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceAudit
    {
        public DeviceAudit()
        {
            DeviceAuditItem = new HashSet<DeviceAuditItem>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int ClientId { get; set; }
        public string DeviceNotices { get; set; }
        public string GeneralNotes { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedUserId { get; set; }
        public int? SiteId { get; set; }
        public byte? IsHidden { get; set; }

        public virtual Client Client { get; set; }
        public virtual Users CreatedUser { get; set; }
        public virtual Users LastModifiedUser { get; set; }
        public virtual Site Site { get; set; }
        public virtual ICollection<DeviceAuditItem> DeviceAuditItem { get; set; }
    }
}
