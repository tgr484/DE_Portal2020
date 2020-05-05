using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectTrackingProjectStatementOfCompletionFile
    {
        public int Id { get; set; }
        public int Ptpref { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] File { get; set; }

        public virtual ProjectTrackingProject PtprefNavigation { get; set; }
    }
}
