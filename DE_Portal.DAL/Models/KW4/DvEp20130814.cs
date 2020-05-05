using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DvEp20130814
    {
        public string HostName { get; set; }
        public string ServiceName { get; set; }
        public string Action { get; set; }
        public string Method { get; set; }
        public string Priority { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string BackupContactName { get; set; }
        public string BackupContactEmail { get; set; }
        public string BackupContactPhone { get; set; }
        public string ContactPagerDuty { get; set; }
        public string BackupContactPagerDuty { get; set; }
    }
}
