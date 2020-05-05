using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Articles
    {
        public string FilePath { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateCached { get; set; }
        public DateTime? Ts { get; set; }
        public string FileContent { get; set; }
        public string VisibleTo { get; set; }
        public int ClientId { get; set; }
        public int DeviceId { get; set; }
        public int? AreaOfWorkId { get; set; }
        public int Id { get; set; }
        public int TechOrCompliance { get; set; }
        public string Department { get; set; }
        public string BriefDescription { get; set; }
        public int ReviewedBy { get; set; }
        public int ApprovedBy { get; set; }
        public int Status { get; set; }
        public decimal? Version { get; set; }

        public virtual AreaOfWork AreaOfWork { get; set; }
    }
}
