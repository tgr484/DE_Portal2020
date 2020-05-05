using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ExecUpdateDev
    {
        public int Id { get; set; }
        public DateTime Ts { get; set; }
        public string TimeFrame { get; set; }
        public decimal? NumberofProjects { get; set; }
        public decimal? DelayedProjectsDe { get; set; }
        public decimal? DelayedProjectsClient { get; set; }
        public decimal? TotalDelayedProjects { get; set; }
        public decimal? CompletedProjects { get; set; }
        public decimal? ProjectHoursSpent { get; set; }
        public decimal? OpsTicketHoursSpent { get; set; }
        public decimal? ManagementHoursSpent { get; set; }
        public decimal? Qahours { get; set; }
        public decimal? ProjectHoursOverAllowedLimit { get; set; }
        public decimal? TotalHoursSpent { get; set; }
        public decimal? ProjectHoursUpcoming { get; set; }
        public decimal? OpsTicketHoursUpcoming { get; set; }
        public decimal? ManagementHoursUpcoming { get; set; }
        public decimal? TotalHoursUpcoming { get; set; }
        public decimal? Resources { get; set; }
        public decimal? Schedule { get; set; }
        public decimal? OverallDepartmentRatingbyManager { get; set; }
        public decimal? DepartmentChange { get; set; }
        public decimal? DepartmentRating { get; set; }
    }
}
