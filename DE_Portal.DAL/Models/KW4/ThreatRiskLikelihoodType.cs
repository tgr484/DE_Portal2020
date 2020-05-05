using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ThreatRiskLikelihoodType
    {
        public ThreatRiskLikelihoodType()
        {
            Threat = new HashSet<Threat>();
        }

        public int Id { get; set; }
        public string Likelihood { get; set; }
        public int LikelihoodVal { get; set; }

        public virtual ICollection<Threat> Threat { get; set; }
    }
}
