using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceConfigInfo
    {
        public DeviceConfigInfo()
        {
            DeviceConfig = new HashSet<DeviceConfig>();
            DeviceConfigHistory = new HashSet<DeviceConfigHistory>();
        }

        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? DeviceId { get; set; }
        public string ConfigType { get; set; }
        public string FwName { get; set; }
        public string FwVdom { get; set; }
        public string FwIp { get; set; }
        public string FwPort { get; set; }
        public string FwUser { get; set; }
        public string FwPassword { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? LastChecked { get; set; }
        public bool? Enabled { get; set; }

        public virtual Client Client { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Device Device { get; set; }
        public virtual Users UpdatedByNavigation { get; set; }
        public virtual ICollection<DeviceConfig> DeviceConfig { get; set; }
        public virtual ICollection<DeviceConfigHistory> DeviceConfigHistory { get; set; }
    }
}
