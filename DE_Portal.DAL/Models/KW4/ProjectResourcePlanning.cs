using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectResourcePlanning
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int PlannedForUserId { get; set; }
        public int PlannedByUserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Ts { get; set; }

        public virtual Users PlannedByUser { get; set; }
        public virtual Users PlannedForUser { get; set; }
        public virtual ProjectTrackingProject Project { get; set; }
    }
}
