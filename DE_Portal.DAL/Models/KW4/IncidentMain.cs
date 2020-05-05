using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class IncidentMain
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int Recorded { get; set; }
        public int Employee { get; set; }
        public string EmployeeTitle { get; set; }
        public int Manager { get; set; }
        public string ManagerTitle { get; set; }
        public DateTime EventOccurred { get; set; }
        public int Client { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public string ManagementComments { get; set; }
        public int? Unsatisfactory { get; set; }
        public string UnsatisfactoryComm { get; set; }
        public int? AdminAction { get; set; }
        public string AdminActionComm { get; set; }
        public DateTime? ManagerUpdated { get; set; }
        public string BriefIncident { get; set; }
        public int Category { get; set; }
        public int? RiskAssetType { get; set; }
        public int? RiskName { get; set; }
        public int? RiskType { get; set; }

        public virtual ThreatAssetType RiskAssetTypeNavigation { get; set; }
        public virtual Threat RiskNameNavigation { get; set; }
        public virtual Threat RiskTypeNavigation { get; set; }
    }
}
