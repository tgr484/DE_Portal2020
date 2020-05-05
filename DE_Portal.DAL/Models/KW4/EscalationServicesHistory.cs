using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EscalationServicesHistory
    {
        public int HistoryId { get; set; }
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Host { get; set; }
        public string HostGroup { get; set; }
        public string Service { get; set; }
        public string BacklogRelated { get; set; }
        public string Sop { get; set; }
        public string Sev { get; set; }
        public string Contact { get; set; }
        public string Component { get; set; }
        public string Eta { get; set; }
        public string ContactMethod { get; set; }
        public string Meaning { get; set; }
        public string Frequency { get; set; }
        public string Usage { get; set; }
        public string Alert { get; set; }
        public string Recomndation { get; set; }
        public string Area { get; set; }
        public string Info { get; set; }
        public string Query { get; set; }
        public string MonitorType { get; set; }
        public string ContactGroup1 { get; set; }
        public string ContactGroup2 { get; set; }
        public string ContactGroup3 { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedById { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
