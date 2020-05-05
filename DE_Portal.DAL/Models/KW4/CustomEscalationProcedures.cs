using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CustomEscalationProcedures
    {
        public CustomEscalationProcedures()
        {
            CustomEscalationProcedureDevices = new HashSet<CustomEscalationProcedureDevices>();
            CustomEscalationProcedureNotificationEmailOslist = new HashSet<CustomEscalationProcedureNotificationEmailOslist>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string MessagePattern { get; set; }
        public string EscalationProcedure { get; set; }
        public bool? AllDevicesSelected { get; set; }
        public string CustomDevicePattern { get; set; }
        public string Comments { get; set; }
        public DateTime? OverseerAfkemailLastSent { get; set; }
        public int? ProcedureCreator { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? OverseerExtendTimeEmailSent { get; set; }
        public bool? SendEmailNotificationsAllOs { get; set; }
        public int? ProcedureIdtag { get; set; }
        public DateTime ProcedureCreatedOn { get; set; }
        public int? ProcedureReviewer { get; set; }
        public DateTime? ProcedureReviewedOn { get; set; }
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

        public virtual Users ProcedureCreatorNavigation { get; set; }
        public virtual Users ProcedureReviewerNavigation { get; set; }
        public virtual ICollection<CustomEscalationProcedureDevices> CustomEscalationProcedureDevices { get; set; }
        public virtual ICollection<CustomEscalationProcedureNotificationEmailOslist> CustomEscalationProcedureNotificationEmailOslist { get; set; }
    }
}
