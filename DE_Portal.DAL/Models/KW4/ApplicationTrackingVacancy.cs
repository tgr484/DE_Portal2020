using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ApplicationTrackingVacancy
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int FacilityId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime Ts { get; set; }
    }
}
