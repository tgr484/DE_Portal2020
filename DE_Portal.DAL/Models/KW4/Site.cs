using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Site
    {
        public Site()
        {
            ClientSite = new HashSet<ClientSite>();
            Device = new HashSet<Device>();
            DeviceAudit = new HashSet<DeviceAudit>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<ClientSite> ClientSite { get; set; }
        public virtual ICollection<Device> Device { get; set; }
        public virtual ICollection<DeviceAudit> DeviceAudit { get; set; }
    }
}
