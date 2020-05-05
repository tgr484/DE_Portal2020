using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectTrackingFacilities
    {
        public int Id { get; set; }
        public int ProjectTrackingProjectId { get; set; }
        public int UsfacilitiesId { get; set; }
        public DateTime Ts { get; set; }
    }
}
