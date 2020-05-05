using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ThreatRiskRatingType
    {
        public ThreatRiskRatingType()
        {
            Threat = new HashSet<Threat>();
        }

        public int Id { get; set; }
        public string RiskRating { get; set; }
        public int RatingVal { get; set; }

        public virtual ICollection<Threat> Threat { get; set; }
    }
}
