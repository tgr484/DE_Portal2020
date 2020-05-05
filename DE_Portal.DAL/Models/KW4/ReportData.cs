using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ReportData
    {
        public int ReportDataId { get; set; }
        public int ReportId { get; set; }
        public int ReportTemplateSectionId { get; set; }
        public string TextData { get; set; }

        public virtual Report Report { get; set; }
        public virtual ReportTemplateSection ReportTemplateSection { get; set; }
    }
}
