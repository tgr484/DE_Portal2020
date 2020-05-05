using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ThreatActionPlanType
    {
        public ThreatActionPlanType()
        {
            Threat = new HashSet<Threat>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
        public int? OrderIndex { get; set; }

        public virtual ICollection<Threat> Threat { get; set; }
    }
}
