using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ReportTemplateSectionType
    {
        public ReportTemplateSectionType()
        {
            ReportTemplateSection = new HashSet<ReportTemplateSection>();
        }

        public int ReportTemplateSectionTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ReportTemplateSection> ReportTemplateSection { get; set; }
    }
}
