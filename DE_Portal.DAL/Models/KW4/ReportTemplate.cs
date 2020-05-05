using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ReportTemplate
    {
        public ReportTemplate()
        {
            Report = new HashSet<Report>();
            ReportTemplateSection = new HashSet<ReportTemplateSection>();
        }

        public int ReportTemplateId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Report> Report { get; set; }
        public virtual ICollection<ReportTemplateSection> ReportTemplateSection { get; set; }
    }
}
