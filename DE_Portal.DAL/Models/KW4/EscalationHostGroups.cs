using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EscalationHostGroups
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string HostGroup { get; set; }
        public string HostName { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedById { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
