using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class VReportTiketsTimeTaken
    {
        public int Id { get; set; }
        public DateTime? OpenDate { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ClientName { get; set; }
        public string Uid { get; set; }
        public DateTime? OwnerDateTime { get; set; }
        public int? Mins { get; set; }
        public string OwnerTime { get; set; }
        public int? DutyUserId { get; set; }
    }
}
