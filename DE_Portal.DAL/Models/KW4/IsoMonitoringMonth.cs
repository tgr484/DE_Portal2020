using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class IsoMonitoringMonth
    {
        public int Id { get; set; }
        public int MainId { get; set; }
        public int MonthVal { get; set; }
        public bool IsBeingMonitored { get; set; }
        public int Who { get; set; }
        public string WhoObserv { get; set; }
        public int WhoEval { get; set; }
        public string WhoEvalObserv { get; set; }

        public virtual IsoMonitoringMain Main { get; set; }
    }
}
