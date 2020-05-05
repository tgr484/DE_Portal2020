using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Maintenance20180217
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? DeviceId { get; set; }
        public string DevicePattern { get; set; }
        public string AlertPattern { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Notes { get; set; }
        public bool IsRecurring { get; set; }
        public int? RecurNumDay { get; set; }
        public int? RecurNumWeek { get; set; }
        public int? RecurWeekdaysHash { get; set; }
        public int? RecurNumMonth { get; set; }
        public int? RecurMonthDayOffset { get; set; }
        public int? RecurMonthNthWeek { get; set; }
        public int? RecurMonthWeekday { get; set; }
        public DateTime? RecurTimeFrom { get; set; }
        public DateTime? RecurTimeTo { get; set; }
    }
}
