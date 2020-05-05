using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ApplicationTrackingFacility
    {
        public int Id { get; set; }
        public int VacancyId { get; set; }
        public int FacilityId { get; set; }
        public DateTime Ts { get; set; }
    }
}
