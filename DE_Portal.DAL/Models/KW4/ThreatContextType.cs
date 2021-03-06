﻿using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ThreatContextType
    {
        public ThreatContextType()
        {
            Threat = new HashSet<Threat>();
        }

        public int Id { get; set; }
        public string Context { get; set; }

        public virtual ICollection<Threat> Threat { get; set; }
    }
}
