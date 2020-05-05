using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class IsoMonitoringMain
    {
        public IsoMonitoringMain()
        {
            IsoMonitoringMonth = new HashSet<IsoMonitoringMonth>();
        }

        public int Id { get; set; }
        public string WhatToMonitor { get; set; }
        public int WhoSetup { get; set; }
        public int WhoEval { get; set; }
        public int Year { get; set; }

        public virtual ICollection<IsoMonitoringMonth> IsoMonitoringMonth { get; set; }
    }
}
