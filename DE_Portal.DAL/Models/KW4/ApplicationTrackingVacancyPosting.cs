using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ApplicationTrackingVacancyPosting
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string WebAddress { get; set; }
        public int VacancyId { get; set; }
        public DateTime? DatePosted { get; set; }
        public string Duration { get; set; }
        public DateTime? Expiration { get; set; }
        public string Fee { get; set; }
        public bool Status { get; set; }
        public DateTime Ts { get; set; }
    }
}
