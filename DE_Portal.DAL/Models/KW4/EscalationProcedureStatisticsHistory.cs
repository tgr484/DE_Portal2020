using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EscalationProcedureStatisticsHistory
    {
        public int Id { get; set; }
        public DateTime DateofReview { get; set; }
        public int Creator { get; set; }
        public int Reviewer { get; set; }
        public bool Approved { get; set; }
        public bool ApprovedCorrected { get; set; }
        public bool Rejected { get; set; }

        public virtual Users CreatorNavigation { get; set; }
        public virtual Users ReviewerNavigation { get; set; }
    }
}
