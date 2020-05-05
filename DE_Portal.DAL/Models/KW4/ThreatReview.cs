using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ThreatReview
    {
        public ThreatReview()
        {
            ThreatReviewChangeLog = new HashSet<ThreatReviewChangeLog>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime ReviewDate { get; set; }
        public int NumberOfIncidents { get; set; }
        public string ActionPlanReview { get; set; }
        public string ActionPlanReviewResults { get; set; }
        public DateTime? CompletionDate { get; set; }

        public virtual Users CreatedUser { get; set; }
        public virtual ICollection<ThreatReviewChangeLog> ThreatReviewChangeLog { get; set; }
    }
}
