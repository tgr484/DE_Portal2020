using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectResourceActual
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public string OtherProject { get; set; }
        public int UserId { get; set; }
        public DateTime ReportedDate { get; set; }
        public int Hours { get; set; }
        public DateTime Ts { get; set; }

        public virtual ProjectTrackingProject Project { get; set; }
        public virtual Users User { get; set; }
    }
}
