using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ThreatReviewChangeLog
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int ThreatReviewId { get; set; }
        public Guid ChangeHash { get; set; }
        public string ColumnTitle { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual Users CreatedUser { get; set; }
        public virtual ThreatReview ThreatReview { get; set; }
    }
}
