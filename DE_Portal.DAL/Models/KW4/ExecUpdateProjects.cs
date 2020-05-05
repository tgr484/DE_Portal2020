using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ExecUpdateProjects
    {
        public int Id { get; set; }
        public DateTime Ts { get; set; }
        public string TimeFrame { get; set; }
        public decimal? NumberofProjects { get; set; }
        public decimal? ProjNumberofProjectsUpcomingWeek { get; set; }
        public decimal? NumberofProjectsWorkedOn { get; set; }
        public decimal? DelayedProjectsDe { get; set; }
        public decimal? DelayedProjectsClient { get; set; }
        public decimal? TotalDelayedProjects { get; set; }
        public decimal? CompletedProjects { get; set; }
        public decimal? ProjectHoursSpent { get; set; }
        public decimal? OpsTicketHoursSpent { get; set; }
        public decimal? ManagementHoursSpent { get; set; }
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
        public decimal? AmberAlert75 { get; set; }
        public decimal? ProjectsPlannedHours76 { get; set; }
        public decimal? ProjectsActualHours77 { get; set; }
        public decimal? TimePerformanceIndexTpi78 { get; set; }
        public decimal? TimePerformanceindexTpigreen79 { get; set; }
    }
}
