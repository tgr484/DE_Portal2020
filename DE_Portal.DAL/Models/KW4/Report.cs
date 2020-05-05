using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Report
    {
        public Report()
        {
            ReportData = new HashSet<ReportData>();
        }

        public int ReportId { get; set; }
        public int ReportTemplateId { get; set; }
        public string Name { get; set; }
        public int? ClientId { get; set; }
        public int? DeviceId { get; set; }
        public string Instance { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public DateTime? GeneratedOn { get; set; }

        public virtual ReportTemplate ReportTemplate { get; set; }
        public virtual ICollection<ReportData> ReportData { get; set; }
    }
}
