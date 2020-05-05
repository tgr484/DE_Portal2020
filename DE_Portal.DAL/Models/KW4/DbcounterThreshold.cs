using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DbcounterThreshold
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Expression { get; set; }
        public string Root { get; set; }
        public string Parameter1 { get; set; }
        public string Parameter2 { get; set; }
        public string Parameter3 { get; set; }
        public double? WarningLevel { get; set; }
        public double? AlertLevel { get; set; }
        public string Type { get; set; }
        public bool? Enabled { get; set; }
        public bool? GenerateAlerts { get; set; }
    }
}
