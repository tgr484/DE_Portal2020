using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ReportTemplateSection
    {
        public ReportTemplateSection()
        {
            ReportData = new HashSet<ReportData>();
        }

        public int ReportTemplateSectionId { get; set; }
        public int ReportTemplateId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int ReportTemplateSectionTypeId { get; set; }
        public string Sqlquery { get; set; }
        public bool StartsChapter { get; set; }
        public bool StartsSection { get; set; }
        public string Flow { get; set; }
        public int? SortOrder { get; set; }
        public Guid Uid { get; set; }

        public virtual ReportTemplate ReportTemplate { get; set; }
        public virtual ReportTemplateSectionType ReportTemplateSectionType { get; set; }
        public virtual ICollection<ReportData> ReportData { get; set; }
    }
}
