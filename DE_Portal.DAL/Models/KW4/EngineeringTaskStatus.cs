using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EngineeringTaskStatus
    {
        public int Id { get; set; }
        public int Client { get; set; }
        public int? ProjectId { get; set; }
        public string Task { get; set; }
        public int Severity { get; set; }
        public DateTime DueDate { get; set; }
        public int AssignedTo { get; set; }
        public string Status { get; set; }

        public virtual Client ClientNavigation { get; set; }
        public virtual ProjectTrackingProject Project { get; set; }
        public virtual ProjectPriority SeverityNavigation { get; set; }
    }
}
